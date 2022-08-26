using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_08
{
    class Fecha
    {
        public static void CalcularDiasTranscurridos ()
        {
            DateTime fechaDeHoy;
            DateTime fechaIngresada;
            int aux;
            bool error=false;

            StringBuilder sb = new StringBuilder();

            fechaDeHoy = DateTime.Today;

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

            aux = 0;

            Console.WriteLine("La fecha ingresada es " + fechaIngresada);

            do
            {
                aux++;
                fechaIngresada=fechaIngresada.AddDays(1);
            } while (fechaIngresada < fechaDeHoy);
            
            Console.WriteLine("\nHan pasado " + aux + " días desde entonces.");
        }
    }
}
