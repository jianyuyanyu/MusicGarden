namespace MusicGarden
{
    partial class MusicForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.添加歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDownloadSongs = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstSongList = new System.Windows.Forms.ListBox();
            this.NotifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblVol = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsSongList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSongInfoDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSreachSongName = new System.Windows.Forms.TextBox();
            this.lbNotFoundSong = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.pictureMax = new System.Windows.Forms.PictureBox();
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.btnVol = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.tkbVol = new MetroFramework.Controls.MetroTrackBar();
            this.pictureboxAlbumImage = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlayMode = new System.Windows.Forms.Button();
            this.tkbMove = new CCWin.SkinControl.SkinTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSongCount = new System.Windows.Forms.Label();
            this.richTextBoxLrc = new System.Windows.Forms.RichTextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.NotifyIconContextMenuStrip.SuspendLayout();
            this.cmsSongList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMove)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(347, 43);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(26, 21);
            this.MusicPlayer.TabIndex = 0;
            this.MusicPlayer.Visible = false;
            this.MusicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MusicPlayer_PlayStateChange);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip.Location = new System.Drawing.Point(0, 627);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(988, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加歌曲ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.下载ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(3, 30);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(208, 25);
            this.MenuStrip.Stretch = false;
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 添加歌曲ToolStripMenuItem
            // 
            this.添加歌曲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFile,
            this.tsmiOpenFolder,
            this.toolStripSeparator3,
            this.退出ToolStripMenuItem});
            this.添加歌曲ToolStripMenuItem.Name = "添加歌曲ToolStripMenuItem";
            this.添加歌曲ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加歌曲ToolStripMenuItem.Text = "添加歌曲";
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.Size = new System.Drawing.Size(136, 22);
            this.tsmiOpenFile.Text = "添加";
            this.tsmiOpenFile.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // tsmiOpenFolder
            // 
            this.tsmiOpenFolder.Name = "tsmiOpenFolder";
            this.tsmiOpenFolder.Size = new System.Drawing.Size(136, 22);
            this.tsmiOpenFolder.Text = "添加文件夹";
            this.tsmiOpenFolder.Click += new System.EventHandler(this.tsmiOpenFolder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDownloadSongs});
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.下载ToolStripMenuItem.Text = "下载";
            // 
            // tsmiDownloadSongs
            // 
            this.tsmiDownloadSongs.Name = "tsmiDownloadSongs";
            this.tsmiDownloadSongs.Size = new System.Drawing.Size(160, 22);
            this.tsmiDownloadSongs.Text = "搜索音乐并下载";
            this.tsmiDownloadSongs.Click += new System.EventHandler(this.tsmiDown_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.CheckOnClick = true;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // lstSongList
            // 
            this.lstSongList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSongList.BackColor = System.Drawing.Color.White;
            this.lstSongList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstSongList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstSongList.ForeColor = System.Drawing.Color.Black;
            this.lstSongList.FormattingEnabled = true;
            this.lstSongList.ItemHeight = 14;
            this.lstSongList.Location = new System.Drawing.Point(641, 130);
            this.lstSongList.Name = "lstSongList";
            this.lstSongList.Size = new System.Drawing.Size(335, 270);
            this.lstSongList.TabIndex = 6;
            this.lstSongList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSongList_DrawItem);
            this.lstSongList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstSongList_MeasureItem);
            this.lstSongList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSong_MouseDoubleClick);
            this.lstSongList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstSongList_MouseDown);
            this.lstSongList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstSongList_MouseMove);
            // 
            // NotifyIconContextMenuStrip
            // 
            this.NotifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenForm,
            this.tsmiSet,
            this.tsmiDown,
            this.tsmiAbout,
            this.tsmiQuit});
            this.NotifyIconContextMenuStrip.Name = "contextMenu";
            this.NotifyIconContextMenuStrip.Size = new System.Drawing.Size(137, 114);
            // 
            // tsmiOpenForm
            // 
            this.tsmiOpenForm.Name = "tsmiOpenForm";
            this.tsmiOpenForm.Size = new System.Drawing.Size(136, 22);
            this.tsmiOpenForm.Text = "显示主界面";
            this.tsmiOpenForm.Click += new System.EventHandler(this.tsmiShowForm_Click);
            // 
            // tsmiSet
            // 
            this.tsmiSet.Name = "tsmiSet";
            this.tsmiSet.Size = new System.Drawing.Size(136, 22);
            this.tsmiSet.Text = "设置";
            this.tsmiSet.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // tsmiDown
            // 
            this.tsmiDown.Name = "tsmiDown";
            this.tsmiDown.Size = new System.Drawing.Size(136, 22);
            this.tsmiDown.Text = "下载音乐";
            this.tsmiDown.Click += new System.EventHandler(this.tsmiDown_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(136, 22);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(136, 22);
            this.tsmiQuit.Text = "退出";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // lblVol
            // 
            this.lblVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVol.AutoSize = true;
            this.lblVol.BackColor = System.Drawing.Color.White;
            this.lblVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVol.Location = new System.Drawing.Point(925, 578);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(32, 16);
            this.lblVol.TabIndex = 9;
            this.lblVol.Text = "33%";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyIconContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            this.NotifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseMove);
            // 
            // cmsSongList
            // 
            this.cmsSongList.BackColor = System.Drawing.Color.Transparent;
            this.cmsSongList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlay,
            this.toolStripSeparator2,
            this.tsmiDelSong,
            this.tsmiDel,
            this.tsmiClearList,
            this.toolStripSeparator1,
            this.tsmiSongInfoDetail,
            this.tsmiOpenFilePath,
            this.tsmiCollection});
            this.cmsSongList.Name = "cmsSongListMenu";
            this.cmsSongList.Size = new System.Drawing.Size(161, 170);
            // 
            // tsmiPlay
            // 
            this.tsmiPlay.Name = "tsmiPlay";
            this.tsmiPlay.Size = new System.Drawing.Size(160, 22);
            this.tsmiPlay.Text = "播放";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmiDelSong
            // 
            this.tsmiDelSong.Name = "tsmiDelSong";
            this.tsmiDelSong.Size = new System.Drawing.Size(160, 22);
            this.tsmiDelSong.Text = "删除选中歌曲";
            this.tsmiDelSong.Click += new System.EventHandler(this.tsmiDelSong_Click);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(160, 22);
            this.tsmiDel.Text = "删除歌曲与文件";
            this.tsmiDel.Click += new System.EventHandler(this.tsmiDel_Click);
            // 
            // tsmiClearList
            // 
            this.tsmiClearList.Name = "tsmiClearList";
            this.tsmiClearList.Size = new System.Drawing.Size(160, 22);
            this.tsmiClearList.Text = "清空列表";
            this.tsmiClearList.Click += new System.EventHandler(this.tsmiClearList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmiSongInfoDetail
            // 
            this.tsmiSongInfoDetail.Name = "tsmiSongInfoDetail";
            this.tsmiSongInfoDetail.Size = new System.Drawing.Size(160, 22);
            this.tsmiSongInfoDetail.Text = "歌曲详情";
            this.tsmiSongInfoDetail.Click += new System.EventHandler(this.tsmiSongInfoDetail_Click);
            // 
            // tsmiOpenFilePath
            // 
            this.tsmiOpenFilePath.Name = "tsmiOpenFilePath";
            this.tsmiOpenFilePath.Size = new System.Drawing.Size(160, 22);
            this.tsmiOpenFilePath.Text = "打开所在文件夹";
            this.tsmiOpenFilePath.Click += new System.EventHandler(this.tsmiOpenFilePath_Click);
            // 
            // tsmiCollection
            // 
            this.tsmiCollection.Name = "tsmiCollection";
            this.tsmiCollection.Size = new System.Drawing.Size(160, 22);
            this.tsmiCollection.Text = "收藏";
            // 
            // txtSreachSongName
            // 
            this.txtSreachSongName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSreachSongName.BackColor = System.Drawing.Color.White;
            this.txtSreachSongName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSreachSongName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSreachSongName.Location = new System.Drawing.Point(641, 99);
            this.txtSreachSongName.Name = "txtSreachSongName";
            this.txtSreachSongName.Size = new System.Drawing.Size(217, 21);
            this.txtSreachSongName.TabIndex = 12;
            this.ToolTip.SetToolTip(this.txtSreachSongName, "搜索列表歌曲");
            this.txtSreachSongName.TextChanged += new System.EventHandler(this.txtSreachSongName_TextChanged);
            // 
            // lbNotFoundSong
            // 
            this.lbNotFoundSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotFoundSong.BackColor = System.Drawing.Color.Transparent;
            this.lbNotFoundSong.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNotFoundSong.ForeColor = System.Drawing.Color.Red;
            this.lbNotFoundSong.Location = new System.Drawing.Point(858, 99);
            this.lbNotFoundSong.Name = "lbNotFoundSong";
            this.lbNotFoundSong.Size = new System.Drawing.Size(118, 23);
            this.lbNotFoundSong.TabIndex = 14;
            this.lbNotFoundSong.Text = "无搜索结果";
            this.lbNotFoundSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNotFoundSong.Visible = false;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.White;
            // 
            // pictureExit
            // 
            this.pictureExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureExit.Image = global::MusicGarden.Properties.Resources.close_normal1;
            this.pictureExit.Location = new System.Drawing.Point(952, 3);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(33, 23);
            this.pictureExit.TabIndex = 3;
            this.pictureExit.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureExit, "关闭");
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            this.pictureExit.MouseEnter += new System.EventHandler(this.pictureExit_MouseEnter);
            this.pictureExit.MouseLeave += new System.EventHandler(this.pictureExit_MouseLeave);
            // 
            // pictureMax
            // 
            this.pictureMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureMax.Image = global::MusicGarden.Properties.Resources.maximize_hover;
            this.pictureMax.Location = new System.Drawing.Point(913, 3);
            this.pictureMax.Name = "pictureMax";
            this.pictureMax.Size = new System.Drawing.Size(33, 23);
            this.pictureMax.TabIndex = 2;
            this.pictureMax.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureMax, "最大化");
            this.pictureMax.Click += new System.EventHandler(this.pictureMax_Click);
            // 
            // pictureMin
            // 
            this.pictureMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureMin.Image = global::MusicGarden.Properties.Resources.minsize_hover;
            this.pictureMin.Location = new System.Drawing.Point(874, 3);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(33, 23);
            this.pictureMin.TabIndex = 1;
            this.pictureMin.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureMin, "最小化");
            this.pictureMin.Click += new System.EventHandler(this.pictureMin_Click);
            // 
            // btnVol
            // 
            this.btnVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVol.BackColor = System.Drawing.Color.Transparent;
            this.btnVol.BackgroundImage = global::MusicGarden.Properties.Resources.音量hover;
            this.btnVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnVol.FlatAppearance.BorderSize = 0;
            this.btnVol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnVol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVol.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVol.ForeColor = System.Drawing.Color.Red;
            this.btnVol.Location = new System.Drawing.Point(742, 571);
            this.btnVol.Name = "btnVol";
            this.btnVol.Size = new System.Drawing.Size(32, 32);
            this.btnVol.TabIndex = 19;
            this.ToolTip.SetToolTip(this.btnVol, "静音");
            this.btnVol.UseVisualStyleBackColor = false;
            this.btnVol.Click += new System.EventHandler(this.btnVol_Click);
            this.btnVol.MouseEnter += new System.EventHandler(this.btnVol_MouseEnter);
            this.btnVol.MouseLeave += new System.EventHandler(this.btnVol_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::MusicGarden.Properties.Resources.next_normal;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(280, 566);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 2;
            this.ToolTip.SetToolTip(this.btnNext, "下一首");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(145, 566);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 2;
            this.ToolTip.SetToolTip(this.btnBack, "上一首");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lblRun
            // 
            this.lblRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRun.AutoSize = true;
            this.lblRun.BackColor = System.Drawing.Color.Transparent;
            this.lblRun.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRun.Location = new System.Drawing.Point(141, 507);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(50, 21);
            this.lblRun.TabIndex = 15;
            this.lblRun.Text = "00:00";
            this.ToolTip.SetToolTip(this.lblRun, "当前时长");
            // 
            // lblAll
            // 
            this.lblAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAll.AutoSize = true;
            this.lblAll.BackColor = System.Drawing.Color.Transparent;
            this.lblAll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAll.Location = new System.Drawing.Point(924, 507);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(50, 21);
            this.lblAll.TabIndex = 16;
            this.lblAll.Text = "00:00";
            this.ToolTip.SetToolTip(this.lblAll, "歌曲时长");
            // 
            // tkbVol
            // 
            this.tkbVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbVol.BackColor = System.Drawing.Color.Transparent;
            this.tkbVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tkbVol.ForeColor = System.Drawing.Color.White;
            this.tkbVol.Location = new System.Drawing.Point(780, 575);
            this.tkbVol.MouseWheelBarPartitions = 25;
            this.tkbVol.Name = "tkbVol";
            this.tkbVol.Size = new System.Drawing.Size(135, 23);
            this.tkbVol.Style = MetroFramework.MetroColorStyle.Blue;
            this.tkbVol.TabIndex = 18;
            this.tkbVol.Text = "metroTrackBar1";
            this.ToolTip.SetToolTip(this.tkbVol, "音量");
            this.tkbVol.UseCustomBackColor = true;
            this.tkbVol.Value = 33;
            this.tkbVol.ValueChanged += new System.EventHandler(this.tkbVol_ValueChanged);
            // 
            // pictureboxAlbumImage
            // 
            this.pictureboxAlbumImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureboxAlbumImage.BackgroundImage = global::MusicGarden.Properties.Resources.head;
            this.pictureboxAlbumImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureboxAlbumImage.Location = new System.Drawing.Point(3, 480);
            this.pictureboxAlbumImage.Name = "pictureboxAlbumImage";
            this.pictureboxAlbumImage.Size = new System.Drawing.Size(132, 132);
            this.pictureboxAlbumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxAlbumImage.TabIndex = 11;
            this.pictureboxAlbumImage.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureboxAlbumImage, "歌曲内嵌专辑图片");
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::MusicGarden.Properties.Resources.play_normal;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(216, 566);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // btnPlayMode
            // 
            this.btnPlayMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayMode.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayMode.BackgroundImage")));
            this.btnPlayMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPlayMode.FlatAppearance.BorderSize = 0;
            this.btnPlayMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPlayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMode.Location = new System.Drawing.Point(428, 566);
            this.btnPlayMode.Name = "btnPlayMode";
            this.btnPlayMode.Size = new System.Drawing.Size(32, 32);
            this.btnPlayMode.TabIndex = 10;
            this.btnPlayMode.UseVisualStyleBackColor = false;
            this.btnPlayMode.Click += new System.EventHandler(this.btnPlayMode_Click);
            this.btnPlayMode.MouseEnter += new System.EventHandler(this.btnPlayMode_MouseEnter);
            this.btnPlayMode.MouseLeave += new System.EventHandler(this.btnPlayMode_MouseLeave);
            // 
            // tkbMove
            // 
            this.tkbMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbMove.BackColor = System.Drawing.Color.Transparent;
            this.tkbMove.Bar = null;
            this.tkbMove.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.tkbMove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.tkbMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tkbMove.Location = new System.Drawing.Point(197, 496);
            this.tkbMove.Name = "tkbMove";
            this.tkbMove.Size = new System.Drawing.Size(718, 45);
            this.tkbMove.TabIndex = 17;
            this.tkbMove.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbMove.Track = null;
            this.tkbMove.Scroll += new System.EventHandler(this.tkbMove_Scroll);
            this.tkbMove.ValueChanged += new System.EventHandler(this.tkbMove_ValueChanged);
            this.tkbMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tkbMove_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureExit);
            this.panel1.Controls.Add(this.pictureMax);
            this.panel1.Controls.Add(this.pictureMin);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 29);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicForm_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(3, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(111, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MusicGarden";
            // 
            // lblSongCount
            // 
            this.lblSongCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongCount.AutoSize = true;
            this.lblSongCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSongCount.Location = new System.Drawing.Point(766, 439);
            this.lblSongCount.Name = "lblSongCount";
            this.lblSongCount.Size = new System.Drawing.Size(48, 16);
            this.lblSongCount.TabIndex = 22;
            this.lblSongCount.Text = "共3首";
            // 
            // richTextBoxLrc
            // 
            this.richTextBoxLrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxLrc.BackColor = System.Drawing.Color.White;
            this.richTextBoxLrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLrc.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxLrc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxLrc.Location = new System.Drawing.Point(66, 130);
            this.richTextBoxLrc.Name = "richTextBoxLrc";
            this.richTextBoxLrc.Size = new System.Drawing.Size(367, 267);
            this.richTextBoxLrc.TabIndex = 23;
            this.richTextBoxLrc.Text = "";
            // 
            // lblSongName
            // 
            this.lblSongName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSongName.Location = new System.Drawing.Point(126, 95);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(122, 21);
            this.lblSongName.TabIndex = 24;
            this.lblSongName.Text = "当前无播放歌曲";
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 649);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.richTextBoxLrc);
            this.Controls.Add(this.lblSongCount);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVol);
            this.Controls.Add(this.tkbVol);
            this.Controls.Add(this.tkbMove);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.lbNotFoundSong);
            this.Controls.Add(this.txtSreachSongName);
            this.Controls.Add(this.pictureboxAlbumImage);
            this.Controls.Add(this.btnPlayMode);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lstSongList);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.MusicPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MusicForm";
            this.Opacity = 0.99D;
            this.Text = "MusicGarden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusicForm_FormClosed);
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.SizeChanged += new System.EventHandler(this.MusicForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.NotifyIconContextMenuStrip.ResumeLayout(false);
            this.cmsSongList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMove)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 添加歌曲ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip NotifyIconContextMenuStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ContextMenuStrip cmsSongList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongInfoDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFilePath;
        private System.Windows.Forms.PictureBox pictureboxAlbumImage;
        private System.Windows.Forms.TextBox txtSreachSongName;
        private System.Windows.Forms.Label lbNotFoundSong;
        public System.Windows.Forms.ListBox lstSongList;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblAll;
        private CCWin.SkinControl.SkinTrackBar tkbMove;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearList;
        private System.Windows.Forms.ToolStripMenuItem tsmiCollection;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.PictureBox pictureMax;
        private System.Windows.Forms.PictureBox pictureMin;
        private System.Windows.Forms.Button btnPlayMode;
        private MetroFramework.Controls.MetroTrackBar tkbVol;
        private System.Windows.Forms.Button btnVol;
        private System.Windows.Forms.Label lblSongCount;
        private System.Windows.Forms.RichTextBox richTextBoxLrc;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownloadSongs;
        private System.Windows.Forms.ToolStripMenuItem tsmiDown;
    }
}

