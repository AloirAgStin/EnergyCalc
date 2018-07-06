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
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);
            }
            return "";
        }

        public static bool GetAttribute(XmlNode node, String attrName, out int value)
        {
            value = 0;

            String askvalue;
            if (!GetAttribute(node, attrName, out askvalue))
                return false;

            if (!Int32.TryParse(askvalue, out value))
            {
                Helper.WriteLog("Ошибка преобразования значения " + attrName + ": " + askvalue + " в целочисленный тип");
                return false;
            }
            return true;
        }

        public static bool GetAttribute(XmlNode node, String attrName, out String value)
        {
            value = "";

            try
            {
                var vl = node.Attributes[attrName];
                if (vl != null)
                    value = vl.Value;
                return true;
            }
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);
                return false;
            }
        }

    }
}
