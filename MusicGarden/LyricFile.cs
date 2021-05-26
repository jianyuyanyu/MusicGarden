using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MusicGarden
{
    /// <summary>
    /// 用于保存歌词文件信息
    /// </summary>
    class LyricFile
    { 
        public List<Lyric> Lyric_List = new List<Lyric>();//歌词列表
       
        public bool LoadLyricFromFile(string filename)//从文件载入歌词
        {
            if (File.Exists(filename))
            {
              
                Encoding encoder = Encoding.GetEncoding("GB2312");
                FileStream fs = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(fs, encoder);  //从文件载入歌词


                String strlyric;//保存歌词
                while ((strlyric = sr.ReadLine()) != null)
                {
                    if (strlyric == "")
                    {
                        continue;//若有空行则跳过该次循环
                    }
                    Lyric lyric = new Lyric();
                    try
                    {
                        lyric.minute = Convert.ToInt32(strlyric.Substring(1, 2));//从第二个开始
                        lyric.second = Convert.ToSingle(strlyric.Substring(4, 5));//从第五个开始
                        lyric.strLyric = strlyric.Substring(10);

                        lyric.totsecond = (float)(lyric.minute * 60 + lyric.second);

                        Lyric_List.Add(lyric);//加入歌词
                    }
                    catch (Exception )
                    {
                        continue;
                    }
                }

                sr.Close();
                fs.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    /// <summary>
    /// 用于保存歌词信息
    /// </summary>
    class Lyric
    {
        public int minute;//分钟
        public float second;//秒
        public String strLyric;//具体歌词
        public float totsecond;//总秒数
    }
}

