using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab9
    {
        void R1()
        {
            Stopwatch stopwatch = new Stopwatch(); //Skapa ett stopwatchobjekt
            stopwatch.Start(); //Starta stoppuret

            var list = new List<int>();
            for (int i = 0; i < 1000000; i++)
                list.Add(i);
            int sum = 0;
            foreach (var v in list)
                sum += v;
            int n = sum / 1000000;
            Console.WriteLine(n);
            stopwatch.Stop(); //Stoppa klockan
            Console.WriteLine(stopwatch.Elapsed.ToString()); //Visa hur lång tid det tog        
        }

        void R2()
        {
            Stopwatch stopwatch = new Stopwatch(); //Skapa ett stopwatchobjekt
            stopwatch.Start(); //Starta stoppuret

            int sum = 0;
            foreach (var v in Enumerable.Range(1, 1000000))
                sum += v;
            int n = sum / 1000000;
            Console.WriteLine(n);

            stopwatch.Stop(); //Stoppa klockan
            Console.WriteLine(stopwatch.Elapsed.ToString()); //Visa hur lång tid det tog        
        }



        public void Run()
        {
            R1();
            R2();

        }
    }
}
