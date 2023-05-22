using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        /*
         * 
         * En un nuevo proyecto crear una clase de nombre Numero, con un atributo de tipo entero, un constructor que permita inicializar dicho atributo, los métodos getter y setter y los siguientes métodos adicionales:
         * 
         *  esPar: este método retornará true si el valor guardado en el atributo es par, caso contrario retornará false.
         *  esPositivo: este método retornará true si el valor guardado en el atributo es mayor o igual a cero, caso contrario retornará false.
         *  esMultiploDe: este método recibirá un valor por parámetro y retornará true si el valor guardado en el atributo es múltiplo del valor recibido, caso contrario retornará false.
         * 
         * Luego desde la clase principal del proyecto (la que contiene el método main) se pide:
         * 
         * a) Crear un objeto Numero con el valor 1459
         * b) Mostrar por consola si es par o no.
         * c) Mostrar por consola si es positivo o no.
         * d) Mostrar por consola si es múltiplo de 3.
         * 
         */
        static void Main(string[] args)
        {
            Numero numero = new Numero(1459);


            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.WriteLine("El numero es Par: " + numero.esPar());
            Console.WriteLine("El numero es positivo: " + numero.esPositivo());
            Console.WriteLine("El numero es Multiplo de 3: " + numero.esMultiploDe(3));

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");


            Console.ReadKey();
        }
    }
}