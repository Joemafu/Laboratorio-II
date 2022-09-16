using System;

namespace Ejercicio02_Biblioteca
{
    public class Validador
    {

        /// <summary>
        /// Validar numero dentro de un rango
        /// </summary>
        /// <param name="valor">dato a validar.</param>
        /// <param name="min">mínimo valor incluido. </param>
        /// <param name="max">máximo valor incluido.</param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool ret = false;

            if (valor < max && valor > min)
            {
                ret = true;
            }

            return ret;
        }

        public static bool ValidarRespuesta()
        {
            bool ret = false;

            Console.WriteLine("¿Desea continuar ? (S / N)");

            if (Console.ReadLine() == "S")
            {
                ret = true;
            }

            return ret;
        }
    }
}
