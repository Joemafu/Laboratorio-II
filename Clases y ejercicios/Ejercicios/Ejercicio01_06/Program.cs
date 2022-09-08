using System;

namespace Ejercicio01_06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Escribir un programa que determine si un año es bisiesto.

            Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            
            Importante:
            Utilizar sentencias de iteración, selectivas y el operador módulo(%).*/
            #endregion

            int anioMin;
            int anioMax;
            int anioMinAux;
            bool flag = false;
            Console.WriteLine("Ingrese un año minimo: ");
            anioMin = Convert.ToInt32(Console.ReadLine());
            anioMinAux = anioMin;
            Console.WriteLine("Ingrese un año maximo: ");
            anioMax = Convert.ToInt32(Console.ReadLine());

            for (; anioMin <= anioMax; anioMin++)
            {
                if ((anioMin % 400 == 0) || (anioMin % 4 == 0 && anioMin % 100 != 0))
                {
                    if (flag == false)
                    {
                        Console.WriteLine("Los años bisiestos entre {0} y {1} son: ", anioMinAux, anioMax);
                    }
                    flag = true;
                    Console.WriteLine("{0}", anioMin);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("No hay años bisiestos entre los seleccionados.");
            }
        }
    }
}
