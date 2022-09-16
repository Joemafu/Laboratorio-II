using System;
using Ejercicio02_Biblioteca;

namespace Ejercicio02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna 
            /*El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.*/
            #endregion

            int entero;
            do
            {
                Console.WriteLine("Ingrese número a calcular el factorial: ");

            } while (!int.TryParse(Console.ReadLine(), out entero) || entero < 0);

            Console.WriteLine("El factorial de " + entero + " es " + Factorial.CalcularFactorial(entero));
        }
    }
}
