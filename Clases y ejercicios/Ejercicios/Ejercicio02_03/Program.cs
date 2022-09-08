using System;

namespace Ejercicio02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Desarollar una clase llamada Conversor que posea dos métodos de clase(estáticos):

            El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

            public string ConvertirDecimalABinario(int numeroEntero) { }

            El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

            public int ConvertirBinarioADecimal(int numeroEntero) { }

            Importante:
            NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.*/
            #endregion

            int ingresado;

            Console.WriteLine("Ingrese un numero decimal: ");
            if (int.TryParse(Console.ReadLine(), out ingresado))
            {
                Console.WriteLine(Conversor.ConvertirDecimalABinario(ingresado));
            }

            Console.WriteLine("Ingrese un numero binario: ");
            if (int.TryParse(Console.ReadLine(), out ingresado))
            {
                Console.WriteLine(Conversor.ConvertirBinarioADecimal(ingresado));
            }            
        }
    }
}
