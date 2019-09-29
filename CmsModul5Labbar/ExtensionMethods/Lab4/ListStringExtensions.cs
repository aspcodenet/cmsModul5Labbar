using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab4
{
    static class ListStringExtensions
    {
        public static string ListToString(this List<string> list)
        {
            var result = new StringBuilder("");
            if (list.Count > 0)
            { 
                result.Append(list[0].ToString());
                for (int i = 1; i < list.Count; i++)
                {
                    result.AppendFormat(", {0}", list[i].ToString());
                }
            }
            return result.ToString();
        }    }
}
