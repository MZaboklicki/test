using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Nagrywarka
    {
        private enum miejsceNagrywania { DVD,HDD };
        private enum stan { Wyłączone, Zatrzymanie, Nagrywanie, Odtwarzanie};

        private int aktualnyStan = 0;
        private int aktualneMiejsce = 0;

        public int Stan
        {
            get { return aktualnyStan; }
        }
        public int MiejsceNagrywania
        {
            get { return aktualneMiejsce; }
            set { aktualneMiejsce = value; }
        }
        public void Włącz()
        {
            if (aktualnyStan == 0)
                aktualnyStan = (int)stan.Zatrzymanie;
            else
                Console.WriteLine("Nagrywarak jest już włączona");
        }
        public void Odtwarzaj()
        {
            if (aktualnyStan == 1)
                aktualnyStan = (int)stan.Odtwarzanie;
            else
                Console.WriteLine("Nie można w tej chwili nic odtworzyc");
        }
        public void Nagrywaj()
        {
            if (aktualnyStan == 1)
                aktualnyStan = (int)stan.Nagrywanie;
            else
                Console.WriteLine("Nie można w tej chwili nic nagrać");
        }
        public void Zatrzymaj()
        {
            if (aktualnyStan == 2 || aktualnyStan==3)
                aktualnyStan = (int)stan.Zatrzymanie;
            else
                Console.WriteLine("Nagrywarka już zatrzymana, lub wyłączona");
        }
        public void AktualnyStan()
        {
            Console.WriteLine("Aktualny stan: "+ (stan)aktualnyStan);
        }
    
    public void AktualneMiejsce()
    {
        Console.WriteLine("Aktualne miejsce: " + (miejsceNagrywania)aktualneMiejsce);
    }
}
}
