using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalc.CoreClass
{
    static public class sCalcRec
    {
        static public void Init()
        {
            BuildingType = 0;
        }
        static public sRegion _region;



        //page 2
        static public int BuildingType { get; set; }


        static public int Buildingtemperature { get; set; }


    }
}
