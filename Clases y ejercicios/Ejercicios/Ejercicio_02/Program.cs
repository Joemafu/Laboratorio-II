using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Consigna:
            Ingresar un número y mostrar el cuadrado y el cubo del mismo.Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            Importante:
            Utilizar el método Pow de la clase Math para calcular las potencias.*/


            int numero;
            int cuadrado;
            int cubo;

            do
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero < 1);

            cuadrado = (int)Math.Pow(numero, 2);
            cubo = (int)Math.Pow(numero, 3);

            Console.WriteLine("\n\nEl cuadrado es {0}, el cubo es {1}", cuadrado, cubo);
        }

    }
}
