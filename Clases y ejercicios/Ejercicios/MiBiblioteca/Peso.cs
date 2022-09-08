using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
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

        static Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            Peso.cotzRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.cotzRespectoDolar);
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)(Dolar)p;
        }

        public double GetCantidad()
        {
            return Math.Round(this.cantidad, 2);
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.cantidad == ((Peso)d).cantidad;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p.cantidad == ((Peso)e).cantidad;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }
    }
}
