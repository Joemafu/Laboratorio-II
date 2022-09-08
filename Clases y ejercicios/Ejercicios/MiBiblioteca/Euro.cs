using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 1/1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            Euro.cotzRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.cotzRespectoDolar);
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)(Dolar)e;
        }

        public double GetCantidad()
        {
            return Math.Round(this.cantidad, 2);
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro (e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.cantidad == ((Euro)d).cantidad;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e.cantidad == ((Euro)p).cantidad;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
    }
}
