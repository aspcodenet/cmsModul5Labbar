using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.LinqLamda
{
    class Lab8
    {
        public void Run()
        {
            char []vowels = { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

            string fullText = "Flygande beckasiner söka whila på mjuka tufvor";
            var list2 = fullText.ToLower().Where(r => vowels.Contains(r)).ToList();
        }
    }
}
