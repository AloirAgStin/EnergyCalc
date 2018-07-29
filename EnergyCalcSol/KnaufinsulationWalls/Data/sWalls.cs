using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{

    public class sWalls : ICloneable
    {
        public String Name;
        public String Description;
        public List<sWallsTypes> types = new List<sWallsTypes>(5);

        public object Clone()
        {
            var item = new sWalls();
            item.Description = Description;
            item.Name = Name;
            item.types = types.ToList();
            return item;
        }

        public void DumpItem()
        {
            //todo dump data
            return;

            StringBuilder rec = new StringBuilder();
            rec.AppendFormat("Item: {0} - {1}\r\n", Name, Description);
            foreach (var itm in types)
            {
                rec.AppendFormat("\t{0} - {1} - {2} - {3} - {4} - {5}\r\n", itm.Tp, itm.Ti, itm.Rw, itm.EI, itm.N, itm.ImageName);

                foreach (var f in itm._files)
                {
                    rec.AppendFormat("\t\t{0} - {1}\r\n", f.FileName, f.ExtInfo);
                }
            }

            Helper.WriteLog(rec.ToString());
        }
    }
}
