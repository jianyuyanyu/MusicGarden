namespace MusicGarden
{
    partial class DownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPage = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDownPath = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(770, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripStatusLabel1.Text = "准备";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(117, 20);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(632, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "刘若英";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(653, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.CheckBoxes = true;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.bitRate,
            this.singer,
            this.size,
            this.time,
            this.source});
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(14, 72);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(734, 349);
            this.listViewResult.TabIndex = 3;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "标题";
            this.name.Width = 160;
            // 
            // bitRate
            // 
            this.bitRate.Text = "比特率";
            this.bitRate.Width = 67;
            // 
            // singer
            // 
            this.singer.Text = "艺术家";
            this.singer.Width = 110;
            // 
            // size
            // 
            this.size.Text = "大小";
            this.size.Width = 74;
            // 
            // time
            // 
            this.time.Text = "持续时间";
            this.time.Width = 80;
            // 
            // source
            // 
            this.source.Text = "来源";
            this.source.Width = 120;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(708, 52);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(45, 15);
            this.lblPage.TabIndex = 7;
            this.lblPage.Text = "第1页";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "搜索结果：";
            // 
            // btnOpenDownPath
            // 
            this.btnOpenDownPath.BackColor = System.Drawing.Color.White;
            this.btnOpenDownPath.BackgroundImage = global::MusicGarden.Properties.Resources.文件;
            this.btnOpenDownPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenDownPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDownPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpenDownPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnOpenDownPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDownPath.Location = new System.Drawing.Point(647, 434);
            this.btnOpenDownPath.Name = "btnOpenDownPath";
            this.btnOpenDownPath.Size = new System.Drawing.Size(54, 37);
            this.btnOpenDownPath.TabIndex = 9;
            this.ttp.SetToolTip(this.btnOpenDownPath, "打开下载文件夹");
            this.btnOpenDownPath.UseVisualStyleBackColor = false;
            this.btnOpenDownPath.Click += new System.EventHandler(this.btnOpenDownPath_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnNextPage.BackgroundImage = global::MusicGarden.Properties.Resources.NavNext_normal;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Location = new System.Drawing.Point(408, 429);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(55, 47);
            this.btnNextPage.TabIndex = 6;
            this.ttp.SetToolTip(this.btnNextPage, "下一页");
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnLastPage.BackgroundImage = global::MusicGarden.Properties.Resources.NavBack_normal;
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Location = new System.Drawing.Point(311, 429);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(55, 47);
            this.btnLastPage.TabIndex = 5;
            this.ttp.SetToolTip(this.btnLastPage, "上一页");
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.BackgroundImage = global::MusicGarden.Properties.Resources.White_Download_normal;
            this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(523, 434);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(84, 37);
            this.btnDownload.TabIndex = 4;
            this.ttp.SetToolTip(this.btnDownload, "下载选中项");
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 589);
            this.Controls.Add(this.btnOpenDownPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.DownloadForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader bitRate;
        private System.Windows.Forms.ColumnHeader singer;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader source;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDownPath;
        private System.Windows.Forms.ToolTip ttp;
    }
}