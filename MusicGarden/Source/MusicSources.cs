using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MusicGarden.Http;

namespace MusicGarden.Source
{
    public class MusicSources
    {

        public static MusicSources Instance
        {
            get
            {
                return Holder.Sources;
            }
        }

        public List<IMusicSource> Sources
        {
            get; set;
        } = new List<IMusicSource>();


        public void AddMusicSource(IMusicSource Source)
        {
            Sources.Add(Source);
            type2Source.Add(Source.Name, Source);
        }

        Dictionary<string, IMusicSource> type2Source = new Dictionary<string, IMusicSource>();

        public string Name => "MusicSources";

        public string getDownloadUrl(Song song)
        {
            return type2Source[song.Source].getDownloadUrl(song);
        }


        public List<MergedSong> SearchSongs(string keyword, int page, int pageSize)
        {
            var songs = new List<Song>();
            Sources.AsParallel().ForAll(Source =>
            {
                var currentSongs = Source.SearchSongs(keyword, page, pageSize);
                songs.AddRange(currentSongs);
            });
            return songs.GroupBy(s => s.GetMergedKey()).Select(g => new MergedSong(g.ToList())).OrderByDescending(s => s.Score).ToList();//聚合
        }

        static class Holder
        {
            public static MusicSources Sources = Load();

            /// <summary>
            /// 从当前程序集加载
            /// </summary>
            /// <returns></returns>
            private static MusicSources Load()
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                List<Type> hostTypes = new List<Type>();

                foreach (var type in assembly.GetExportedTypes())
                {
                    if (type.Name == "MusicSources")
                    {
                        continue;
                    }
                   
                    if (type.IsClass && typeof(IMusicSource).IsAssignableFrom(type) && !type.IsAbstract) //确定type为类并且继承实现接口实例
                        hostTypes.Add(type);
                }

                MusicSources musicSources = new MusicSources();
                foreach (var type in hostTypes)
                {
                    IMusicSource instance = (IMusicSource)Activator.CreateInstance(type);
                    musicSources.AddMusicSource(instance);
                }

                return musicSources;
            }
        }
    }
}
