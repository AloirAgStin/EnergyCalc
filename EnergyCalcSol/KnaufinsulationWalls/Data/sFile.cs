using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{
     public class sFile : ICloneable
    {
        public enum _type
        {
            FileName,
            FileDescription
        };

        public sFile(_type t, String value)
        {
            type = t;
            if (t == _type.FileName)
                FileName = value;
            else
                ExtInfo = value;
        }

        public String FileName;
        public String ExtInfo;
        public String FileDescription;

        public _type type;

        public object Clone()
        {
            var t = new sFile(type, "");
            t.ExtInfo = ExtInfo;
            t.FileName = FileName;
            t.FileDescription = FileDescription;

            return t;
        }
    }
}
