﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Biblioteca
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            int i;
            int j = mensaje.Length + 2;
            string ret = "";
            string borde = "";

            for (i = 0; i < j; i++)
            {
                borde += ("*");
            }

            ret += (borde + "\n*" + Sello.mensaje + "*\n" + borde);

            return ret;
        }
    }
}
