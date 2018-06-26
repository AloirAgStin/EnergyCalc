using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnaufinsulationWalls
{
    public static class FileManager
    {

        private static string docsPostfix = @"data\docs\";
        private static string resPostfix  = @"data\res\";

        //read file from  Application.StartupPath + path
        public static byte[] ReadFileA(string path)
        {
            return ReadFile(Path.Combine(Application.StartupPath, path));
        }

        public static string GetPathToRes(string addText = "")
        {
            var ret = Path.Combine(Application.StartupPath, resPostfix);

            if(addText.Length > 0)
                return Path.Combine(ret, addText);
            
            return ret;
        }

        public static string GetPathToDocs(string addText = "")
        {
            var ret = Path.Combine(Application.StartupPath, docsPostfix);

            if (addText.Length > 0)
                return Path.Combine(ret, addText);

            return ret;
        }


        public static byte[] ReadFileResource(string FileName)
        {
            return ReadFile(Path.Combine(Application.StartupPath, resPostfix, FileName));
        }

        public static byte[] ReadFileDocs(string FileName)
        {
            return ReadFile(Path.Combine(Application.StartupPath, docsPostfix, FileName));
        }


        private static byte[] ReadFile(string path)
        {
            try
            {
                return File.ReadAllBytes(path);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
