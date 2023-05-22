using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("****Menu***");
                Console.WriteLine("1-Primera opcion");
                Console.WriteLine("2-Primera opcion");
                Console.WriteLine("3-Primera opcion");
                Console.WriteLine("4- Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Usted selecciono la opcion 1");
                        break;
                    case 2:
                        Console.WriteLine("Usted selecciono la opcion 2");
                        break;
                    case 3:
                        Console.WriteLine("Usted selecciono la opcion 3");
                        break;
                    case 4:
                        Console.WriteLine("Usted seleccio la opcion salir 4");
                        break;
                    default:
                        Console.WriteLine("No existe la opcion seleccionada");
                        break;
                }

            } while (opcion != 4);
            Console.ReadKey();
        }
    }
}
