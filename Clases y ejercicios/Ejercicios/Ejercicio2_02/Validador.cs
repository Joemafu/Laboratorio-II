using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_02
{
    class Validador
    {
        public static bool ValidarRespuesta()
        {
            bool ret = false;

            Console.WriteLine("¿Desea continuar ? (S / N)");

            if (Console.ReadLine()=="S")
            {
                ret = true;
            }

            return ret;
        }
    }
}
