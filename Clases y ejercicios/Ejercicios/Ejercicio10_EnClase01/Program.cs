using System;
using Ejercicio10_Biblioteca;

namespace Ejercicio10_EnClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int entero;
            Console.WriteLine("Ingrese un número: ");
            str = Console.ReadLine();

            if(NumeroEntero.TryParse(str, out entero))
            {
                Console.WriteLine("Se parseó con éxito");
            }
            else
            {
                Console.WriteLine("Los datos ingresados no son numéricos.");
            }
        }
    }
}
