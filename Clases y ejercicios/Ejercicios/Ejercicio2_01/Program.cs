using System;

namespace Ejercicio2_01
{
    class Program
    {
        static void Main(string[] args)
        {
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
