using System;

namespace Ejercicio10_Biblioteca
{
    public class NumeroEntero
    {
        public static bool TryParse (string cadena, out int entero)
        {
            bool ret = true;
            entero = -1;

            try
            {
                entero=int.Parse(cadena);
            }
            catch (Exception)
            {
                ret = false;
            }

            return ret;
        }
    }
}
