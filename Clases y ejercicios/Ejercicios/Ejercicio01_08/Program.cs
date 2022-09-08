using System;

namespace Ejercicio01_08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Escribir un programa que imprima por consola un triángulo como el siguiente:

            *
            ***
            *****
            *******
            *********

            El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.Para el ejemplo anterior, la altura ingresada fue de 5.
            
            Importante:
            Utilizar sentencias de iteración y selectivas.*/
            #endregion

            int altura;
            int i;
            int t;

            Console.WriteLine("Ingrese altura de la pirámide:");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= altura; i++)
            {
                for (t = 0; t < (2 * i - 1); t++)
                {
                    Console.Write("*");
                }
                t++;
                Console.Write("\n");
            }
        }
    }
}
