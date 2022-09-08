using System;

namespace Ejercicio02EnClase
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
