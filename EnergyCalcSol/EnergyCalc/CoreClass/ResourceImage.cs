using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalc.CoreClass
{
    static class ResourceImage
    {

        static public Image GetBuildImageByType(int type)
        {
            switch (type)
            {
                case 2:
                    return Properties.Resources.bld_6;
                case 3:
                    return Properties.Resources.bld_1;
                case 4:
                    return Properties.Resources.bld_6;
                case 6:
                    return Properties.Resources.bld_6;
                case 1:
                default:
                    return Properties.Resources.bld_1;
            }    
        }
    }
}
