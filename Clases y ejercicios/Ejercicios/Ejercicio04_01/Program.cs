﻿using System;
using MiBiblioteca;

namespace Ejercicio04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(2);

            Console.WriteLine(sumador1 | sumador2);

            Console.WriteLine((int)sumador1);

            Console.WriteLine((int)sumador2);

            Console.WriteLine(sumador1 + sumador2);

            Console.WriteLine(sumador1.Sumar(1, 2));
            Console.WriteLine(sumador1.Sumar("una ", "frase"));

            Console.WriteLine(sumador1 | sumador2);

            Console.WriteLine(sumador1 + sumador2);
        }
    }
}
