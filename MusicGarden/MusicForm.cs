using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using WMPLib;
using Microsoft.VisualBasic.FileIO;
using System.Threading;
using System.Collections;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Drawing.Drawing2D;

namespace MusicGarden
{

    public partial class MusicForm : Form
    {
        SetForm set = new SetForm();//实例化设置窗体
        public string iniPath = Application.StartupPath + "\\Config.ini";
        int pix = 5;
        private ToolTip ttp = new ToolTip();
        //LyricFile lyricFiles = new LyricFile();
        ////歌词集合
        //List<string> lyrics = new List<string>();

        [DllImport("user32.dll")]
        protected static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);
        public const Int32 AW_BLEND = 0x00080000;//使用淡入淡出效果 
        public const Int32 AW_CENTER = 0x00000010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展 
        public const Int32 AW_ACTIVATE = 0x00020000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志 
        public const Int32 AW_HIDE = 0x00010000;//隐藏窗口 
        public const Int32 AW_SLIDE = 0x00040000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略 
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志 
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志 
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志 
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;
        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport("GaussBlur.dll")]
        public static extern void SetSigma(double sigma);
        [DllImport("GaussBlur.dll")]
        public static extern void Reset();
        [DllImport("GaussBlur.dll")]
        public static extern void DoGaussBlur(Bitmap image_src, Bitmap image_dest);	
        public MusicForm()
        {
            InitializeComponent();
            set.SetDoneEvent += new SetForm.MyDelegate( Set_SetDoneEvent);
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //Win32API函数实现窗体边框阴影效果
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Set_SetDoneEvent()
        {
            ReadSkin();
            ReadDownPath();
            AutoStart();
        }

        #region 窗体边框阴影效果变量声明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]//声明Win32 API
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        #endregion


        #region  减轻闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;////用双缓冲从下到上绘制窗口的所有集合
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x0014) // 禁用清除背景消息  

                return;

            base.WndProc(ref m);

        }
        #endregion


        #region 窗体拖动代码
        public const int WM_NCLBUTTONDOWN = 0x0112;
        public const int HTCAPTION = 0x0002;
        public const int SC_MOVE = 0xF010;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MusicForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, SC_MOVE + HTCAPTION, 0);

        }


        #endregion


        #region 主窗体事件与初始化方法
        private void MusicForm_Load(object sender, EventArgs e)
        {

            AnimateWindow(this.Handle, 1000, AW_BLEND | AW_CENTER | AW_ACTIVATE);
            for (Double opa = 0; Math.Abs(opa - 1) > 1E-06; opa += 0.05)
            {
                this.Opacity = opa;
                Thread.Sleep(2);//挂起2毫秒
                this.Refresh();

            } //主窗体淡入
            this.Opacity = 0.99;// 透明度99%
            this.Refresh();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);//解决闪烁
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//解决闪烁
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
            this.UpdateStyles();
            lstSongList.ValueMember = "filePath";
            lstSongList.DisplayMember = "fileName";
            ReadMusicList();
            Rest();
            lblSongCount.Text = "共" + lstSongList.Items.Count + "首音乐";
            AutoStart();
            ReadSkin();
            ReadDownPath();
            TaskbarManager.Instance.TabbedThumbnail.SetThumbnailClip(this.Handle, new Rectangle(pictureboxAlbumImage.Location, pictureboxAlbumImage.Size));
            this.MouseWheel += new MouseEventHandler(this.vol_MouseWheel);
            
        }

        /// <summary>
        /// 鼠标滚轮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vol_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((0<e.Delta)&&(e.Delta < 100))
            tkbVol.Value += e.Delta;   
        }
        private void MusicForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            SaveMusicList();
            Application.Exit();
            this.Dispose();
        }
        public void ReadDownPath()
        {
            var ini = new IniFile(iniPath);
            var path = ini.ReadString("setting", "downloadPath", "D:\\MusicDownload\\");
            if ((!string.IsNullOrEmpty(path)) && Directory.Exists(path))
            {

            }
            else
            {
                ini.WriteString("setting", "downloadPath", "D:\\MusicDownload\\");
            }
        }
        /// <summary>
        /// 加载背景
        /// </summary>
        public void ReadSkin()
        {
            string skinPath = Application.StartupPath;
            var ini = new IniFile(iniPath);
            var path = ini.ReadString("setting", "skinPath", skinPath);
            pix = ini.ReadInteger("setting", "blurPix", 5);
            if (( ! string.IsNullOrEmpty(path)) && File.Exists(path))
            {
                Image skin = Image.FromFile(path as string);
                if (ini.ReadBoolean("setting", "gaussianBlur", true))
                {
                    //var image = Image.FromFile(ini.ReadString("setting", "skinPath", skinPath));
                    var blur = new GaussianBlur(skin as Bitmap);
                    Image result = blur.Process(pix);

                    this.BackgroundImage = result;

                }
                else
                {
                    this.BackgroundImage = skin;
                }
            }
            else
            {
                this.BackgroundImage = null;//没有背景则设置为空
            }

        }
        /// <summary>
        /// 复位
        /// </summary>
        private void Rest()
        {
            tkbMove.Value = 0;
            var ini = new IniFile(iniPath);
            int vol = ini.ReadInteger("setting", "volume", tkbVol.Value);
            tkbVol.Value = tkbVol.Maximum / 3;
            tkbVol.Value = vol;

            lblVol.Text = vol.ToString()+"%";
            pictureboxAlbumImage.Image = Image.FromFile("Image\\head.jpg");
            lblSongName.Text = "当前无播放歌曲";
            lblAll.Text = "00:00";
            lblRun.Text = "00:00";
          
            try
            {
                if (lstSongList.Items.Count > 0 && lstSongList.SelectedIndex == -1)
                {
                    lstSongList.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// 下载目录初始化
        /// </summary>
        public void AutoStart()
        {
            IniFile ini = new IniFile(iniPath);
            AutoRun(ini.ReadBoolean("setting", "autoRun", true));
        }

        private void MusicForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            AnimateWindow(this.Handle, 1000, AW_BLEND | AW_HIDE);


        }

        #endregion


        #region 工具栏单击事件
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            set.ShowDialog();
        }

        private void tsmiDown_Click(object sender, EventArgs e)
        {
            var down = new DownloadForm();
            down.Show();
        }
        private void tsmiOpenFolder_Click(object sender, EventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dir = new DirectoryInfo(ofd.SelectedPath);
                    string[] type = ("*.mp3;*.wav;*.wma;*.aac;").Split(';');
                    lstSongList.BeginUpdate();
                    for (int i = 0; i < type.Length; i++)
                    {
                        FileInfo[] files = dir.GetFiles(type[i]);

                        foreach (FileInfo s in files)
                        {
                            string path = s.FullName;
                            AddSongsToList(path);
                        }
                    }
                    lstSongList.EndUpdate();
                }
                catch
                {

                }
                SearchListMusic();
                SaveMusicList();
                lblSongCount.Text = "共" + lstSongList.Items.Count + "首音乐";
            }
        }

        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = true;//多选

            of.Filter = "(*.mp3;*.wma;*.wav*.aac;) |*.mp3;*.wav;*.wma;*.aac;";
            if (of.ShowDialog() == DialogResult.OK)
            {
                lstSongList.BeginUpdate();
                for (int i = 0; i < of.FileNames.Length; i++)
                {
                    string path = of.FileNames[i];
                    AddSongsToList(path);
                }
                lstSongList.EndUpdate();
            }

            SearchListMusic();
            SaveMusicList();
            lblSongCount.Text = "共" + lstSongList.Items.Count + "首音乐";
        }

        private void AddSongsToList(string path)
        {
            if (!IsExistInList(path))
            {
                var songsInfo = new Songs(path);
                lstSongList.Items.Add(songsInfo);
                WMPLib.IWMPMedia media = MusicPlayer.newMedia(path);
                MusicPlayer.currentPlaylist.appendItem(media);
            }
        }

        private bool IsExistInList(string path)
        {
            for (int i = 0; i < lstSongList.Items.Count; i++)
            {
                if (path == ((Songs)lstSongList.Items[i]).FilePath)
                    return true;
            }
            return false;
        }
     

        #endregion


        #region 播放器控制
        Songs playingMusic = new Songs(null);
        private void MusicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {

                case 1:
                    Taskbar.TaskbarManager.SetProgressState(Taskbar.TaskbarProgressBarState.Paused);//任务栏进度样式为Pause
                    Taskbar.TaskbarManager.SetProgressValue(tkbMove.Value, tkbMove.Maximum);
                    timer1.Stop();
                    Rest();
                    break;

                case 2:
                    Taskbar.TaskbarManager.SetProgressState(Taskbar.TaskbarProgressBarState.Paused);
                    Taskbar.TaskbarManager.SetProgressValue(tkbMove.Value, tkbMove.Maximum);
                    timer1.Stop();
                    break;
                case 3:   
                    timer1.Start();
                    lblSongName.Text = playingMusic.FileName;
                    this.Text = playingMusic.FileName;//任务栏文字
                    lblTitle.Text = playingMusic.FileName + " - MusicGarden";//标题栏文字
                    pictureboxAlbumImage.Image = playingMusic.AlbumImage;
                   TaskbarManager.Instance.TabbedThumbnail.SetThumbnailClip(this.Handle, new Rectangle(pictureboxAlbumImage.Location, pictureboxAlbumImage.Size));
                    tkbMove.Maximum = (int)MusicPlayer.currentMedia.duration;
                    Taskbar.TaskbarManager.SetProgressState(Taskbar.TaskbarProgressBarState.Normal);
                    Taskbar.TaskbarManager.SetProgressValue(tkbMove.Value, tkbMove.Maximum);
                    break;
               
            }
            if (MusicPlayer.playState.ToString() == "wmppsMediaEnded")
            {              
                WMPLib.IWMPMedia music = MusicPlayer.newMedia(GetPath());
                ShowLrc();
                MusicPlayer.currentPlaylist.appendItem(music);
                
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
          
            if (MusicPlayer.playState.ToString() == "wmppsPlaying")      
            {
                MusicPlayer.Ctlcontrols.pause();
                btnPlay.BackgroundImage = Image.FromFile("Image\\play_hover.png");
                ShowLrc();
                return;
            }
            else if (MusicPlayer.playState.ToString() == "wmppsPaused")  
            {
                MusicPlayer.Ctlcontrols.play();
                btnPlay.BackgroundImage = Image.FromFile("Image\\pause_hover.png");
                ShowLrc();
                return;
            }

            if (lstSongList.SelectedIndex >= 0)         //双击播放列表控制
            {
                Play(lstSongList.SelectedIndex);
                ShowLrc();
            }
            else
                MessageBox.Show("当前无可播放的音乐");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lstSongList.SelectedIndex == -1)
                MessageBox.Show("当前无可播放的音乐");
            else if (lstSongList.SelectedIndex > 0)
            {
                MusicPlayer.Ctlcontrols.stop();
                lstSongList.SelectedIndex -= 1;
                Play(lstSongList.SelectedIndex);
                ShowLrc();
            }
            else
            {
                MusicPlayer.Ctlcontrols.stop();
                lstSongList.SelectedIndex = lstSongList.Items.Count - 1;
                Play(lstSongList.SelectedIndex);
                ShowLrc();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstSongList.SelectedIndex == -1)
                MessageBox.Show("当前无可播放的音乐");
            else if (lstSongList.SelectedIndex < lstSongList.Items.Count - 1)
            {
                MusicPlayer.Ctlcontrols.stop();
                lstSongList.SelectedIndex += 1;
                Play(lstSongList.SelectedIndex);
                ShowLrc();
            }
            else
            {
                MusicPlayer.Ctlcontrols.stop();
                lstSongList.SelectedIndex = 0;
                Play(lstSongList.SelectedIndex);
                ShowLrc();
            }
        }
        public enum PlayerMode { Order = 0, One = 1, Random = 2 };//播放模式为枚举类型
        public PlayerMode currPlayMode = PlayerMode.Order;
        private void btnPlayMode_Click(object sender, EventArgs e)
        {
            if (currPlayMode == PlayerMode.Order)
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\列表循环.png");
            }
            else if (currPlayMode == PlayerMode.One)
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\单曲循环.png");
            }
            else
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\随机播放.png");//背景图像切换
            }

            if (currPlayMode == PlayerMode.Random)
            {
                currPlayMode = PlayerMode.Order;
            }
            else
            {
                currPlayMode += 1;
            }


        }
        private void Play(int index)
        {
          
            lstSongList.SelectedIndex = index;
            if (MusicPlayer.playState.ToString() == "wmppsPlaying")       
            {
                MusicPlayer.Ctlcontrols.pause();
                btnPlay.BackgroundImage = Image.FromFile("Image\\play_hover.png"); ;
                return;
            }
            else if (MusicPlayer.playState.ToString() != "wmppsPaused")      //更改播放路径并播放
            {
                CreateRandomNum(lstSongList.Items.Count);
                skipMusicIndex = index;
                playingMusic = (Songs)lstSongList.Items[index];
                MusicPlayer.URL = playingMusic.FilePath;
                MusicPlayer.Ctlcontrols.play();
                TaskbarManager.Instance.TabbedThumbnail.SetThumbnailClip(this.Handle, new Rectangle(pictureboxAlbumImage.Location, pictureboxAlbumImage.Size));
                ShowLrc();
                return;
            }
            else                            
            {
                MusicPlayer.Ctlcontrols.play();
                ShowLrc();
                btnPlay.BackgroundImage = Image.FromFile("Image\\pause_hover.png");
            }
        }
        #endregion


        #region 当前音乐列表搜索方法
        private List<Songs> tempList;//索引搜索功能
        private void SearchListMusic()
        {
            tempList = new List<Songs>();
            for (int i = 0; i < lstSongList.Items.Count; i++)
            {
                tempList.Add((Songs)lstSongList.Items[i]);
            }
        }

        private void txtSreachSongName_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtSreachSongName.Text);
            lbNotFoundSong.Visible = false;
            if (txtSreachSongName.Text == string.Empty)
            {
                ReadMusicList();
                return;
            }
            else
            {
                List<Songs> sreachList = new List<Songs>();

                string strSreach = txtSreachSongName.Text;
                Regex r = new Regex(Regex.Escape(strSreach), RegexOptions.IgnoreCase);

                if (tempList.Count > 0)
                {
                    lstSongList.BeginUpdate();
                    for (int i = 0; i < tempList.Count; i++)
                    {
                        Match m = r.Match(((Songs)tempList[i]).FileName);
                        if (m.Success)
                        {
                            sreachList.Add(tempList[i]);
                        }
                    }
                    lstSongList.EndUpdate();
                }

                if (sreachList.Count > 0)
                {
                    lstSongList.Items.Clear();

                    lstSongList.BeginUpdate();
                    for (int i = 0; i < sreachList.Count; i++)
                    {
                        lstSongList.Items.Add(sreachList[i]);
                    }
                    lstSongList.EndUpdate();
                }
                else
                {
                    lstSongList.Items.Clear();
                    lbNotFoundSong.Visible = true;
                }
            }
        }
        #endregion


        #region 定时器
        private void timerPlay_Tick(object sender, EventArgs e)
        {
            string currPlayTime = MusicPlayer.Ctlcontrols.currentPositionString;
            lblRun.Text = currPlayTime;
            lblAll.Text = playingMusic.Duration.Remove(0, 3);
            tkbMove.Value = (int)MusicPlayer.Ctlcontrols.currentPosition;//设置滑动条值


            if (MusicPlayer.playState == WMPPlayState.wmppsStopped)
            {


                timer1.Enabled = true;
            }

            if (this.richTextBoxLrc.Text != "歌词文件不存在" && this.richTextBoxLrc.Text != "歌词文件内容为空")
            {
                int pos = al.IndexOf(this.tkbMove.Value.ToString());
                bool isAr = this.richTextBoxLrc.Text.Contains("歌手:");
                bool isTi = this.richTextBoxLrc.Text.Contains("歌名:");

                try
                {


                    if (pos >= 0)
                    {
                        int n = isAr ? 1 : 0;
                        int m = isTi ? 1 : 0;

                        int height = 28 * (this.al.Count + m + n);
                        int max = height - this.richTextBoxLrc.Height;


                        this.richTextBoxLrc.SelectAll();
                        this.richTextBoxLrc.SelectionColor = Color.Black;
                        this.richTextBoxLrc.SelectionLength = 0;

                        int l = this.richTextBoxLrc.Lines[pos + m + n].Length;
                        this.richTextBoxLrc.Select(this.richTextBoxLrc.GetFirstCharIndexFromLine(pos + m + n), l);


                        this.richTextBoxLrc.SelectionColor = Color.OrangeRed;
                        this.richTextBoxLrc.SelectionLength = 0;


                        if ((pos + m + n) * 28 <= max)
                        {
                            int start = this.richTextBoxLrc.GetFirstCharIndexFromLine(pos + m + n);
                            this.richTextBoxLrc.SelectionStart = start;
                            this.richTextBoxLrc.ScrollToCaret();

                        }
                        else
                        {

                            SendMessage(this.richTextBoxLrc.Handle, WM_VSCROLL, SB_BOTTOM, 0);
                            UpdateWindow(this.richTextBoxLrc.Handle);

                        }
                    }


                }
                catch
                { }

            }
        }




        #endregion


        #region 播放模式
        private int randomListIndex = 0; //list的索引
        private int[] randomList; //随机播放list
        private int skipMusicIndex; //随机过程中跳过的索引
        private string GetPath()
        {
            int currIndex = lstSongList.SelectedIndex;
            if (currPlayMode == PlayerMode.Order)       //列表循环
            {
                if (currIndex != lstSongList.Items.Count - 1)
                {
                    currIndex += 1;
                 
                }
                else
                {
                    currIndex = 0;
                   
                }   

            }
            else if (currPlayMode == PlayerMode.One)  //单曲循环
            {

            }
            else //随机播放                   
            {
                if (randomListIndex > randomList.Length - 1)
                {
                    NewRecycle();        
                }


                if (randomList[randomListIndex] == skipMusicIndex)   
                {
                    if (randomListIndex == randomList.Length - 1)
                    {
                        NewRecycle();
                    }
                    else
                        randomListIndex++;
                }
                currIndex = randomList[randomListIndex++];
            }
            lstSongList.SelectedIndex = currIndex;
            playingMusic = (Songs)lstSongList.Items[currIndex];
            return ((Songs)lstSongList.Items[currIndex]).FilePath; 
        }

        private void NewRecycle()
        {

            CreateRandomNum(lstSongList.Items.Count); //重新生成随机

            skipMusicIndex = -1;//第二轮开始 播放所有歌曲 不跳过
        }

        private void CreateRandomNum(int count)
        {

            randomList = new int[count];
            randomListIndex = 0;
            for (int i = 0; i < count; i++) //初始化序列
            {
                randomList[i] = i;
            }
            for (int j = count - 1; j >= 0; j--)//随机序列
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int k = random.Next(0, count - 1);
                Excange(randomList, j, k);
            }
        }

        private void Excange(int[] list, int i, int j)
        {
            int k = list[i];
            list[i] = list[j];
            list[j] = k;
        }
        #endregion


        #region 进度条音量事件
        private void btnVol_Click(object sender, EventArgs e)
        {

            if (MusicPlayer.settings.mute == false)//前景文字显示X
            {
                btnVol.Text = "×";

                MusicPlayer.settings.mute = true;
            }
            else
            {
                btnVol.Text = string.Empty;

                MusicPlayer.settings.mute = false;
            }
        }
        private void tkbVol_ValueChanged(object sender, EventArgs e)
        {
            MusicPlayer.settings.volume = tkbVol.Value;
            lblVol.Text = tkbVol.Value.ToString() + "%";
            var ini = new IniFile(iniPath);
            ini.WriteInteger("setting", "volume", tkbVol.Value);
            if (tkbVol.Value.ToString() == "0")
            {
                btnVol.Text = "×";

            }
            else
                btnVol.Text = string.Empty;
        }

        private void tkbMove_Scroll(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.currentPosition = (double)this.tkbMove.Value;
        }
        #endregion


        #region 歌词相关
        public void ShowLrc()
        {
            string filename = playingMusic.FilePath;
            string lrc_filename = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename) + ".lrc";
            if (File.Exists(lrc_filename))
            {
                LoadLrc(lrc_filename);
            }
            else
            {
                this.richTextBoxLrc.Text = "没有找到歌词";
            }
        }
        ArrayList al = new ArrayList(); //当前歌词时间表    
        /// <summary>
        /// 载入歌词
        /// </summary>
        /// <param name="lrc_filename">歌词路径名</param>
        public void LoadLrc(string lrc_filename)
        {
            using (StreamReader sr = new StreamReader(new FileStream(lrc_filename, FileMode.Open), Encoding.Default))
            {
                string tempLrc = string.Empty;
                while (!sr.EndOfStream)
                {
                    tempLrc = sr.ReadToEnd();
                }

                if (tempLrc.Trim() == string.Empty)
                {
                    this.richTextBoxLrc.Text = "歌词文件内容为空";
                    return;
                }

                tempLrc = tempLrc.Trim();
                this.richTextBoxLrc.Text = sr.ReadToEnd();
                Regex rg = new Regex("\r*\n*\\[ver:(.*)\\]\r*\n*");
                tempLrc = rg.Replace(tempLrc, "");//在指定的输入字符串中，把所有匹配正则表达式模式的所有匹配的字符串替换为指定的替换字符串
                rg = new Regex("\r*\n*\\[al:(.*)\\]\r*\n*");
                tempLrc = rg.Replace(tempLrc, "");
                rg = new Regex("\r*\n*\\[by:(.*)\\]\r*\n*");
                tempLrc = rg.Replace(tempLrc, "");
                rg = new Regex("\r*\n*\\[offset:(.*)\\]\r*\n*");
                tempLrc = rg.Replace(tempLrc, "");
                rg = new Regex("\r*\n*\\[ar:(.*)\\]\r*\n*");
                Match mtch;
                mtch = rg.Match(tempLrc);
                tempLrc = rg.Replace(tempLrc, "\n歌手:" + mtch.Groups[1].Value + "\n");
                rg = new Regex("\r*\n*\\[ti:(.+?)\\]\r*\n*");   //这里注意贪婪匹配问题.+?
                mtch = rg.Match(tempLrc);

                tempLrc = rg.Replace(tempLrc, "\n歌名:" + mtch.Groups[1].Value + "\n");
                rg = new Regex("\r*\n*\\[[0-9][0-9]:[0-9][0-9].[0-9][0-9]\\]");
      
                MatchCollection mc = rg.Matches(tempLrc);
                al.Clear();
                foreach (Match m in mc)
                {
                    string temp = m.Groups[0].Value;
                    string mi = temp.Substring(temp.IndexOf('[') + 1, 2);
                    string se = temp.Substring(temp.IndexOf(':') + 1, 2);
                    _ = temp.Substring(temp.IndexOf('.') + 1, 2);   //这是毫秒
                    string time = Convert.ToInt32(mi) * 60 + Convert.ToInt32(se) + "";  //这里并没有添加毫秒
                    al.Add(time);
                }
                tempLrc = rg.Replace(tempLrc, "\n");
                char[] remove = { '\r', '\n', ' ' };
                this.richTextBoxLrc.Text = tempLrc.TrimStart(remove);
            }
        }
        #endregion

        #region 开机自启方法

        /// <summary>  
        /// 修改注册表中的键值自启  
        /// </summary>  
        /// <param name="isAuto">true:开机启动,false:不开机自启</param> 
        public static void AutoRun(bool isAuto)
        {
            string path = Application.StartupPath;
            string keyName = path.Substring(path.LastIndexOf("//") + 1);
            try
            {
                if (isAuto == true)
                {
                    //RegistryKey R_local = Registry.LocalMachine;
                    RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue(keyName, path + @"\MusicGarden.exe");
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    //RegistryKey R_local = Registry.LocalMachine;
                    RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue(keyName, false);
                    R_run.Close();
                    R_local.Close();
                }

                //GlobalVariant.Instance.UserConfig.AutoStart = isAuto;
            }
            catch (Exception)
            {
                MessageBox.Show("您需要管理员权限修改", "提示");
            }
        }
    
        public static void AutoStart(bool isAuto)
        {
            if (isAuto == true)
            {
                string StartupPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup);//获得文件的当前路径  

                string dir = Directory.GetCurrentDirectory(); //获取可执行文件的全部路径  

                string exeDir = dir + @"\MusicGarden.exe.lnk";
                System.IO.File.Copy(exeDir, StartupPath + @"\MusicGarden.exe.lnk", true);
            }
            else
            {
                string StartupPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonStartup);
                System.IO.File.Delete(StartupPath + @"\MusicGarden.exe.lnk");
            }

        }
        #endregion


        #region 系统托盘事件
        private void MusicForm_SizeChanged(object sender, EventArgs e)
        {
            this.Visible = true;
            NotifyIcon.Visible = true;
        }
        private void NotifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            NotifyIcon.Text = playingMusic.FileName;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Opacity = 0.99d;
            NotifyIcon.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void tsmiShowForm_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Opacity = 0.99d;
            NotifyIcon.Visible = true;
            this.WindowState = FormWindowState.Normal;

        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            for (Double opa = 1.00; Math.Abs(opa - 0.00) > 1E-06; opa -= 0.05)
            {
                this.Opacity = opa;
                System.Threading.Thread.Sleep(2);//2毫秒
                this.Refresh();
            }
            this.Close();
            Application.Exit();
            this.Dispose();
            NotifyIcon.Dispose();
            
        }
        #endregion


        #region 右键菜单
        private void tsmiDelSong_Click(object sender, EventArgs e)
        {
            if (playingMusic == lstSongList.SelectedItem)//选中歌曲为正在播放的歌曲
            {
                this.MusicPlayer.Ctlcontrols.stop();

            }
            
            this.lstSongList.Items.Remove(lstSongList.SelectedItem);
            SaveMusicList();
            lblSongCount.Text = "共" + lstSongList.Items.Count + "首音乐";
        }
        Songs selectedMusic = new Songs(null);//音乐详情
        private void DeleteLocalFile()
        {
            try
            {
                if (File.Exists(selectedMusic.FilePath))
                {
                    FileSystem.DeleteFile(selectedMusic.FilePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                else
                {
                    MessageBox.Show("无法删除");
                }
            }
            catch (Exception)
            {

            }
        }
        private void tsmiClearList_Click(object sender, EventArgs e)
        {

            MusicPlayer.Ctlcontrols.stop();
            this.lstSongList.Items.Clear();
            this.lstSongList.Items.Remove(lstSongList.Items);
            SaveMusicList();
            lblSongCount.Text = "共" + lstSongList.Items.Count + "首音乐";
        }
        private void tsmiDel_Click(object sender, EventArgs e)
        {
            if (playingMusic == lstSongList.SelectedItem)//选中歌曲为正在播放的歌曲
            {
                this.MusicPlayer.Ctlcontrols.stop();

            }
            this.lstSongList.Items.Remove(lstSongList.SelectedItem);
            DeleteLocalFile();
            SaveMusicList();
            lblSongCount.Text = "共" + lstSongList.Items.Count + "首音乐";
        }
        private void lstSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstSongList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                if (playingMusic.FilePath == ((Songs)lstSongList.Items[index]).FilePath)
                {
                    
                    if (MusicPlayer.playState.ToString() == "wmppsPlaying")//选中歌曲为正在播放的歌曲
                    {
                        MusicPlayer.Ctlcontrols.pause();
                        btnPlay.BackgroundImage = Image.FromFile("Image\\play_hover.png");

                    }
                    else if (MusicPlayer.playState.ToString() == "wmppsPaused")
                    {
                        MusicPlayer.Ctlcontrols.play();
                        btnPlay.BackgroundImage = Image.FromFile("Image\\pause_hover.png");
                        ShowLrc();
                    }
                }
                else
                {
                   
                    CreateRandomNum(lstSongList.Items.Count); 
                    skipMusicIndex = index;
                    playingMusic = (Songs)lstSongList.Items[index];
                    MusicPlayer.URL = playingMusic.FilePath;
                    MusicPlayer.Ctlcontrols.play();
                    btnPlay.BackgroundImage = Image.FromFile("Image\\pause_hover.png");//很久没发现的bug
                    ShowLrc();
                }
                lstSongList.SelectedIndex = index;
            }
        }

        private void lstSongList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lstSongList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    selectedMusic = (Songs)(lstSongList.Items[index]);
                    cmsSongList.Show(Cursor.Position);
                }
                else
                    cmsSongList.Close();
            }
        }

        private void tsmiSongInfoDetail_Click(object sender, EventArgs e)
        {
            var sif = new SongInfoForm(selectedMusic);
            sif.ShowDialog();
        }

        private void tsmiOpenFilePath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", "/select," + selectedMusic.FilePath);
        }
        #endregion

        #region 气泡提示事件
        private int newIndex = -1;      //音乐列表气泡提示
        private void lstSongList_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstSongList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && newIndex != index)
            {
                newIndex = index;
              
                ttp.InitialDelay = 100;
                ttp.AutoPopDelay = 4000;
                ttp.ShowAlways = false;
                ttp.ReshowDelay = 50;
                ttp.UseFading = true;
                try
                {
                    ttp.SetToolTip(lstSongList, ((Songs)lstSongList.Items[index]).FileName);
                }
                catch { }
            }
        }
        private ToolTip ttp1 = new ToolTip(); //进度条气泡提示
        private Point point = new Point(0, -1);//定义一个坐标
        private void tkbMove_MouseMove(object sender, MouseEventArgs e)
        {
            var location = tkbMove.PointToClient(e.Location);
            if (location != point)//防止气泡闪烁
            {
                point = location;
                ttp1.InitialDelay = 1000;
                ttp1.AutoPopDelay = 5000;
                ttp1.ShowAlways = false;
                ttp1.ReshowDelay = 100;
                ttp1.UseFading = false;
                var x = (double)e.X;//记录鼠标相当与控件左上角的X坐标
                double percent = x / tkbMove.Width;
                //ttp.SetToolTip(tkbMove, percent.ToString("p"));
                try
                {
                    int second = (int)(percent * MusicPlayer.currentMedia.duration);
                    TimeSpan ts = new TimeSpan(0, 0, second);
                    string text = "定位到" + ts.Minutes.ToString() + "分" + ts.Seconds.ToString() + "秒";
                    ttp1.SetToolTip(tkbMove, text);
                }
                catch
                {

                }
            }
        }

        #endregion


        #region 保存音乐列表
        private void SaveMusicList()
        {
            string saveString = string.Empty;
            for (int i = 0; i < lstSongList.Items.Count; i++)
            {
                saveString += ((Songs)lstSongList.Items[i]).FilePath + "//";
            }

            File.WriteAllText(Application.StartupPath + "\\music.lst", saveString);

        }

        private void ReadMusicList()
        {
            string historyFilePath = Application.StartupPath + "\\music.lst";
            if (File.Exists(historyFilePath))
            {
                string readString = File.ReadAllText(historyFilePath);
                if (readString != string.Empty)
                {
                    string[] ar = readString.Split(new string[] { "//" }, StringSplitOptions.None);
                    lstSongList.BeginUpdate();
                    foreach (string path in ar)
                    {

                        if (path != null && path != string.Empty)//目录文件不存在
                        {
                            if (File.Exists(path))
                            {
                                AddSongsToList(path);
                            }

                        }
                    }
                    lstSongList.EndUpdate();
                }
            }
            else
                File.Create(historyFilePath);

            SearchListMusic();
        }
        #endregion


        #region 鼠标移入移出
        private void btnPlayMode_MouseEnter(object sender, EventArgs e)
        {
            ttp.InitialDelay = 100;
            ttp.AutoPopDelay = 2000;
            ttp.ShowAlways = false;
            ttp.ReshowDelay = 50;
            ttp.UseFading = true;
            if (currPlayMode == PlayerMode.Order)
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\列表循环1.png");
                ttp.SetToolTip(btnPlayMode, "顺序播放");
            }
            else if (currPlayMode == PlayerMode.One)
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\单曲循环1.png");
                ttp.SetToolTip(btnPlayMode, "单曲循环");
            }
            else
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\随机播放1.png");
                ttp.SetToolTip(btnPlayMode, " 随机播放");
            }

        }

        private void btnPlayMode_MouseLeave(object sender, EventArgs e)
        {
            if (currPlayMode == PlayerMode.Order)
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\列表循环.png");
            }
            else if (currPlayMode == PlayerMode.One)
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\单曲循环.png");
            }
            else
            {
                btnPlayMode.BackgroundImage = Image.FromFile("Image\\随机播放.png");
            }
        }
        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            if (MusicPlayer.playState.ToString() == "wmppsPlaying")
            {
                btnPlay.BackgroundImage = Image.FromFile("Image\\pause.png");
                ttp.SetToolTip(btnPlay, "暂停");
            }
            else {
                btnPlay.BackgroundImage = Image.FromFile("Image\\play.png");
                ttp.SetToolTip(btnPlay, "播放");
            }
        
        }
        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            if (MusicPlayer.playState.ToString() == "wmppsPlaying")
            {
                btnPlay.BackgroundImage = Image.FromFile("Image\\pause_hover.png");
            }
            else btnPlay.BackgroundImage = Image.FromFile("Image\\play_hover.png");
        }
        private void btnVol_MouseEnter(object sender, EventArgs e)
        {
            btnVol.BackgroundImage = Image.FromFile("Image\\音量normal.png");
        }

        private void btnVol_MouseLeave(object sender, EventArgs e)
        {
            btnVol.BackgroundImage = Image.FromFile("Image\\音量hover.png");
        }
        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = Image.FromFile("Image\\next_hover.png");
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = Image.FromFile("Image\\next_normal.png");
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Image.FromFile("Image\\pre_hover.png");
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Image.FromFile("Image\\pre_normal.png");
        }
        #endregion

        #region 窗体按钮事件

        private void pictureExit_MouseEnter(object sender, EventArgs e)
        {
            this.pictureExit.Image = Image.FromFile("Image\\close_hover.png");
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            this.pictureExit.Image = Image.FromFile("Image\\close_normal.png");
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
             for (Double opa = 1.00; Math.Abs(opa - 0.00) > 1E-06; opa -= 0.1)
             {
                 this.Opacity = opa;
                 Thread.Sleep(1);
                 this.Refresh();
             }//主窗体淡出
              //最小化窗口双击托盘图标透明度错误

            IniFile ini = new IniFile(iniPath);
            if (ini.ReadBoolean("setting", "exit", true))
            {
                this.Dispose();
                Application.Exit();
                NotifyIcon.Dispose();
                this.Close();

            }//直接退出程序
            else
            {
                NotifyIcon.Visible = true;
                this.Visible = false;
                NotifyIcon.ShowBalloonTip(1000,"温馨提示", "MusicGarden将在后台运行",ToolTipIcon.Info);
            }
            //最小化程序
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.pictureMax.Image = Image.FromFile("Image\\normal_normal.png");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.pictureMax.Image = Image.FromFile("Image\\maximize_hover.png");
            }
        }




        #endregion

        #region 任务栏进度
        /// <summary>
        /// 调用Taskbar类库显示歌曲在任务栏的进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tkbMove_ValueChanged(object sender, EventArgs e)
        {
            Taskbar.TaskbarManager.SetProgressState(Taskbar.TaskbarProgressBarState.Normal);
            Taskbar. TaskbarManager.SetProgressValue(tkbMove.Value, tkbMove.Maximum);
        }



        #endregion

        #region listBox重绘
        private void lstSongList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);
            int index = e.Index;                                
            Graphics g = e.Graphics;   
            Graphics g_image = Graphics.FromImage(bitmap);
            g_image.SmoothingMode = SmoothingMode.AntiAlias;
            g_image.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g_image.CompositingQuality = CompositingQuality.HighQuality;
            Rectangle bound = e.Bounds;
            string text = ((Songs)lstSongList.Items[index]).FileName;
            Color backgroundColor = Color.FromArgb(191, 223, 255);
            Color guideTagColor = Color.FromArgb(240, 125, 5);
            Color selectedBackgroundColor = Color.FromArgb(33,150,255);
            Color fontColor = Color.Black; 
            Color selectedFontColor = Color.White;
            Color backgroundColorWhite = Color.FromArgb(235,245,255);
            Font textFont = new Font("宋体", 9, FontStyle.Regular);     
            Rectangle backgroundRect = new Rectangle(0, 0, bound.Width, bound.Height);
            Rectangle guideRect = new Rectangle(0, 0, 5, bound.Height);
            Rectangle textRect = new Rectangle(10, 0, bound.Width, bound.Height);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) //选中行
            {   
                backgroundColor = selectedBackgroundColor;
                fontColor = Color.White;
            }
            else
            {
                guideTagColor = backgroundColor;
            }

            if ((index%2==0)&&((e.State & DrawItemState.Selected) != DrawItemState.Selected))//偶数行设置为白色
            {
                g_image.FillRectangle(new SolidBrush(backgroundColorWhite), backgroundRect);
            }
            else
            {
                g_image.FillRectangle(new SolidBrush(backgroundColor), backgroundRect);//绘制背景色
                g_image.FillRectangle(new SolidBrush(guideTagColor), guideRect);//绘制左前高亮指示
            }

            TextRenderer.DrawText(g_image, text, textFont, textRect, fontColor,TextFormatFlags.VerticalCenter | TextFormatFlags.Left); //绘制文本
            g.DrawImage(bitmap, bound.X, bound.Y, bitmap.Width, bitmap.Height);
            g_image.Dispose();
        }

        private void lstSongList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 20;
        }
        #endregion
    }
}