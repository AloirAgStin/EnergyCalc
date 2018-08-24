using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            Version s = Assembly.GetExecutingAssembly().GetName().Version;
            StringBuilder vers = new StringBuilder();
            vers.AppendFormat("{0}.{1}.{2}", s.Major.ToString(), s.Minor.ToString(), s.Revision.ToString());

            var ret = IniFileManager.GetStringKey(Path.Combine(Application.StartupPath, "version.ini"),"version.version", vers.ToString());            
            Helper.ParseVersionString(ret, out VMain, out VMajor, out VMinor);   
        }

        public static int VMain  = 1;
        public static int VMajor = 0;
        public static int VMinor = 0;
        
    }
}
