using System;
using Ejercicio10_Biblioteca;

namespace Ejercicio10_EnClase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            try
            {
                test.MetodoUno();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
