using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MusicGarden.Source;

namespace MusicGarden.Http
{

    public class SongDownloader
    {

        public SongDownloader(MusicSources musicSources, string target)
        {
            this.musicSources = musicSources;
            this.target = target;
        }

        readonly MusicSources musicSources;
        readonly string target;
        List<SongItemDownloader> songs = new List<SongItemDownloader>();


        public double TotalPercent
        {

            get
            {
                if (songs.Count == 0)
                {
                    return 100;
                }

                return songs.Sum(s => s.ReceiveProgress) * 100 / songs.Count;
            }
        }

        public double totalSpeed
        {
            get
            {
                return songs.Sum(s => s.receiveSpeed);

            }
        }


        public void AddDownload(MergedSong song)
        {
            SongItemDownloader downloader = new SongItemDownloader(musicSources, target, song);
            downloader.DownloadFinish += Downloader_DownloadFinish;

            songs.Add(downloader);

            downloader.Download();

        }

        private void Downloader_DownloadFinish(object sender, SongItemDownloader e)
        {
            songs.Remove(e);
        }


    }

    public delegate void DownloadFinishEvent(object sender, SongItemDownloader e);

    /// <summary>
    /// 文件下载
    /// </summary>
    public class SongItemDownloader
    {
        private readonly MusicSources musicSources;
        private readonly string target;
        private readonly MergedSong song;

        public event DownloadFinishEvent DownloadFinish;

        public SongItemDownloader(MusicSources musicSources, string target, MergedSong song)
        {
            this.musicSources = musicSources;
            this.target = target;
            this.song = song;
        }

        public long totalBytes;

        public long bytesReceived;

        public double ReceiveProgress;


        public double receiveSpeed;

 //       DateTime lastTime = DateTime.Now;

        public void Download()
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += (s, e) =>
            {
                this.bytesReceived = e.bytesReceived;
                this.totalBytes = e.totalBytes;
                this.receiveSpeed = e.receiveSpeed;
                this.ReceiveProgress = e.ReceiveProgress;
            };
            new Task(() =>
            { 
                foreach (var item in song.Items)// 多来源，避免单个来源出错
                {
                    try
                    {
                        client.DownloadFile(musicSources.getDownloadUrl(item), target + "\\" + item.GetFileName());
                        DownloadFinish?.Invoke(this, this);
                        break;
                    }
                    catch { }
                }

            }).Start();
        }
    }
}
