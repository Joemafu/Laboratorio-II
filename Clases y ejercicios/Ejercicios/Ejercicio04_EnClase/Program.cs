using System;
using MiBiblioteca;

namespace Ejercicio04_EnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main()

            //Testear todos los Constructores y Métodos de Cosa.

            DateTime fecha = new DateTime(1992, 06, 23);

            Cosa cosa1 = new Cosa();
            Cosa cosa2 = new Cosa("Hola mundo!");
            Cosa cosa3 = new Cosa(5,"Hola C#!");
            Cosa cosa4 = new Cosa(fecha, 6, "Constructor completo");

            Console.WriteLine(Cosa.Mostrar(cosa1));
            Console.WriteLine(Cosa.Mostrar(cosa2));
            Console.WriteLine(Cosa.Mostrar(cosa3));
            Console.WriteLine(Cosa.Mostrar(cosa4));
        }
    }
}