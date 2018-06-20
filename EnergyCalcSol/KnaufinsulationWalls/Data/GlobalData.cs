using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnaufinsulationWalls.Data
{
    public static class GlobalData
    {
        private static DateTime control_date = new DateTime(2018, 06, 20);

        public static void InitGlobalData()
        {
            var ret = IniFileManager.GetStringKey(Path.Combine(Application.StartupPath, "version.ini"),"version.version", "1.0.0");            
            Helper.ParseVersionString(ret, out VMain, out VMajor, out VMinor);
        }

        public static int VMain  = 1;
        public static int VMajor = 0;
        public static int VMinor = 0;
        
    }
}
