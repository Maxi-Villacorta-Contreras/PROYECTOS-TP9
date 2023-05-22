using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Cuadrilátero
    {
        private int largo;
        private int alto;

        public Cuadrilátero(int largo, int alto)
        {
            this.largo = largo;
            this.alto = alto;
        }

        public int Largo
        {
            get { return largo; }
            set { largo = value; }
        }

        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        public int calcularPerimetro()
        {
            return 2 * (largo + alto);
        }

        public int calcularArea()
        {
            return largo * alto;
        }

        public bool esUnCuadrado()
        {
            return largo == alto;
        }
    }
}
