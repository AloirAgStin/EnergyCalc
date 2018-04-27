using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalc
{
    public struct sRegion
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public int Code { get; set; }
    };

    public struct sRegionGroup
    {
        public string Name { get; set; }
        public List<sRegion> RegionsList { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    static public class RegionController
    {
        static public sRegionGroup GetRegionGroup(string RegionName)
        {
            if(RegionName.CompareTo("Минская") == 0)
            {
                sRegionGroup gr = new sRegionGroup();
                gr.Name = "Минская";
                gr.RegionsList.Add(new sRegion() { Name = "Минск" });
                gr.RegionsList.Add(new sRegion() { Name = "Фаниполь" });
                gr.RegionsList.Add(new sRegion() { Name = "Боровляны" });
                return gr;
            }
            
            return new sRegionGroup();
        }


        static public sRegion[] GetRegionsGroupName()
        {
            List<sRegion> reg = new List<sRegion>()
                {
                    new sRegion() { Name = "Минская"  },
                    new sRegion() { Name = "Витебкая" },
                    new sRegion() { Name = "Могилевская"  },
                    new sRegion() { Name = "Брестская" },
                    new sRegion() { Name = "Гомельская" },
                    new sRegion() { Name = "Гродно" }
                };


            return reg.ToArray();
            
        }
    }


}
