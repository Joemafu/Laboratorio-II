using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_01
{
    class Validador
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
    }
}
