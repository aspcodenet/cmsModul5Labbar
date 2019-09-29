using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab3
{
    class Lab
    {
        public void Run()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.GetLastDateOfMonth());
        }
    }
}
