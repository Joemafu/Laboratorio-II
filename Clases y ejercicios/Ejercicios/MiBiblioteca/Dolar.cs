using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Consigna:
        /*Crear un proyecto de tipo biblioteca de clases.Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dolar.

            https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/diagramaConversor-32ee7e2889ce0f22f6c006523ef93e25.png

        Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.
        
        tip:
        Para operar dos tipos de monedas distintos, primero se deberá convertir todo a una misma moneda y luego realizar la operación.Por ejemplo, si quiero sumar Dolar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.

          El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

          Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.

          Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.

          Los operadores de comparación == compararán cantidades.


          Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.

          Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.*/
        #endregion

        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }

        public double GetCantidad()
        {
            return Math.Round(this.cantidad,2);
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == ((Dolar)e).cantidad;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == ((Dolar)p).cantidad;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
    }
}
