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
            NagrywarkaZPamiecia nagZPam = new NagrywarkaZPamiecia();
            nagZPam.DodajNagranie();
            nagZPam.DodajNagranie();
            nagZPam.DodajNagranie();
            nagZPam.WyswietlNagrania();
            Console.ReadKey();
        }
    }
}
