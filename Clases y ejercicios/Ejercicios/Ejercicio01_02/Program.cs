using System;

namespace Ejercicio01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Ingresar un número y mostrar el cuadrado y el cubo del mismo.Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            Importante:
            Utilizar el método Pow de la clase Math para calcular las potencias.*/
            #endregion

            float numero;
            float cuadrado;
            float cubo;

            Console.WriteLine("Ingrese un número:");

            do
            {
                numero = float.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero <= 0);

            cuadrado = (float)Math.Pow(numero, 2);
            cubo = (float)Math.Pow(numero, 3);

            Console.WriteLine("\n\nEl cuadrado es {0}, el cubo es {1}", cuadrado, cubo);
        }

    }
}
