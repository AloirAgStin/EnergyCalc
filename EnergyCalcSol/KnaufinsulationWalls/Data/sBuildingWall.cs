using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{
    public class sBuildingWall
    {
        public sBuildingWall() => Db = 0;

        public String Name { get; set; }
        public int index { get; set; }

        public int Db { get; set; }
        public String Description { get; set; }
    }

}
