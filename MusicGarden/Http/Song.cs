using System.Collections.Generic;
using System.Linq;
using MusicGarden.Source;
namespace MusicGarden.Http
{
    public class Song
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Singer { get; set; }
        public string Album { get; set; }
        public string Source { get; set; }
        public double Duration { get; set; }
        public double Size { get; set; }
        public string Url { get; set; }
        public int Rate { get; set; }
        public int Index { get; set; }

        public string GetFileName()
        {
            return Singer + "-" + Name + ".mp3";
        }

        public string GetMergedKey()
        {
            return Name.Replace(" ", "")+Singer.Replace(" ", "") +  Duration;//把歌名歌手和时长都一样的当成是一首音乐
        }
    }

    public class MergedSong
    {
        public List<Song> Items
        {
            get; set;
        }

        public MergedSong(List<Song> items)
        {
            this.Items = items;
        }

        public string Name
        {
            get
            {
                return this.Items[0].Name;
            }
        }
        public string Singer
        {
            get
            {
                return this.Items[0].Singer;
            }
        }
        public string Album
        {
            get
            {
                return this.Items[0].Album;
            }
        }

        public string Source
        {
            get
            {
                return string.Join(",", this.Items.Select(i => i.Source).ToArray());
            }
        }

        public double Duration
        {
            get
            {
                return this.Items[0].Duration;
            }
        }

        public double Size
        {
            get
            {
                return this.Items[0].Size;
            }
        }

        public double Rate
        {
            get
            {
                return this.Items[0].Rate;
            }
        }


        public double Score
        {
            get
            {
                return this.Items.Count / (MusicSources.Instance.Sources.Count - 1) + (20 - this.Items.Average(i => i.Index)) / 20;// 投票+排序各占50%权重
            }
        }

    }
}
