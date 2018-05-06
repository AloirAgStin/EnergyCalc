using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnergyCalc.CoreClass
{
    static class SafeConvert
    {
        public static double ToDouble(string value)
        {
            try
            {
                if (value == null)
                    return 0;
                if (value.Length == 0)
                    return 0;

                string newVal = value;
                if (value.Length != 0 && value[0] == '.')
                    newVal = "0" + value;

                value = value.Replace(".", ",");
                return Convert.ToDouble(value);
             
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int toInt32(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception)
            {
                return 0;
            }
        }


    }
}
