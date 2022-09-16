using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Biblioteca
{
    public class Tablas
    {
        public static string Multiplicar(int numero)
        {
            StringBuilder ret = new StringBuilder();
            int i;

            ret.AppendLine("Tabla de multiplicar del número " + numero + ":");

            for (i = 1; i < 10; i++)
            {
                ret.AppendLine(numero + " x " + i + " = " + numero * i);
            }

            return ret.ToString();
        }
    }
}
