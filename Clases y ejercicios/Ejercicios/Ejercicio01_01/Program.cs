using System;

namespace Ejercicio01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
            #endregion

            int numero;
            int max=0;
            int min=0;
            int acumulador=0;
            float promedio;

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;

                if (i==0 || numero < min)
                {
                    min = numero;
                    
                }
                if (i == 0 || numero > max)
                {
                    max = numero;
                }
            }
            promedio = (float)acumulador / 5;

            Console.WriteLine("\n\nEl máximo valor es {0}, el mínimo valor es {1} y el promedio de los ingresados es {2}", max, min, promedio);
        }
    }
}
