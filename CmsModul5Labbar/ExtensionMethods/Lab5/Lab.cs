using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab5
{
    class Lab
    {
        public void Run()
        {
            var list = new List<int>();
            list.Add(12, 43243, 53, 3535);
            Console.WriteLine(list.Count());
        }
    }
}
