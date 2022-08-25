using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_09
{
    class Factorial
    {
        public static int CalcularFactorial(int entero)
        {
            int ret=1;
            int i;

            for(i=2;i<=entero;i++)
            {
                ret = ret * i;
            }

            return ret;
        }
    }
}
