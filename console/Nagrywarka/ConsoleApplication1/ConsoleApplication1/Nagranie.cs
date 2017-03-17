using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Nagranie
    {
        private int nr;
        private DateTime data;
        private TimeSpan czasR;
        private TimeSpan czasZ;

        public Nagranie(int nr, DateTime date, TimeSpan r, TimeSpan z)
        {
            this.nr = nr;
            this.data = date;
            this.czasR = r;
            this.czasZ = z; 
        }

        #region Properties
        public int Nr
        {
            get { return nr; }
        }
        public DateTime Data
        {
            get { return data; }
        }
        public TimeSpan CzasR
        {
            get { return czasR; }
        }
        public TimeSpan CzasZ
        {
            get { return czasZ; }
        }

        #endregion
    }
}
