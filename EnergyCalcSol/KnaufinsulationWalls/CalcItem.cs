﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KnaufinsulationWalls.Data.Data_WallsType;

namespace KnaufinsulationWalls
{
    public class CalcItem
    {
        public CalcItem()
        {
            Rw = 0;
            Tp = 0;
            EI = 0;

            Ti = 0;
            N  = 0;
        }

        public int Rw;
        public int Tp;
        public int EI;

        public int Ti;
        public int N;
    }
    
}


