using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Biblioteca
{
    public class Cosa
    {

        /*clase Cosa

        *-*-*-*-*-*-

        (-) entero:int

        (-) cadena:string

        (-) fecha:DateTime

        *-*-*-*-*-*-*-*-*-*-*

        (+) EstablecerValor(int) :void

        (+) EstablecerValor(string) :void

        (+) EstablecerValor(DateTime) :void

         *-*-*-*-*-*-*-*-*-*

        (-) Mostrar() :string -> de instancia

         (+) Mostrar(Cosa) :string -> de clase

        *-*-*-*-*-*-*-*-*-*

        (+) Cosa(DateTime, int, string)

        (+) Cosa(int, string)

        (+) Cosa(string)

        (+) Cosa()

        ---> en todos los casos la fecha por defecto debe ser la actual(a menos que se reciba por parámetro)

        ---> los valores predeterminados serán:

        10 -> int
        "sin valor" -> string
        'Now' -> DateTime*/


        private int entero;
        private string cadena;
        private DateTime fecha;

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Entero: {this.entero}");
            sb.AppendLine($"Cadena: {this.cadena}");
            sb.AppendLine($"Fecha: {this.fecha.ToShortDateString()}");

            return sb.ToString();
        }

        public static string Mostrar(Cosa cosa)
        {
            return cosa.Mostrar();
        }

        public Cosa()
        {
            this.EstablecerValor(10);
            this.EstablecerValor("sin valor");
            this.EstablecerValor(DateTime.Now);
        }
        public Cosa(string cadena) : this()
        {
            this.EstablecerValor(cadena);
        }
        public Cosa(int entero, string cadena) : this(cadena)
        {
            this.EstablecerValor(entero);
        }
        public Cosa(DateTime fecha, int entero, string cadena) : this(entero, cadena)
        {
            this.EstablecerValor(fecha);
        }
    }
}
