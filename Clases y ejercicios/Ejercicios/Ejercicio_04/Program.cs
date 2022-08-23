using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Consigna:
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo) que son divisores del número.

            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            Escribir una aplicación que encuentre los 4 primeros números perfectos.

            Importante:
            Utilizar sentencias de iteración y selectivas.*/

            int i;
            int t;
            int acumulador;
            int contador = 0;

            Console.WriteLine("Los primeros 4 numeros perfectos son:");

            for (i = 1; contador < 4; i++)
            {
                acumulador = 0;
                for (t = 1; t < i; t++)
                {
                    if (i % t == 0)
                    {
                        acumulador += t;
                    }
                }
                if (acumulador == i)
                {
                    Console.Write("{0}. ", i);

                    contador++;
                }
            }

            //    VERSION QUE BUSCA NUMEROS PERFECTOS DESDE EL 1 HASTA EL QUE EL USUARIO INDIQUE.

            //    int ingresado;
            //    int i;
            //    int t;
            //    int acumulador;
            //    bool flag = false;

            //    Console.WriteLine("Ingrese un numero:");
            //    ingresado = Convert.ToInt32(Console.ReadLine());

            //    for (i = 1; i <= ingresado; i++)
            //    {
            //        acumulador = 0;
            //        for (t = 1; t < i; t++)
            //        {
            //            if (i % t == 0)
            //            {
            //                acumulador += t;
            //            }
            //        }
            //        if (acumulador == i)
            //        {
            //            Console.WriteLine("El numero {0} es un numero perfecto.\n", i);
            //            flag = true;
            //        }
            //    }
            //    if (flag == true)
            //    {
            //        Console.WriteLine("No hay mas numeros perfectos antes del {0}", ingresado);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No hay numeros perfectos antes del {0}", ingresado);
            //    }
            //    Console.ReadLine();
        }
    }
}
