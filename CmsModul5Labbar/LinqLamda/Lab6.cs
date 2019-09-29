using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab6
    {
        public void Run()
        {
            string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom" };
            var result = namnLista.OrderBy(namn => namn.Substring(namn.IndexOf(' ')));
        }
    }
}
