using System;

namespace Ejercicio2_01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());
        }
    }
}
