using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KnaufinsulationWalls
{
    public static class Base64Manager
    {
        public static bool IsBase64String(string s)
        {
            if (s == null || s.Length == 0)
                return false;
            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }

        public static byte[] FromBase64(string data)
        {
            return Convert.FromBase64String(data);
        }
    }
}
