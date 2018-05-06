using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalc.CoreClass
{
    public class sCalcRec
    {
        public void Init()
        {
            st2_BuildingType = 0;
            Buildingtemperature = 21;

            st2_Lenght  = 0;
            st2_Wight   = 0;
            st2_Height  = 0;
            st2_Konek   = 0;
            st2_basement = 0;
            st2_level   = 0;
            st2_temperature = 0;

        }
        public sRegion _region;



        //page 2
        public int st2_BuildingType { get; set; }

        public double st2_Lenght { get; set; }
        public double st2_Wight{ get; set; }
        public double st2_Height { get; set; }
        public double st2_Konek { get; set; }
        public double st2_basement { get; set; }
        public int st2_level { get; set; }
        public int st2_temperature { get; set; }


        public int Buildingtemperature { get; set; }


    }
}
