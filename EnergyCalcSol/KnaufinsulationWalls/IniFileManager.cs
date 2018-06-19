using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace KnaufinsulationWalls
{
    public static class IniFileManager
    {
        private static string _path = Application.StartupPath;
        public static string GetStringKey(string key, string defaultValue = "")
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(Path.Combine(_path, "config.ini"));
                
                var s = data.GetKey(key);
                if (s == null)
                    return defaultValue;
                if (s.Length == 0)
                    return defaultValue;

                return s;
            }
            catch(Exception)
            {
                //todo error log
                return defaultValue;
            }
        }


        public static bool GetBoolKey(string key, bool defaultValue = false)
        {
            var str = GetStringKey(key);
            bool ret = false;

            Boolean.TryParse(str, out ret);

            return ret;            
        }



    }
}
