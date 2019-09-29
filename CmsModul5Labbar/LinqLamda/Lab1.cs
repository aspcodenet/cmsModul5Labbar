using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab1
    {
        string[] bilar = { "Volvo", "BMW", "Audi", "Skoda",
"Toyota", "Ford", "Mercedes","Seat", "Honda",
"Volkswagen","Opel", "Mazda","Suzuki" };


        void Lab1a()
        {
            var bil = bilar.FirstOrDefault(b=>b.Equals("opel", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(bil);
        }

        void Lab1b()
        {
            var result = bilar.Where(b => b.StartsWith("V", StringComparison.OrdinalIgnoreCase));
            foreach (var s in result)
                Console.WriteLine(s);
        }
        void Lab1c()
        {
            var result = bilar.Where(b => b.ToLower().Contains("da"));
            foreach (var s in result)
                Console.WriteLine(s);
        }
        void Lab1d()
        {
            var result = bilar.Where(b => b.StartsWith("M") || b.EndsWith("i"));
            foreach (var s in result)
                Console.WriteLine(s);
        }


        public void Run()
        {
            Lab1a();
            Lab1b();
            Lab1c();
            Lab1d();
        }
    }
}
