using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace MusicGarden
{ 
    public partial class SetForm : Form
    { 
        public SetForm()
        {
            InitializeComponent();
        }
        public string iniPath = Application.StartupPath + "\\Config.ini";
        string skinPath= Application.StartupPath+"\\Skin\\";
        string downPath = "D:\\MusicDownload\\";
        int pix = 5;
        public delegate void MyDelegate();//定义委托

        public event MyDelegate SetDoneEvent;//定义事件
        private void SetForm_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(iniPath);
            txtSkinPath.Text = ini.ReadString("setting", "skinPath", skinPath);
            txtDownPath.Text = ini.ReadString("setting", "downloadPath", downPath);
            lblPix.Text = ini.ReadInteger("setting", "blurPix", pix )+ "pix";
            tkbBlurRadius.Value = ini.ReadInteger("setting", "blurPix", 5);
            if (ini.ReadBoolean("setting", "autoRun", true))
            {
                chkAutoRun.Checked = true;

            }
            else
            {
                chkAutoRun.Checked = false;
            }

            if (ini.ReadBoolean("setting", "gaussianBlur", true))
            {
                chkBlur.Checked = true;

            }
            else
            {
                chkBlur.Checked = false;
            }
            if (ini.ReadBoolean("setting", "exit", true))
            {
                chkExit.Checked = true;

            }
            else
            {
                chkExit.Checked = false;
            }
     


        }

        private void btnSetSkin_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.InitialDirectory = Application.StartupPath; //开始文件位置
            IniFile ini = new IniFile(iniPath);
            ofd.Filter = "(*.jpg;*.png;*.jpeg;*.bmp;)|*.jpg;*.png;*.jpeg;*.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               if ( File.Exists(ofd.FileName))
                {
                    skinPath = ofd.FileName;
                    txtSkinPath.Text = ofd.FileName;
                    ini.WriteString("setting", "skinPath", skinPath);

                }
                else
                {
                    MessageBox.Show("路径错误或文件不存在", "错误");
                }
                
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(iniPath);
            ini.WriteBoolean("setting", "autoRun", chkAutoRun.Checked);
            ini.WriteBoolean("setting", "gaussianBlur", chkBlur.Checked);
            ini.WriteBoolean("setting", "exit", chkExit.Checked);
            ini.WriteInteger("setting", "blurPix", pix);
            SetDoneEvent();//触发事件
            MessageBox.Show("已保存当前设置，立即生效！", "提示");
            this.Visible = false ;
 
        }

        private void btnNotSave_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSetDownpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDownPath.Text = ofd.SelectedPath + "\\";
                IniFile ini = new IniFile(Application.StartupPath + "\\Config.ini");
                ini.WriteString("setting", "downloadPath", txtDownPath.Text);

            }
        }

       
        private void tkbBlurRadius_ValueChanged(object sender, EventArgs e)
        {
            pix = tkbBlurRadius.Value;
            lblPix.Text = pix.ToString()+"pix";
        }

    }
}
