using System;
using System.Windows.Forms; //okienkowość, wymagania dodania dll w references
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {



            ///wyjątki
            //int a=0;
            //try
            //{
            //    Console.WriteLine("Podaj a: ");
            //    a = Convert.ToInt16(Console.ReadLine());

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("a musi być liczbą");
            //    a = 1;
            //}
            //Console.WriteLine(a);
            //ciekawostki

            //Wykorzystanie okienka w aplikacji konsolowej
            //MessageBox.Show("hello");
            //Odczytywanie zmiennych środowiskowych / specjalnych folderów   Klasa Environment np:
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.History);
            

            Console.ReadKey();
        }
    }
}
