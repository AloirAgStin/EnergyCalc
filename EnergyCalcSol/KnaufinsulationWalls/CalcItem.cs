using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls
{
    public class CalcItem
    {
        public CalcItem()
        {
            DBIndex = 0;
            Tp = 0;
            EI = 0;

            Ti = 0;
            Tk = 0;
            N  = 0;
        }

        public int DBIndex;
        public int Tp;
        public int EI;

        public int Ti;
        public int Tk;
        public int N;
    }
}
