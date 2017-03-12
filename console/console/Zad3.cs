using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    static class Zad3
    {
        public static void Tax(int value)
        {
            int tax = 0;
            if (value < 10000)
            {
                tax = value * 1 / 10;
                Console.Write("10% ");
            }

            else if (value > 30000)
            {
                tax = value * 3 / 10;
                Console.Write("30% ");
            }
            else
            {
                tax = value * 2 / 10;
                Console.Write("20% ");
            }
            Console.WriteLine("Podatek: "+tax);
        }
    }
}
