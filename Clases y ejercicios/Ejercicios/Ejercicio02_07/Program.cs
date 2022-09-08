using System;

namespace Ejercicio02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

            El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

            Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

            Mostrar el resultado en la consola. */
            #endregion

            double basee;
            double altura;
            do
            {
                Console.WriteLine("Base en cm: ");

            } while (!double.TryParse(Console.ReadLine(), out basee));

            do
            {
                Console.WriteLine("Altura en cm: ");

            } while (!double.TryParse(Console.ReadLine(), out altura));

            Console.WriteLine("La hipotenusa del tríangulo cuadrado descrito es de "+Math.Sqrt(Math.Pow(basee,2)+Math.Pow(altura,2)));
        }
    }
}
