using System;
using MiBiblioteca;

namespace Ejercicio05EnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluma pluma1 = new Pluma("Faber Castell", new Tinta(ConsoleColor.DarkRed, ETipoTinta.China), 1);
            Pluma pluma2 = new Pluma("BIC", new Tinta(ConsoleColor.Cyan,ETipoTinta.ConBrillito), 1);

            Console.WriteLine(pluma1);
            Console.WriteLine(pluma2);


        }
    }
}
