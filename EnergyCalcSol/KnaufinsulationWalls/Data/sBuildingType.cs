using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{
    public class sBuildingType
    {
        public sBuildingType()
        {
            index = -1;
        }

        public String Name { get; set; }
        public int index { get; set; }

        public List<sBuildingWall> data = new List<sBuildingWall>(5);
    }

}
