using System;

namespace Ejercicio01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.
            
            Importante:
            Utilizar sentencias de iteración, selectivas y el operador módulo(%).*/
            #endregion

            string ingresadoString;
            int ingresadoInt;
            int i;
            bool primo = true;
            int t;
            bool parseado;
            bool incorrecto;
            string respuesta;

            do
            {
                incorrecto = true;
                Console.WriteLine("Ingrese un numero:");

                ingresadoString = Console.ReadLine();

                if (ingresadoString == "salir")
                {
                    break;
                } else
                {
                    parseado = int.TryParse(ingresadoString, out ingresadoInt);
                }

                if (parseado)
                {
                    Console.WriteLine("Los numeros primos del 1 al {0} son:", ingresadoInt);

                    for (i = 2; i <= ingresadoInt; i++)
                    {
                        for (t = 2; t < (i - 1); t++)
                        {
                            if (i % t == 0)
                            {
                                primo = false;
                                break;
                            }
                        }
                        if (primo == true)
                        {
                            Console.WriteLine(i);
                        }
                        primo = true;
                    }
                    do
                    {
                        Console.WriteLine("Desea continuar? Y/N");
                        respuesta = Console.ReadLine();

                        if (respuesta == "Y")
                        {
                            parseado = false;
                            incorrecto = false;
                        }
                        else if (respuesta == "N")
                        {
                            incorrecto = false;
                        }

                    } while (incorrecto);
                }

            } while (!parseado);
                        
        }
    }
}
