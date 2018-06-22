using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace KnaufinsulationWalls
{
    public static class IniFileManager
    {
        private static string _pathIni = Path.Combine(Application.StartupPath, "config.ini");
        public static string GetStringKey(string key, string defaultValue = "")
        {
            return GetStringKey(_pathIni, key, defaultValue);
        }

        public static string GetStringKey(string FilePath, string key, string defaultValue = "")
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(FilePath, Encoding.ASCII);

                var s = data.GetKey(key);
                if (s == null)
                    return defaultValue;
                if (s.Length == 0)
                    return defaultValue;

                return s;
            }
            catch (Exception e)
            {
                Helper.WriteLog(e.Message);
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


        public static void WriteStringKey(string key, string section, string value)
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(_pathIni);
                data[key][section] = value;

                parser.WriteFile(_pathIni, data, Encoding.ASCII);

            }
            catch (Exception e)
            {
                Helper.WriteLog(e.Message);
            }
        }



    }
}
