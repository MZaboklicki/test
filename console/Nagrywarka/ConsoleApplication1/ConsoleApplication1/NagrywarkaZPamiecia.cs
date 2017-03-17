using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NagrywarkaZPamiecia : Nagrywarka
    {
        List<Nagranie> nagrania = new List<Nagranie>(0);
        private int nr = 0;
        public void DodajNagranie()
        {
            this.nr++;
            DateTime date = DateTime.Now;
            TimeSpan time = DateTime.Now.TimeOfDay;
            System.Threading.Thread.Sleep(3000);
            TimeSpan endTime= DateTime.Now.TimeOfDay;
            Nagranie noweNagranie = new Nagranie(this.nr,date,time,endTime);
            nagrania.Add(noweNagranie);
            Console.WriteLine("Zakończono nagrywanie");
        }

        public void UsunNagranie( int num)
        {
            foreach(Nagranie nagranie in nagrania)
            {
                if(nagranie.Nr == num)
                {
                    nagrania.Remove(nagranie);
                    Console.WriteLine("Usunięto");
                    break;
                }
            }
            
        }
        public void WyswietlNagrania()
        {
            foreach (Nagranie nagranie in nagrania)
            {
                
                    Console.WriteLine("Nagranie nr: "+nagranie.Nr+"; data: "+nagranie.Data+"; czas rozp: "+nagranie.CzasR.Hours+":"+ nagranie.CzasR.Minutes+ ":" + nagranie.CzasR.Seconds + "; czas zak: " + nagranie.CzasZ);
            }

        }
    }
}
