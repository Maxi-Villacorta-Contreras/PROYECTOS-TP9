using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letra
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Ingrese un caracter: ");
            letra = char.Parse(Console.ReadLine());

            switch(letra)
            {
                case 'a': Console.WriteLine("El caracter es una vocal y es la a");
                    break;
                case 'e': Console.WriteLine("El caracter es una vocal y es la e");
                    break;
                case 'i': Console.WriteLine("El caracter es una vocal y es la i");
                    break;
                case 'o': Console.WriteLine("El caracter es una vocal y es la o");
                    break;
                case 'u': Console.WriteLine("El caracter es una vocal y es la u");
                    break;
                default:
                    Console.WriteLine("El caracter ingresado no es una vocal");
                    break;
            }
            Console.ReadKey();
        }
    }
}
