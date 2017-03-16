using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Zad6
    {
        private float population;
        private float growth;

        public Zad6 (float pop, float gro)
        {
            population = pop;
            growth = gro;
        }
        public void Grow()
        {
            population = population + (population * growth);
        }

        public float Population
        {
            get { return population; }
        }
    }
}
