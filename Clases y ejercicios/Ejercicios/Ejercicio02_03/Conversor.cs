using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_03
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int valorBinario = 1;
            int contador = 1;
            string ret = "";

            while (numeroEntero >= valorBinario * 2)
            {
                contador++;
                valorBinario = valorBinario * 2;
            }

            for (; contador > 0; contador--)
            {
                if (numeroEntero >= valorBinario)
                {
                    ret += 1;
                    numeroEntero -= valorBinario;
                } else
                {
                    ret += 0;
                }
                valorBinario = valorBinario / 2;
            }
            return ret;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int ret=0;
            string numString;
            int len;

            numString = numeroEntero.ToString();

            len = numString.Length;

            foreach (char item in numString)
            {
                if(item=='1')
                {
                    ret += (int)Math.Pow(2, len-1);
                }
                len--;
            }

            return ret;
        }
    }
}
