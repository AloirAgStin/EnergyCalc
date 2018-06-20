using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnaufinsulationWalls.Properties;

namespace KnaufinsulationWalls
{
    public static class Helper
    {

        public static void WriteLog(String text)
        {            
            try
            {
                var flname = IniFileManager.GetStringKey("debug.logFile");
                if (flname.Length == 0)
                    return;

                StringBuilder logStr = new StringBuilder();
                logStr.AppendFormat("{0} {1}.{2}: {3}\r\n", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), DateTime.Now.Millisecond,
                    text);
                File.AppendAllText(flname, logStr.ToString(), Encoding.UTF8);
            }
            catch(IOException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        public static void ParseVersionString(string version, out int vMain, out int vMajor, out int vMinor)
        {
            vMain  = 1;
            vMajor = 0;
            vMinor = 0;

            var listItem = version.Split('.');
            if( listItem.Length != 3)
            {
                WriteLog("Ошибка разбора строки версии (неверое количество разрядов): " + version);
                return;
            }

            int.TryParse(listItem[0], out vMain);
            int.TryParse(listItem[1], out vMajor);
            int.TryParse(listItem[2], out vMinor);
        }

    }
}
