using System;
using Ejercicio03_Biblioteca;

namespace Ejercicio03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

            Deberá tener los atributos:

                titular que contendrá la razón social del titular de la cuenta.
                cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.

            Construir los siguientes métodos para la clase:

                Un constructor que permita inicializar todos los atributos.
                Un método getter para cada atributo.
                mostrar retornará una cadena de texto con todos los datos de la cuenta.
                ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
                retirar recibirá un monto para debitar de la cuenta.La cuenta puede quedar en negativo. 

            En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/
            #endregion

            Cuenta cuentita = new Cuenta("Jose", 65.65);   // = 65.65

            Console.WriteLine(cuentita.Mostrar());

            cuentita.Ingresar(34.35);   // = 100.00
            Console.WriteLine(cuentita.Mostrar());

            cuentita.Ingresar(50.50);   // = 150.50
            Console.WriteLine(cuentita.Mostrar());

            cuentita.Retirar(50.50);   // = 100.00
            Console.WriteLine(cuentita.Mostrar());

            cuentita.Retirar(80.50);   // = 19.50
            Console.WriteLine(cuentita.Mostrar());

            cuentita.Retirar(80.50);   // = -61
            Console.WriteLine(cuentita.Mostrar());

            cuentita.Ingresar(-666.66);   // Ingreso de numero negativo no válido = 100.00
            Console.WriteLine(cuentita.Mostrar());
        }
    }
}
