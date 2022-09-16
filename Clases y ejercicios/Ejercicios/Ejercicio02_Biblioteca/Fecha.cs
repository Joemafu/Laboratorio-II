using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Biblioteca
{
    public class Fecha
    {
        public static void CalcularDiasTranscurridos(DateTime fechaIngresada)
        {
            int aux = 0;
            DateTime fechaDeHoy = DateTime.Today;

            Console.WriteLine("La fecha ingresada es " + fechaIngresada);

            do
            {
                aux++;
                fechaIngresada = fechaIngresada.AddDays(1);
            } while (fechaIngresada < fechaDeHoy);

            Console.WriteLine("\nHan pasado " + aux + " días desde entonces.");
        }
    }
}
