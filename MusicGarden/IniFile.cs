using System.Text;
using System.Runtime.InteropServices;

namespace MusicGarden

{

    class IniFile

    {
        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        private string path;
        ///   <summary> 
        ///   实例初始化为指定路径的INI文件。 
        ///   </summary> 
        ///   <param   name= "path "> INI文件路径。 </param> 
        public IniFile(string path)

        {

            this.path = path;

        }



        ///   <summary> 
        ///   获取INI文件的路径。 
        ///   </summary>
        public string Path

        {

            get

            {

                return path;

            }

        }



        ///   <summary> 
        ///   读取指定小节下指定条目的字符串。 
        ///   </summary> 
        ///   <param   name= "sectionName "> 欲在其中查找条目的小节名称。这个字串不区分大小写。 </param> 
        ///   <param   name= "keyName "> 欲获取的项名或条目名。这个字串不区分大小写。 </param> 
        ///   <param   name= "defaultValue "> 指定的条目没有找到时返回的默认值。 </param> 
        ///   <returns> 指定小节下指定条目的字符串。 </returns> 
        ///   <remarks> 如果sectionName为null，则返回所有小节的列表，如果keyName为null，指定小节所有项的列表。 </remarks> 

        public string ReadString(string sectionName, string keyName, string defaultValue)

        {

            const int MAXSIZE = 255;

            StringBuilder temp = new StringBuilder(MAXSIZE);

            GetPrivateProfileString(sectionName, keyName, defaultValue, temp, 255, this.path);

            return temp.ToString();

        }



        public void WriteString(string sectionName, string keyName, string value)

        {

            WritePrivateProfileString(sectionName, keyName, value, this.path);

        }



        public int ReadInteger(string sectionName, string keyName, int defaultValue)

        {

            return GetPrivateProfileInt(sectionName, keyName, defaultValue, this.path);

        }



        public void WriteInteger(string sectionName, string keyName, int value)

        {

            WritePrivateProfileString(sectionName, keyName, value.ToString(), this.path);

        }



        public bool ReadBoolean(string sectionName, string keyName, bool defaultValue)

        {

            int temp = defaultValue ? 1 : 0;

            int result = GetPrivateProfileInt(sectionName, keyName, temp, this.path);

            return (result == 0 ? false : true);

        }



        public void WriteBoolean(string sectionName, string keyName, bool value)

        {

            string temp = value ? "1 " : "0 ";

            WritePrivateProfileString(sectionName, keyName, temp, this.path);

        }



        ///   <summary> 
        ///   删除这个项现有的字串。 
        ///   </summary> 
        ///   <param   name= "sectionName "> 要设置的项名或条目名。这个字串不区分大小写。 </param> 
        ///   <param   name= "keyName "> 要删除的项名或条目名。这个字串不区分大小写。 </param> 

        public void DeleteKey(string sectionName, string keyName)

        {

            WritePrivateProfileString(sectionName, keyName, null, this.path);

        }



        ///   <summary> 
        ///   删除这个小节的所有设置项。 
        ///   </summary> 
        ///   <param   name= "sectionName "> 要删除的小节名。这个字串不区分大小写。 </param> 

        public void EraseSection(string sectionName)

        {

            WritePrivateProfileString(sectionName, null, null, this.path);

        }



        

    }

}