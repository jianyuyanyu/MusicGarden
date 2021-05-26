using Shell32;
using System.Drawing;
using System.IO;

namespace MusicGarden
{
    public class Songs
    {
        public Songs(string MP3Path)
        {
            SetSongInfo(MP3Path);
            ReadTaglib(MP3Path);
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        private string filesize;
        public string Filesize
        {
            get { return filesize; }
            set { filesize = value; }
        }
        private string artist;
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private string album;
        public string Album
        {
            get { return album; }
            set { album = value; }
        }
        private Image image;
        public Image AlbumImage
        {
            get { return image; }
            set { image = value; }
        }
        private string year;
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private string originName;
        public string OriginName
        {
            get { return originName; }
            set { originName = value; }
        }
        private string duration;
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string byteRate;
        public string ByteRate
        {
            get { return byteRate; }

            set { byteRate = value; }
        }



       
        private void SetSongInfo(string strPath)
        {
            ShellClass sh = new ShellClass();
            if (!string.IsNullOrEmpty(strPath))
            {
                
                Folder dir = sh.NameSpace(Path.GetDirectoryName(strPath));
                FolderItem item = dir.ParseName(Path.GetFileName(strPath));


                fileName = dir.GetDetailsOf(item, 0);
                if (fileName == "")
                    fileName = "未知";

                FilePath = strPath;

                filesize = dir.GetDetailsOf(item, 1);
                if (filesize == "")
                    filesize = "未知";

                artist = dir.GetDetailsOf(item, 13);
                if (artist == "")
                    artist = "未知";

                album = dir.GetDetailsOf(item, 14);
                if (album == "")
                    album = "未知";

                year = dir.GetDetailsOf(item, 15);
                if (year == "")
                    year = "未知";

                OriginName = dir.GetDetailsOf(item, 21);
                if (OriginName == "")
                    OriginName = "未知";

                duration = dir.GetDetailsOf(item, 27);
                if (duration == "")
                    duration = "未知";

                byteRate = dir.GetDetailsOf(item, 28);
                if (byteRate == "")
                    byteRate = "未知";
            }
        }

        private void ReadTaglib(string path)
        {
            if (path != "" && path != null)
            {
                using (TagLib.File file = TagLib.File.Create(path))
                {
                    if (file.Tag.Pictures != null && file.Tag.Pictures.Length >= 1)
                    {
                        byte[] data = file.Tag.Pictures[0].Data.Data;
                        MemoryStream ms = new MemoryStream(data);
                        image = Image.FromStream(ms);
                    }
                    else
                    {
                        image = Image.FromFile("Image\\head.jpg");
                    }

                } 
            }
            else
            {
                image = Image.FromFile("Image\\head.jpg");
            }

        }
    }
}
