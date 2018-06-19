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
        //read file from  Application.StartupPath + path
        public static byte[] ReadFileA(string path)
        {
            return ReadFile(Path.Combine(Application.StartupPath, path));
        }

        public static byte[] ReadFileResource(string FileName)
        {
            return ReadFile(Path.Combine(Application.StartupPath, "data/res/", FileName));
        }

        public static byte[] ReadFileDocs(string FileName)
        {
            return ReadFile(Path.Combine(Application.StartupPath, "data/docs/", FileName));
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
