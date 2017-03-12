using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    static class zad1
    {
        public static long silnia(byte arg)
        {
            
            long result = 1, prev_result;
            for (byte i = 1; i <= arg; ++i)
            {
                try
                {
                    prev_result = result;
                    result *= i;
                    if (result < prev_result)
                        throw new ArgumentOutOfRangeException("Podano zbyt dużą wartość");
                }
                catch(Exception ex)
                {
                    ConsoleColor normal_color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine("Błąd: " + ex.Message);
                    Console.ForegroundColor = normal_color;
                }
                
            } 
            return result;
        }
    }
}
