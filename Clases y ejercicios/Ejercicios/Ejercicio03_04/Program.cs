using System;
using Ejercicio03_Biblioteca;

namespace Ejercicio03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Agregar un proyecto de consola.
            En el método Main, crear un bolígrafo de tinta azul(ConsoleColor.Blue) y una cantidad inicial de tinta de 100 y otro de tinta roja(ConsoleColor.Red) y 50 de tinta.
            Utilizar todos los métodos y mostrar los resultados por consola.
            Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.*/
            #endregion

            string dibujo;

            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);


            Console.WriteLine($"Dibujando en boligrafo {boligrafo1.GetColor()} con {boligrafo1.GetTinta()} de tinta:");
            if (!boligrafo1.Pintar(55, out dibujo))
            {
                Console.WriteLine("No alcanzó la tinta :(");
            }
            Console.ForegroundColor = boligrafo1.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor();

            Console.WriteLine($"Dibujando en boligrafo {boligrafo2.GetColor()} con {boligrafo2.GetTinta()} de tinta:");
            if (!boligrafo2.Pintar(51, out dibujo))
            {
                Console.WriteLine("No alcanzó la tinta :(");
            }
            Console.ForegroundColor = boligrafo2.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor();

            Console.WriteLine($"Boligrafo {boligrafo1.GetColor()} tiene {boligrafo1.GetTinta()} de tinta:");

            Console.WriteLine($"Recargando tinta al 100:");

            boligrafo1.Recargar();

            Console.WriteLine($"Boligrafo {boligrafo1.GetColor()} tiene {boligrafo1.GetTinta()} de tinta:");
        }
    }
}
