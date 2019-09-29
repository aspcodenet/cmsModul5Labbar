using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab4
{
    class Lab
    {
        public void Run()
        {
            var list = new List<string> { "Hej", "Hopp", "Hello"};
            Console.WriteLine(list.ListToString());
        }
    }
}
