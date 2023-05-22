using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        /*
         * En un nuevo proyecto crear una clase de nombre Cuadrilátero con los atributos largo y alto, un constructor que permita inicializar dichos atributos, sus respectivos getter y setter y los siguientes métodos adicionales:
         * 
         *  calcularPerimetro(): este método retornará el perímetro del cuadrilátero.
         *  calcularArea(): este método retornará la superficie del cuadrilátero.
         *  esUnCuadrado(): este método retornará true si este cuadrilátero es un cuadrado, caso contrario retornará false.
         * 
         * Luego desde la clase principal del proyecto (la que contiene el método main) se pide:
         * 
         * a) Crear un objeto Cuadrilatero con largo 70 y altura 50;
         * 
         * Luego utilizando sus métodos:
         * 
         * b) Mostrar por consola su perímetro
         * c) Mostrar por consola su superficie.
         * d) Mostrar por consola si es un cuadrado o no.
         * e) Cambiar el estado de uno de sus atributos para que sea un cuadrado.
         */

        static void Main(string[] args)
        {
            Cuadrilátero cuadrilatero = new Cuadrilátero(70, 50);

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.WriteLine("El Cuadrilátero tiene 70 de largo y 50 de alto\n\n");
            Console.WriteLine("El Perímetro del Cuadrilátero es: " + cuadrilatero.calcularPerimetro());
            Console.WriteLine("La superficie del Cuadrilátero es: " + cuadrilatero.calcularArea());
            Console.WriteLine("¿ El Cuadrilátero es un Cuadrado ? = " + cuadrilatero.esUnCuadrado());

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            cuadrilatero.Largo = 50;

            Console.WriteLine("\nEl Cuadrilátero tiene 50 de largo y 50 de alto\n\n");

            Console.WriteLine("¿ El Cuadrilátero es un Cuadrado ? = " + cuadrilatero.esUnCuadrado());

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");


            Console.ReadKey();
        }
    }
}