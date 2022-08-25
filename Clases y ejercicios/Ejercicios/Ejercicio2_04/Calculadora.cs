using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_04
{
    class Calculadora
    {
        public static float Calcular(float operando1, float operando2, string operacion)
        {
            float ret=0;

            switch (operacion)
            {
                case "+":
                    {
                        ret = operando1 + operando2;
                        break;
                    }
                case "-":
                    {
                        ret = operando1 - operando2;
                        break;
                    }
                case "*":
                    {
                        ret = operando1 * operando2;
                        break;
                    }
                case "/":
                    {
                        if(Validar(operando2))
                        {
                            ret = operando1 / operando2;
                        }
                        break;
                    }
            }
            return ret;
        }

        private static bool Validar(float operando2)
        {
            bool ret = false;

            if (operando2!=0)
            {
                ret = true;
            }

            return ret;
        }
    }
}
