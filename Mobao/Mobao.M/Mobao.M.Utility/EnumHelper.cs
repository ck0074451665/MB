using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Utility
{
    public class EnumHelper
    {
        public static string GetDescription(object e)
        {
            var file = e.GetType().GetField(e.SafeToString());
            var fileAtts = file.GetCustomAttributes(false);
            if (fileAtts != null)
            {
                foreach (var item in fileAtts)
                {
                    if (item is DescriptionAttribute)
                    {
                        return ((DescriptionAttribute)item).Description;
                    }
                }
            }
            return string.Empty;
        }
    }
}
