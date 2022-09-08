using System;

namespace Ejercicio01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

            El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.

            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

            Importante:
            Utilizar sentencias de iteración y selectivas.*/
            #endregion

            int ingresado;
            int i;
            int t;
            int acumulador;
            int acumulador2;
            int incrementado;
            bool flag = false;

            Console.WriteLine("Ingrese un numero:");
            while (!int.TryParse(Console.ReadLine(), out ingresado))
            {
                Console.WriteLine("No se ingresó un número válido.");
            }
            for (i = 1; i <= ingresado; i++)
            {
                acumulador = 0;

                for (t = 1; t < i; t++)
                {
                    acumulador += t;
                }
                incrementado = i + 1;
                acumulador2 = incrementado;
                while (acumulador > acumulador2)
                {
                    incrementado++;
                    acumulador2 += incrementado;
                }
                if (acumulador == acumulador2)
                {
                    flag = true;
                    Console.WriteLine("El numero {0} es un centro numerico.\n", i);
                }
            }
            if (flag == true)
            {
                Console.WriteLine("No hay mas centros numericos antes del {0}", ingresado);
            }
            else
            {
                Console.WriteLine("No hay centros numericos antes del {0}", ingresado);
            }
        }
    }
}
