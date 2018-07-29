using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{

    public class sLineWallsStruct
    {
        public String Name;
        public String Description;
        public sWallsTypes WallTypes;

        public String GetNameExtVal()
        {
            int pos1 = Name.IndexOf("(");
            int pos2 = Name.IndexOf(")");
            if (pos1 < pos2 && pos1 != pos2 && pos1 != -1 && pos2 != -1)
                return Name.Substring(pos1, pos2 - pos1 + 1);

            return "";
        }
    }
}
