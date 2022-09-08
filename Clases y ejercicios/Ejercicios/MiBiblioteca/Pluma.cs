using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Pluma
    {
        #region Consigna:
        /*Pluma{

        (-) marca:string

        (-) tinta:Tinta

        (-) cantidad:int

        //constructor 0, 1, 2 y 3 parametros.

        //por defecto->"Sin marca"; null; 1;

        //instancia

        (-)Mostrar():string

        ==(Pluma, Tinta):bool

        +(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (incrementar cantidad)

        -(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (decrementar cantidad)

        implicit (Pluma):string //se relaciona con mostrar*/
        #endregion

        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this (marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Tinta {(string)this.tinta}Cantidad: {this.cantidad}");
            sb.AppendLine($"");

            return sb.ToString();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma.tinta == tinta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma.tinta == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma==tinta)
            {
                pluma.cantidad++;
            }

            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad--;
            }

            return pluma;
        }

        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }
        

    }
}
