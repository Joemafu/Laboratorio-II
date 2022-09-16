using System;
using Geometria;

namespace Ejercicio03_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Punto p1 = new Punto(1, 1);
            Punto p2 = new Punto(3, 2);


            Rectangulo rec = new Rectangulo(p1,p2);

            Console.WriteLine(Rectangulo(rec));
        }

        private static string Rectangulo(Rectangulo rec)
        {
            return $"Area del rectangulo {rec.Area()}\nPerímetro del rectangulo {rec.Perimetro()}";
        }
    }
}