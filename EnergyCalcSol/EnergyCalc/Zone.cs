using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalc
{
    public enum eOblast
    {
        KRIM = 1, 
        VINICKAYA,
        VOLINSKAYA,
        DNEPROPETROVSKAYA

    };

    public enum eZone
    {
        I = 1,
        II,
        III
    };

    public struct sRegion
    {
        public string Name;
        public eZone zone;
        public eOblast obl;

        public override string ToString()
        {
            return Name;
        }
    };
    
    public static class RegionList
    {
        static public List<sRegion> GetRegionList()
        {
            return _regiondata;
        }


        static public List<sRegion> _regiondata = new List<sRegion>()
        {
            //крым
            new sRegion(){ Name = "Джанкай" ,       zone = eZone.II,    obl = eOblast.KRIM},
            new sRegion(){ Name = "Симферополь" ,   zone = eZone.II,    obl = eOblast.KRIM},
            new sRegion(){ Name = "Феодосия" ,      zone = eZone.II ,   obl = eOblast.KRIM},
            new sRegion(){ Name = "Ялта" ,          zone = eZone.II,    obl = eOblast.KRIM},

            //виницкая 
             new sRegion(){ Name = "Винница" ,      zone = eZone.I ,    obl = eOblast.VINICKAYA},
           
            //волынская
            new sRegion(){ Name = "Ковель" ,        zone = eZone.II ,   obl = eOblast.VOLINSKAYA},
            new sRegion(){ Name = "Луцк" ,          zone = eZone.II ,   obl = eOblast.VOLINSKAYA},

            //днепропетровская
        };

    }
   
        


}
