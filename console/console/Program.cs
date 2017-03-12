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
        static private void objekt_metodazakonczona(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }
        static void Main(string[] args)
        {

            /////delegate, events
            //Klasa_del obj = new Klasa_del();
            ////subskrypcje
            //obj.zwykly_del = objekt_metodazakonczona;
            //obj.zdarzenie_del += objekt_metodazakonczona;
            //obj.Metoda_delegacja();

            /////typy parametryczne
            //int a = 5;
            //int b = 10;
            //Para<int, int> para1 = new Para<int,int>(a,b);
            //para1.Print();

            //Random rand = new Random();
            //Para<int, int>[] tab_para1 = new Para<int, int>[10];    
            //for(int i=0; i<tab_para1.Length; i++)
            //{
            //    tab_para1[i] = new Para<int, int>(rand.Next(10,200), rand.Next(10,200));
            //}
            //for(int i=0; i<tab_para1.Length; i++)
            //{
            //    tab_para1[i].Print();
            //}
            //Para<string, int>[] tab_para2 = new Para<string, int>[5];
            //tab_para2[0] = new Para<string, int>("Tomek", 3);
            //tab_para2[1] = new Para<string, int>("Marek", 2);
            //tab_para2[2] = new Para<string, int>("Jacek", 16);
            //tab_para2[3] = new Para<string, int>("Tomek", 9);
            //tab_para2[4] = new Para<string, int>("Kuba", 1);
            //foreach(Para<string,int> zm in tab_para2)
            //{
            //    zm.Print();
            //}
            //Console.WriteLine("SORTOWANIE");
            //Array.Sort(tab_para1);
            //Array.Sort(tab_para2);
            //foreach (Para<int,int> zm in tab_para1)
            //{
            //    zm.Print();
            //}
            //foreach (Para<string, int> zm in tab_para2)
            //{
            //    zm.Print();
            //}


            /////zmienne var i dynamic
            ////var zm1 = 1L;
            ////Console.WriteLine(zm1.GetType());
            //// dynamic zm2 = 15;
            //// Console.WriteLine(zm2.GetType());
            //// zm2 = "abc";
            ////Console.WriteLine(zm2.GetType());

            /////is sprawdza czy objekt jest danego typu np bool odp = obj is Exception;
            /////as sprawia, że jakiś obj jest traktowany jako obj innej klasy, ale zadziała tylko jeżeli jest to jakaś klas na której bazuje

            /////leniwa inicjacja Lazy<int> li = new Lazy<int>(()=>1) w nawiasie wyrażenie lambda 


            /////wyjątki
            ////int a=0;
            //// int x = checked(int.MaxValue +1);  checked sprawdza, czy został przekoczony zakres int
            ////try
            ////{
            ////    Console.WriteLine("Podaj a: ");
            ////    a = Convert.ToInt16(Console.ReadLine());
            ////}
            ////catch(Exception ex)
            ////{
            ////    Console.WriteLine("a musi być liczbą");
            ////    a = 1;
            ////}
            ////Console.WriteLine(a);


            ////Wykorzystanie okienka w aplikacji konsolowej
            ////MessageBox.Show("hello");
            ////Odczytywanie zmiennych środowiskowych / specjalnych folderów / info osystemie  Klasa Environment np:
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.History);

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //Zadanie 1
            //  Console.WriteLine(zad1.silnia(21).ToString());


            //zad2
            //int[] tab = new int[15];
            //zad2.Fibo(tab);
            //foreach(int val in tab)
            //{
            //    Console.Write(val.ToString() + ", ");
            //}

            //Zad3
            //Zad3.Tax(30001);

            //Zad4
            //for(int i=0; i<4; i++)
            //{
            //    for (int j = i; j < 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int j = 0; j < i; j++)
            //        Console.Write(" ");

            //    Console.Write(" ");
            //    for (int j = 5+i; j > 1+i; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.Write(" ");
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if(i%2==0 && j%2==0)
            //        {
            //            Console.Write("1");
            //        }
            //        else if(i % 2 == 1 && j % 2 == 1)
            //        {
            //            Console.Write("1");
            //        }
            //        else
            //        {
            //            Console.Write("2");
            //        }

            //    }
            //    Console.Write(" ");

            //    for (int j = i; j <= i+3; j++)
            //    {
            //        for (int k = 0; k < j; k++)
            //        {
            //            Console.Write(j);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
