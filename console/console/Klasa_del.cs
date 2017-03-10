using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Klasa_del
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
}
