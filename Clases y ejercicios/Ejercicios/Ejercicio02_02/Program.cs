using System;
using Ejercicio02_Biblioteca;

namespace Ejercicio02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

            Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. */
            #endregion

            bool continuar;
            int acumulador = 0;
            int ingresado;
            do
            {
                Console.WriteLine("Ingrese un número: ");

                if(int.TryParse(Console.ReadLine(),out ingresado))
                {
                    acumulador += ingresado;
                    continuar = Validador.ValidarRespuesta();
                }
                else
                {
                    continuar = true;
                }
            } while(continuar);
            Console.WriteLine("El resultado de la suma de los numeros ingresados es " + acumulador);
        }
    }
}
