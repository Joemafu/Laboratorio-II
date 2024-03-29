﻿using System;
using System.Text;
using Ejercicio02_Biblioteca;

namespace Ejercicio02_05
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Consigna
            /*Crear una aplicación de consola que permita al usuario ingresar un número entero.

            Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

            Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

            Mostrar en la consola el resultado.

            Por ejemplo, si se ingresa el número 2 la salida deberá ser:*/
            #endregion

            int ingreso;

            do
            {
                Console.WriteLine("Ingrese un entero: ");

            } while (!int.TryParse(Console.ReadLine(), out ingreso));

            Console.WriteLine(Tablas.Multiplicar(ingreso));
        }
    }
}
