using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_03
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int binario = 1;
            int contador = 1;
            string ret = "";

            while (numeroEntero >= binario * 2)
            {
                contador++;
                binario = binario * 2;
            }

            for (; contador > 0; contador--)
            {
                if (numeroEntero >= binario)
                {
                    ret += 1;
                    numeroEntero -= binario;
                } else
                {
                    ret += 0;
                }
                binario = binario / 2;
            }
            return ret;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int ret=0;
            string numString;
            int len;
            int i;
            int binario=1;

            numString = numeroEntero.ToString();

            len = numString.Length;

            for (i = 1; i < len; i++)
            {
                binario = binario * 2;
            }

            foreach (char item in numString)
            {
                if(item=='1')
                {                    
                    ret += binario;
                }
                binario = binario / 2;
            }

            return ret;
        }
    }
}
