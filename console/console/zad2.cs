using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class zad2
    {
        public static void Fibo(int[] tab)
        {
            tab[0] = 0;
            tab[1] = 1;
            for(int i=2; i<tab.Length; ++i)
            {
               tab[i] = tab[i - 2] + tab[i - 1];

            }
        }
    }
}
