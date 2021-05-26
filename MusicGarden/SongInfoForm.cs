using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGarden
{
    public partial class SongInfoForm : Form
    {
        private Songs info;
        public SongInfoForm(Songs inf)
        {
            InitializeComponent();
            info = inf;
        }

        private void SongInfoDetailForm_Load(object sender, EventArgs e)
        {
            txtSongName.Text = info.FileName;
            txtArtist.Text = info.Artist;
            txtFilePath.Text = info.FilePath;
            txtByteRate.Text = info.ByteRate;
            txtAlbum.Text = info.Album;
            txtDuration.Text = info.Duration;
            txtYear.Text = info.Year;
           
        }

        private void SongInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
