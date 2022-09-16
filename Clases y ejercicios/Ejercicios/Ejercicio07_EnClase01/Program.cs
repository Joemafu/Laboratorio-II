using System;
using Clase07_Biblioteca;

namespace Ejercicio07_EnClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna:
            /*En el Main

            Crear 4 temperas:

            1) Red-Alba-50

            2) Blue-Alba-50

            3) Red-Alba-25

            4) Black-Pinturita-50

            5) Green-Temperita-50

            Comparar (temperas):

            1) == 2)

            1) == 3)

            1) == 4)

            1) == null

            null == 1)

            Sumar (temperas):

            1) + 2)

            1) + 3)

            1) + 4)

            1) + null

            Sumar (temperas):

            1) + 20

            2) + 30

            Crear paleta:

            Máximo 3 temperas

            Comparar (paleta - tempera)

            p == 1)

            Sumar (paleta - tempera)

            p + 1)

            p + 2)

            p + 3)

            p + 4)

            p + 5)

            Restar (paleta - tempera)

            p - 1)

            p - 2)

            p - 5)

            Crear otra paleta:

            Máximo 2 temperas

            Sumar (paleta - tempera)

            p + 5)

            p + 4)

            p + 3)

            p + 2)

            Sumar (paleta - paleta)



            NOTA: luego de cada comparación, suma o resta, mostrar el contenido completo de la tempera o paleta, según corresponda.*/
            #endregion

            Tempera t1 = new Tempera(ConsoleColor.Red,"Alba",50);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera t4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Temperita", 50);

            Console.WriteLine("--------------------5 temperas inicializadas-------------------");
            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine(Tempera.Mostrar(t2));
            Console.WriteLine(Tempera.Mostrar(t3));
            Console.WriteLine(Tempera.Mostrar(t4));
            Console.WriteLine(Tempera.Mostrar(t5));

            Console.WriteLine("--------------------tempera 1 es igual a tempera 2-------------------");
            Console.WriteLine(t1 == t2);
            Console.WriteLine("--------------------tempera 1 es igual a tempera 3-------------------");
            Console.WriteLine(t1 == t3);
            Console.WriteLine("--------------------tempera 1 es igual a tempera 4-------------------");
            Console.WriteLine(t1 == t4);
            Console.WriteLine("--------------------tempera 1 es igual a null-------------------");
            Console.WriteLine(t1 == null);
            Console.WriteLine("--------------------null es igual a tempera 1-------------------");
            Console.WriteLine(null == t1);

            Console.WriteLine("--------------------sumo todas las temperas a tempera 1-------------------");

            t1 += t2;
            t1 += t3;
            t1 += t4;
            t1 += null;

            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine(Tempera.Mostrar(t2));
            Console.WriteLine(Tempera.Mostrar(t3));
            Console.WriteLine(Tempera.Mostrar(t4));
            Console.WriteLine(Tempera.Mostrar(t5));
            Console.WriteLine("--------------------sumo 20 a tempera 1 y 30 a tempera 2-------------------");

            t1 += 20;
            t2 += 30;

            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine(Tempera.Mostrar(t2));
            Console.WriteLine(Tempera.Mostrar(t3));
            Console.WriteLine(Tempera.Mostrar(t4));
            Console.WriteLine(Tempera.Mostrar(t5));

            Paleta p = (Paleta)3;

            Console.WriteLine("--------------------creo una paleta vacia, contiene tempera 1?-------------------");
            Console.WriteLine(p == t1);
            Console.WriteLine("--------------------sumo todas las temperas a la paleta-------------------");

            p += t1;
            p += t2;
            p += t3;
            p += t4;
            p += t5;

            Console.WriteLine((string)p);
            Console.WriteLine("--------------------resto temperas 1 2 y 5 a la paleta-------------------");

            p -= t1;
            p -= t2;
            p -= t5;

            Console.WriteLine((string)p);
            Console.WriteLine("--------------------creo paleta 2 y agrego temperas al reves 5,4,3,2,1-------------------");

            Paleta p2 = (Paleta)2;

            p2 += t5;
            p2 += t4;
            p2 += t3;
            p2 += t2;
            p2 += t1;

            Console.WriteLine((string)p2);
            Console.WriteLine("--------------------sumo paleta 2 a paleta 1-------------------");

            p += p2;

            Console.WriteLine((string)p);
            Console.WriteLine("--------------------creo paleta 3 y agrego temperas 1,2,3,4,5-------------------");

            Paleta p3 = 5;

            p3 += t1; //vacio, no se agrega
            p3 += t2;
            p3 += t3;
            p3 += t4;
            p3 += t5;

            Console.WriteLine((string)p3);
            Console.WriteLine("------------------intento mostrar tempera en posición fuera de rango---------------------");
            Console.WriteLine(Tempera.Mostrar(p3[-1]));
            Console.WriteLine("------------------intento mostrar tempera en posición fuera de rango---------------------");
            Console.WriteLine(Tempera.Mostrar(p3[5]));

            Console.WriteLine("------------------piso tempera 1---------------------");
            p3[0] = new Tempera(ConsoleColor.Black, "sadsasd", 100);
            
            Console.WriteLine((string)p3);
            Console.WriteLine("------------------muestro tempera 1 con indexador---------------------");
            Console.WriteLine(Tempera.Mostrar(p3[0]));
            p3[-5] = t2;
        }
    }
}
