using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo figura1 = new Circulo(4);
            Circulo figura2 = new Circulo(2);

            Console.WriteLine("El area de figura1 es: " + figura1.calcularArea());
            Console.WriteLine("El perimetro de figura2 es: " + figura2.calcularPerimetro());
            Console.ReadKey();
        }
    }
}
