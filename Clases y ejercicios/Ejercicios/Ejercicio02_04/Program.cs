using System;
using Ejercicio02_Biblioteca;

namespace Ejercicio02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta, multiplicación y división).

            Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):

            Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.El método devolverá el resultado de la operación.

            Validar(privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.Este método devolverá true si el operando es distinto de cero.

            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar(ingresando el caracter +, -, *o /).

            El usuario decidirá cuándo finalizar el programa.*/
            #endregion

            float operando1;
            float operando2;
            string operacion;
            string continuar;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese primer operando: ");

                } while (!float.TryParse(Console.ReadLine(), out operando1));

                do
                {
                    Console.WriteLine("Ingrese segundo operando: ");

                } while (!float.TryParse(Console.ReadLine(), out operando2));

                do
                {
                    Console.WriteLine("Ingrese operación: ");
                    operacion = Console.ReadLine();

                } while (operacion != "+" && operacion != "-" && operacion != "*" && operacion != "/");

                Console.WriteLine("El resultado es " + Calculadora.Calcular(operando1, operando2, operacion));

                Console.WriteLine("Desea realizar otra operacion? (S/N): ");
                continuar = Console.ReadLine();
            } while (continuar == "S");
        }
    }
}
