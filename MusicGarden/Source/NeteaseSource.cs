using Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using MusicGarden.Http;
using System.Reflection;

namespace MusicGarden.Source
{
public class NeteaseSource : IMusicSource
{
        static HttpConfig DEFAULT_CONFIG = new HttpConfig
        {
            Referer = "http://music.163.com/",

        };

        public string Name { get; } = "网易";



        public List<Song> SearchSongs(string keyword, int page, int pageSize)
        {

            var searchResult = HttpHelper.GET(string.Format("http://music.163.com/api/cloudsearch/pc?s={0}&type=1&offset={1}&limit={2}", keyword, (page - 1) * pageSize, pageSize), DEFAULT_CONFIG);
            var result = new List<Song>();
            try
            {
                var songList = JObject.Parse(searchResult)["result"]["songs"];//解析JSON数据
                var index = 1;

                foreach (var songItem in songList)
                {

                    if ((int)songItem["privilege"]["fl"] == 0) // 无版权
                    {
                      
                        continue;
                    }

                    var song = new Song
                    {
                        Id = (string)songItem["id"],
                        Name = (string)songItem["name"],
                        Album = (string)songItem["al"]["name"],
                        Index = index++,
                        Source = Name,
                        Duration = (double)songItem["dt"]
                    };

                    song.Singer = "";
                    foreach(var ar in songItem["ar"])
                    {
                        song.Singer += ar["name"] + " ";
                    }

                    song.Rate = ((int)songItem["privilege"]["fl"]) / 1000;
                    var fl = (int)songItem["privilege"]["fl"];
                    if (songItem["h"] != null && fl >= 320000)
                    {
                        song.Size = (double)songItem["h"]["size"];
                    }
                    else if (songItem["m"] != null && fl >= 192000)
                    {
                        song.Size = (double)songItem["m"]["size"];
                    }
                    else if (songItem["l"] != null)
                    {
                        song.Size = (double)songItem["l"]["size"];
                    }//获取比特率
                    result.Add(song);
                }
            }
            catch (Exception ex)
            {
                ex.GetHashCode();
            }
            return result;

        }

        public string getDownloadUrl(Song song)
        {
            var urlInfo = JsonParser.Deserialize(HttpHelper.GET(string.Format(" http://music.163.com/api/song/enhance/player/url?id={0}&ids=%5B{0}%5D&br=3200000", song.Id), DEFAULT_CONFIG));//反序列化JSON
            return urlInfo.data[0]["url"];

        }

    }

}
