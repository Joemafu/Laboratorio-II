using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
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

        static Euro()
        {
            Euro.cotzRespectoDolar = 1 / 1.17;
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
            return new Euro(e.cantidad - ((Euro)d).cantidad);
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
