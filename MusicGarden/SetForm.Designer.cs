namespace MusicGarden
{
    partial class SetForm
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
            this.chkAutoRun = new CCWin.SkinControl.SkinCheckBox();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.chkBlur = new CCWin.SkinControl.SkinCheckBox();
            this.chkExit = new CCWin.SkinControl.SkinCheckBox();
            this.btnSetSkin = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkinPath = new System.Windows.Forms.TextBox();
            this.btnNotSave = new CCWin.SkinControl.SkinButton();
            this.txtDownPath = new System.Windows.Forms.TextBox();
            this.btnSetDownpath = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tkbBlurRadius = new MetroFramework.Controls.MetroTrackBar();
            this.lblPix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoRun.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkAutoRun.DownBack = null;
            this.chkAutoRun.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAutoRun.Location = new System.Drawing.Point(14, 14);
            this.chkAutoRun.MouseBack = null;
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.NormlBack = null;
            this.chkAutoRun.SelectedDownBack = null;
            this.chkAutoRun.SelectedMouseBack = null;
            this.chkAutoRun.SelectedNormlBack = null;
            this.chkAutoRun.Size = new System.Drawing.Size(148, 24);
            this.chkAutoRun.TabIndex = 3;
            this.chkAutoRun.Text = "启用开机自启";
            this.chkAutoRun.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DownBack = null;
            this.btnSave.DownBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(43, 290);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkBlur
            // 
            this.chkBlur.AutoSize = true;
            this.chkBlur.BackColor = System.Drawing.Color.Transparent;
            this.chkBlur.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkBlur.DownBack = null;
            this.chkBlur.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBlur.Location = new System.Drawing.Point(14, 44);
            this.chkBlur.MouseBack = null;
            this.chkBlur.Name = "chkBlur";
            this.chkBlur.NormlBack = null;
            this.chkBlur.SelectedDownBack = null;
            this.chkBlur.SelectedMouseBack = null;
            this.chkBlur.SelectedNormlBack = null;
            this.chkBlur.Size = new System.Drawing.Size(188, 24);
            this.chkBlur.TabIndex = 5;
            this.chkBlur.Text = "启用背景高斯模糊";
            this.chkBlur.UseVisualStyleBackColor = false;
            // 
            // chkExit
            // 
            this.chkExit.AutoSize = true;
            this.chkExit.BackColor = System.Drawing.Color.Transparent;
            this.chkExit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkExit.DownBack = null;
            this.chkExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkExit.Location = new System.Drawing.Point(14, 133);
            this.chkExit.MouseBack = null;
            this.chkExit.Name = "chkExit";
            this.chkExit.NormlBack = null;
            this.chkExit.SelectedDownBack = null;
            this.chkExit.SelectedMouseBack = null;
            this.chkExit.SelectedNormlBack = null;
            this.chkExit.Size = new System.Drawing.Size(268, 24);
            this.chkExit.TabIndex = 6;
            this.chkExit.Text = "关闭主面板时直接退出程序";
            this.chkExit.UseVisualStyleBackColor = false;
            // 
            // btnSetSkin
            // 
            this.btnSetSkin.BackColor = System.Drawing.Color.Transparent;
            this.btnSetSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSetSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSetSkin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetSkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetSkin.DownBack = null;
            this.btnSetSkin.DownBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSetSkin.ForeColorSuit = true;
            this.btnSetSkin.Location = new System.Drawing.Point(397, 187);
            this.btnSetSkin.MouseBack = null;
            this.btnSetSkin.Name = "btnSetSkin";
            this.btnSetSkin.NormlBack = null;
            this.btnSetSkin.Size = new System.Drawing.Size(75, 31);
            this.btnSetSkin.TabIndex = 7;
            this.btnSetSkin.Text = "浏览";
            this.btnSetSkin.UseVisualStyleBackColor = false;
            this.btnSetSkin.Click += new System.EventHandler(this.btnSetSkin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "皮肤路径：";
            // 
            // txtSkinPath
            // 
            this.txtSkinPath.Location = new System.Drawing.Point(14, 191);
            this.txtSkinPath.Name = "txtSkinPath";
            this.txtSkinPath.Size = new System.Drawing.Size(375, 23);
            this.txtSkinPath.TabIndex = 9;
            // 
            // btnNotSave
            // 
            this.btnNotSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNotSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNotSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNotSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNotSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotSave.DownBack = null;
            this.btnNotSave.DownBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnNotSave.Location = new System.Drawing.Point(339, 290);
            this.btnNotSave.MouseBack = null;
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.NormlBack = null;
            this.btnNotSave.Size = new System.Drawing.Size(92, 41);
            this.btnNotSave.TabIndex = 10;
            this.btnNotSave.Text = "取消";
            this.btnNotSave.UseVisualStyleBackColor = false;
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click);
            // 
            // txtDownPath
            // 
            this.txtDownPath.Location = new System.Drawing.Point(14, 246);
            this.txtDownPath.Name = "txtDownPath";
            this.txtDownPath.Size = new System.Drawing.Size(375, 23);
            this.txtDownPath.TabIndex = 11;
            // 
            // btnSetDownpath
            // 
            this.btnSetDownpath.BackColor = System.Drawing.Color.Transparent;
            this.btnSetDownpath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSetDownpath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSetDownpath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetDownpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetDownpath.DownBack = null;
            this.btnSetDownpath.DownBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSetDownpath.ForeColorSuit = true;
            this.btnSetDownpath.Location = new System.Drawing.Point(397, 241);
            this.btnSetDownpath.MouseBack = null;
            this.btnSetDownpath.Name = "btnSetDownpath";
            this.btnSetDownpath.NormlBack = null;
            this.btnSetDownpath.Size = new System.Drawing.Size(75, 31);
            this.btnSetDownpath.TabIndex = 12;
            this.btnSetDownpath.Text = "浏览";
            this.btnSetDownpath.UseVisualStyleBackColor = false;
            this.btnSetDownpath.Click += new System.EventHandler(this.btnSetDownpath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "下载路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "高斯模糊半径：";
            // 
            // tkbBlurRadius
            // 
            this.tkbBlurRadius.BackColor = System.Drawing.Color.Transparent;
            this.tkbBlurRadius.Location = new System.Drawing.Point(164, 77);
            this.tkbBlurRadius.Maximum = 20;
            this.tkbBlurRadius.Minimum = 3;
            this.tkbBlurRadius.Name = "tkbBlurRadius";
            this.tkbBlurRadius.Size = new System.Drawing.Size(145, 34);
            this.tkbBlurRadius.TabIndex = 16;
            this.tkbBlurRadius.Text = "metroTrackBar1";
            this.tkbBlurRadius.Value = 3;
            this.tkbBlurRadius.ValueChanged += new System.EventHandler(this.tkbBlurRadius_ValueChanged);
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPix.Location = new System.Drawing.Point(316, 85);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(44, 17);
            this.lblPix.TabIndex = 17;
            this.lblPix.Text = "3pix";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 339);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.tkbBlurRadius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetDownpath);
            this.Controls.Add(this.txtDownPath);
            this.Controls.Add(this.btnNotSave);
            this.Controls.Add(this.txtSkinPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetSkin);
            this.Controls.Add(this.chkExit);
            this.Controls.Add(this.chkBlur);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkAutoRun);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 384);
            this.MinimizeBox = false;
            this.Name = "SetForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinCheckBox chkAutoRun;
        private CCWin.SkinControl.SkinCheckBox chkBlur;
        private CCWin.SkinControl.SkinCheckBox chkExit;
        private CCWin.SkinControl.SkinButton btnSetSkin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkinPath;
        private CCWin.SkinControl.SkinButton btnNotSave;
        public CCWin.SkinControl.SkinButton btnSave;
        private System.Windows.Forms.TextBox txtDownPath;
        private CCWin.SkinControl.SkinButton btnSetDownpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTrackBar tkbBlurRadius;
        public System.Windows.Forms.Label lblPix;
    }
}