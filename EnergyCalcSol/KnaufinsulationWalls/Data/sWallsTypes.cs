using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{
    public class sWallsTypes
    {
        public sWallsTypes()
        {
            Tp = 0;
            Ti = 0;
            Rw = 0;
            EI = 0;
            N = 0;
            ImageName = "";
        }

        public int Rw;
        public int Tp;
        public int EI;


        public int Ti;
        public int N;
        public String ImageName;

        public List<sFile> _files = new List<sFile>(6);

    }
}
