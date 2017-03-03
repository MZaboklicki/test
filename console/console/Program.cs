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

            ///zmienne var i dynamic
            //var zm1 = 1L;
            //Console.WriteLine(zm1.GetType());
           // dynamic zm2 = 15;
           // Console.WriteLine(zm2.GetType());
           // zm2 = "abc";
          //Console.WriteLine(zm2.GetType());

            
            ///wyjątki
            //int a=0;
            // int x = checked(int.MaxValue +1);  checked sprawdza, czy został przekoczony zakres int
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


            //Wykorzystanie okienka w aplikacji konsolowej
            //MessageBox.Show("hello");
            //Odczytywanie zmiennych środowiskowych / specjalnych folderów / info osystemie  Klasa Environment np:
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.History);
  

            Console.ReadKey();
        }
    }
}
