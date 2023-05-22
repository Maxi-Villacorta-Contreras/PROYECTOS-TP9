using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Numero
    {
        private int num;

        public Numero(int numero)
        {
            this.num = numero;
        }

        public int Num
        {
            get { return num; }
            set { this.num = value; }
        }

        public bool esPar()
        {
            return num % 2 == 0;
        }

        public bool esPositivo()
        {
            return num >= 0;
        }

        public bool esMultiploDe(int divisor)
        {
            return num % divisor == 0;
        }
    }
}
