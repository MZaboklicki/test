using System;
using System.Windows.Forms; //okienkowość, wymagania dodania dll w references
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Klasa
    {
        public delegate void del(string wiadomosc);
        public del zwykly_del;
        public event del zdarzenie_del;
        public void Metoda_delegacja()
        {
            if (zwykly_del != null)
                zwykly_del("Zwykły delegate...");
            if (zdarzenie_del != null)
                zdarzenie_del("Event delegate...");
        }
    }
    class Program
    {
        static private void objekt_metodazakonczona(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }
        static void Main(string[] args)
        {

            ///delegate, events
            Klasa obj = new Klasa();
            //subskrypcje
            obj.zwykly_del = objekt_metodazakonczona;
            obj.zdarzenie_del += objekt_metodazakonczona;
            obj.Metoda_delegacja();

            ///zmienne var i dynamic
            //var zm1 = 1L;
            //Console.WriteLine(zm1.GetType());
           // dynamic zm2 = 15;
           // Console.WriteLine(zm2.GetType());
           // zm2 = "abc";
          //Console.WriteLine(zm2.GetType());

            ///is sprawdza czy objekt jest danego typu np bool odp = obj is Exception;
            ///as sprawia, że jakiś obj jest traktowany jako obj innej klasy, ale zadziała tylko jeżeli jest to jakaś klas na której bazuje
            
            ///leniwa inicjacja Lazy<int> li = new Lazy<int>(()=>1) w nawiasie wyrażenie lambda 


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
