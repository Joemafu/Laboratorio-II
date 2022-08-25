using System;

namespace Ejercicio2_01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Consigna:
            Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

                        bool Validar(int valor, int min, int max)

                valor: dato a validar.
                min: mínimo valor incluido.
                max: máximo valor incluido.

            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango - 100 y 100.

            Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
            
            Importante:
            Utilizar variables escalares, NO utilizar vectores/ arrays.*/

            int i;
            bool entradaValida;
            int entrada;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            float promedio;
            bool flag = false;

            for (i=1;i<11;i++)
            {

                do
                {
                    Console.WriteLine("Ingrese un número: (" + i +  ")");
                    entradaValida = int.TryParse(Console.ReadLine(), out entrada);
                } while (!entradaValida || !Validador.Validar(entrada, -100, 100));

                acumulador += entrada;

                if (flag == false || entrada < min)
                {
                    min = entrada;

                }
                if (flag == false || entrada > max)
                {
                    max = entrada;
                }
                flag = true;


            }

            promedio = (float)acumulador / 10;

            Console.WriteLine("\n\nEl máximo valor es {0}, el mínimo valor es {1} y el promedio de los ingresados es {2}", max, min, promedio);
        }
    }
}
