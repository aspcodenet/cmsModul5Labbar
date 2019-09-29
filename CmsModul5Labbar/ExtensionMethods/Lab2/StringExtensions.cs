using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab2
{
    static class StringExtensions
    {
        public static string UppercaseWordFirstLetter(this string varde)
        {
            var builder = new StringBuilder();
            foreach (var word in varde.Split(' '))
                builder.Append( word.Substring(0, 1).ToUpper() + word.Substring(1) + " ");
            return builder.ToString().TrimEnd();
        }
    }
}
