using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nagrywarka nag = new Nagrywarka();
           
            Console.WriteLine(nag.MiejsceNagrywania);
            Console.ReadKey();
        }
    }
}
