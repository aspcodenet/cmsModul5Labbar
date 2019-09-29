using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab1
{
    class Lab1
    {
        public void Run()
        {
            string s = "123";
            if (s.IsNumeric())
                Console.WriteLine("Yepp");
        }
    }
}
