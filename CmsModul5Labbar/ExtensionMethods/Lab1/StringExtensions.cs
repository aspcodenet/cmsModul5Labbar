using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab1
{
    static class StringExtensions
    {
        public static bool IsNumeric(this string varde)
        {
            decimal res;
            return decimal.TryParse(varde, out res);
        }
    }
}
