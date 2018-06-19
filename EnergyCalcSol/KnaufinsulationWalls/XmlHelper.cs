using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KnaufinsulationWalls
{
    static class XmlHelper
    {
        public static String GetInnerValueXml(XmlNode node, string item)
        {
            try
            {
                var vl = node[item];
                return vl.InnerText;
            }
            catch (Exception)
            { }
            return "";
        }

    }
}
