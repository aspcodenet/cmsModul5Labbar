using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab3
    {
        List<int> integers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489, 88 };



        void Lab3a()
        {
            var avg = integers.Average();
            Console.WriteLine(avg);
        }

        void Lab3b()
        {
            var max = integers.Max();
            Console.WriteLine(max);
        }
        void Lab3c()
        {
            var min = integers.Min();
            Console.WriteLine(min);
        }
        void Lab3d()
        {
            var result = integers.Sum();
            Console.WriteLine(result);
        }
        void Lab3e()
        {
            var result = integers.Where(r=> r % 2 == 0);
            foreach (var v in result)
                Console.WriteLine(v);
        }


        public void Run()
        {
            Lab3a();
            Lab3b();
            Lab3c();
            Lab3d();
            Lab3e();
        }
    }
}
