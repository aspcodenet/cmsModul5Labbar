using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab7
    {
        public void Run()
        {
            int[] lista = { 1, 3, 5, 7 };
            var list2 = lista.Select(r => r + 2).ToList();
        }
    }
}
