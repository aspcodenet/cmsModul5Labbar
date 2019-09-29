using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar
{
    class Program
    {
        static void Main(string[] args)
        {
            var lab9 = new LinqLamda.Lab9();
            lab9.Run();


            var lab = new ExtensionMethods.Lab1.Lab1();
            lab.Run();

            var lab2 = new ExtensionMethods.Lab2.Lab2();
            lab2.Run();

            var lab3 = new ExtensionMethods.Lab3.Lab();
            lab3.Run();

            var lab4 = new ExtensionMethods.Lab4.Lab();
            lab4.Run();

            var lab5 = new ExtensionMethods.Lab5.Lab();
            lab5.Run();

        }
    }
}
