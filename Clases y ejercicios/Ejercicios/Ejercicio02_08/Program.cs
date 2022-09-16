using System;
using System.Text;
using Ejercicio02_Biblioteca;

namespace Ejercicio02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

            Pedir por consola la fecha de nacimiento de una persona(día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

            Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.*/
            #endregion

            DateTime fechaDeHoy = DateTime.Today;
            DateTime fechaIngresada;
            int aux;
            bool error = false;

            StringBuilder sb = new StringBuilder();

            do
            {
                if (error)
                {
                    Console.WriteLine("Fecha inválida!");
                }
                do
                {
                    Console.WriteLine("Ingrese día: ");

                } while (!int.TryParse(Console.ReadLine(), out aux) || aux > 31 || aux < 1);

                sb.Append(aux + "/");

                do
                {
                    Console.WriteLine("Ingrese mes: ");

                } while (!int.TryParse(Console.ReadLine(), out aux) || aux > 12 || aux < 1);

                sb.Append(aux + "/");

                do
                {
                    Console.WriteLine("Ingrese año: ");

                } while (!int.TryParse(Console.ReadLine(), out aux));

                sb.Append(aux + " 00:00:00 AM");

                Console.Clear();

                error = !DateTime.TryParse(sb.ToString(), out fechaIngresada) || fechaIngresada > fechaDeHoy;

            } while (error);

            Fecha.CalcularDiasTranscurridos(fechaIngresada);
        }
    }
}
