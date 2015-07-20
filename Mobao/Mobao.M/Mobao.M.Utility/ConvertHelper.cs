using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Utility
{
    public static class ConvertHelper
    {
        public static string SafeToString(this object obj)
        {
            if (obj == null) return string.Empty;
            return obj.ToString();
        }

        public static int SafeToInt(this object obj)
        {
            if (obj == null) return default(int);
            int result = default(int);
            int.TryParse(obj.ToString(), out result);
            return result;
        }
    }

}
