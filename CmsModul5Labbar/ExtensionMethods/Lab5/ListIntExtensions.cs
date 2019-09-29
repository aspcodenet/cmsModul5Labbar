using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab5
{
    static class ListIntExtensions
    {
        public static void Add(this List<int> list, params int[] items)
        {
            foreach (var listItem in items)
            {
                list.Add(listItem);
            }
        }
    }
}
