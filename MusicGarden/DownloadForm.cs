using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicGarden.Source;
using MusicGarden.Http;
using System.Security.Cryptography;
using System.IO;

namespace MusicGarden
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }
       
        delegate void UpdateListCallback(List<ListViewItem> listViewItems); // 用于将ListView更新的的委托类型
        string downPath = "D:\\MusicDownload\\";
        int page = 1;
        private void DownloadForm_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(Application.StartupPath + "\\Config.ini");
            downPath = ini.ReadString("setting", "downloadPath", "D:\\MusicDownload\\");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            page = 1;
            GetList(page);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                GetList(page);

                if (page == 1)
                    btnLastPage.Enabled = false;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            page++;
            GetList(page);

            if (page > 1)
            {
                btnLastPage.Enabled = true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;
                IniFile ini = new IniFile(Application.StartupPath + "\\Config.ini");
                downPath = ini.ReadString("setting", "downloadPath", "D:\\MusicDownload\\");
                if (!Directory.Exists(downPath))
                {
                    Directory.CreateDirectory(downPath);
                }

                if (downloader == null)
                {
                    downloader = new SongDownloader(Source, downPath);
                }

                foreach (ListViewItem item in listViewResult.CheckedItems)
                {
                    timer.Enabled = true;
                    timer.Interval = 500;
                    var song = (MergedSong)item.Tag;
                    downloader.AddDownload(song);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 开始显示进度栏动画
        /// </summary>
        private void StartProcessBar()
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.MarqueeAnimationSpeed = 10;
        }

        /// <summary>
        /// 结束显示进度栏动画
        /// </summary>
        private void StopProcessBar()
        {
            toolStripProgressBar1.Visible = false;
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        }

        MusicSources Source = MusicSources.Instance;


        /// <summary>
        /// 获取歌曲列表
        /// </summary>
        /// <param name="page"></param>
        private void GetList(int page)
        {
            StartProcessBar();
            lblPage.Text = "第" + page + "页";
            listViewResult.Items.Clear();
            toolStripStatusLabel1.Text = "搜索中...";
            List<ListViewItem> listViewItems = new List<ListViewItem>();


            var songs = Source.SearchSongs(txtSearch.Text, page, 10);

            songs.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Rate + "kb");
                lvi.SubItems.Add(item.Singer);
                lvi.SubItems.Add((item.Size / (1024 * 1024)).ToString("F2") + "MB");  //将文件大小装换成MB的单位
                TimeSpan ts = new TimeSpan(0, 0, (int)item.Duration); //把秒数换算成分钟数
                lvi.SubItems.Add(ts.Minutes + ":" + ts.Seconds.ToString("00"));
                lvi.SubItems.Add(item.Source);
                lvi.Tag = item;
                listViewItems.Add(lvi);

            });


            UpdateUI(listViewItems);

        }

        /// <summary>
        /// 用于在获取歌曲列表的Task中更新界面
        /// </summary>
        /// <param name="listViewItems"></param>
        private void UpdateUI(List<ListViewItem> listViewItems)
        {
             
            if (this.listViewResult.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!this.listViewResult.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (this.listViewResult.Disposing || this.listViewResult.IsDisposed)
                        return;
                }
                UpdateListCallback d = new UpdateListCallback(UpdateUI);
                listViewResult.Invoke(d, new object[] { listViewItems });
            }
            else
            {
                listViewResult.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
                listViewResult.Items.AddRange(listViewItems.ToArray());
                listViewResult.EndUpdate();  //结束数据处理，UI界面一次性绘制
                toolStripStatusLabel1.Text = "搜索完成";
                StopProcessBar();

                if (listViewResult.Items.Count > 0)
                {
                    btnNextPage.Enabled = true;
                }
                else
                {
                    btnNextPage.Enabled = false;
                }
            }
        }

        
      
       
        public string GetMD5(string str)
        { 
            MD5 md5 = MD5.Create();
            byte[] bf = Encoding.Default.GetBytes(str);
            byte[] mbf = md5.ComputeHash(bf);
            string s = "";
            for (int i = 0; i < mbf.Length; i++)
            {
                s += mbf[i].ToString("x2");
            }
            return s;
        }



        private string getSongUrl(Song song)
        {
            return Source.getDownloadUrl(song);
        }

        SongDownloader downloader;

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "下载进度：" + (int)(downloader.TotalPercent) + "%" + string.Format("，速度{0}", (downloader.totalSpeed / 1024.0 / 1024.0).ToString("F2") + "MB/s");
            toolStripProgressBar1.Value = (int)(downloader.TotalPercent);
            if (downloader.TotalPercent >= 100d)
            {
                toolStripStatusLabel1.Text = "下载完成";
                timer.Enabled = false;
                toolStripProgressBar1.Visible = false;
            }
        }

        private void btnOpenDownPath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", downPath);
        }
    }
}
