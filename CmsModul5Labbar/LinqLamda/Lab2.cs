using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab2
    {
        string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth",
"Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis",
"INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple",
"U2"};


        void Lab2a()
        {
            var band = bands.OrderByDescending(b => b.Length).FirstOrDefault();
            Console.WriteLine(band);
        }

        void Lab2b()
        {
            var band = bands.OrderBy(b => b.Length).FirstOrDefault();
            Console.WriteLine(band);
        }
        void Lab2c()
        {
            var result = bands.Where(band => band.StartsWith("M")).Count();
            Console.WriteLine(result);
        }
        void Lab2d()
        {
            var result = bands.Where(band => band.Length > 6).OrderBy(band => band);
            foreach (var s in result)
                Console.WriteLine(s);
        }
        void Lab2e()
        {
            var result = bands.OrderBy(band => band);
            foreach (var s in result)
                Console.WriteLine(s);
        }


        public void Run()
        {
            Lab2a();
            Lab2b();
            Lab2c();
            Lab2d();
            Lab2e();
        }
    }
}
