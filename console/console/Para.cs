using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    //typ parametryczny, w zależności od typu podanych arg będzie działał inaczej
    class Para<A,B>: IComparable<Para<A,B>>
        where A:IComparable
        where B:IComparable
    {
        private A zm1= default(A);
        private B zm2 = default(B);

        public Para(A arg1, B arg2)
        {
            this.zm1 = arg1;
            this.zm2 = arg2;
        }
        public void Print()
        {
            Console.WriteLine(zm1.ToString() + "  " + zm2.ToString());
        }
        public int CompareTo(Para<A,B> innapara)
        {
            int wynik = this.zm1.CompareTo(innapara.zm1);
            if (wynik != 0) return wynik;
            else
                wynik = this.zm2.CompareTo(innapara.zm2);
            return wynik;
        }
    }
}
