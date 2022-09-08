using System;

namespace Ejercicio02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase(estáticos) que realicen el cálculo del área que corresponda:

            public double CalcularAreaCuadrado(double longitudLado) { }

            public double CalcularAreaTriangulo(double base, double altura) { }

            public double CalcularAreaCirculo(double radio) { }

            El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
            #endregion

            int ingreso;
            double lado;
            double altura;

            do
            {
                Console.WriteLine("Elija una figura para calcular su área:\n1.Cuadrado\n2.Triángulo\n3.Círculo");

            } while (!int.TryParse(Console.ReadLine(), out ingreso)||ingreso>3||ingreso<1);

            switch(ingreso)
            {
                case 1:
                    {
                        do
                        {
                            Console.WriteLine("Largo del lado: ");

                        } while (!double.TryParse(Console.ReadLine(), out lado));

                        Console.WriteLine("El área del cuadrado es "+CalculadoraDeArea.CalcularAreaCuadrado(lado));
                        break;
                    }
                case 2:
                    {
                        do
                        {
                            Console.WriteLine("Base del triángulo: ");

                        } while (!double.TryParse(Console.ReadLine(), out lado)); 
                        do
                        {
                            Console.WriteLine("Altura del triángulo: ");

                        } while (!double.TryParse(Console.ReadLine(), out altura));

                        Console.WriteLine("El área del triángulo es " + CalculadoraDeArea.CalcularAreaTriangulo(lado,altura));
                        break;
                    }
                case 3:
                    {
                        do
                        {
                            Console.WriteLine("Radio del círculo: ");

                        } while (!double.TryParse(Console.ReadLine(), out lado));

                        Console.WriteLine("El área del círculo es " + CalculadoraDeArea.CalcularAreaCirculo(lado));
                        break;
                    }
            }
        }
    }
}
