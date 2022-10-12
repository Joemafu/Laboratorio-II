using System;

namespace Ejercicio07_Biblioteca
{
    public class Tempera
    {
        #region Consigna:
        /*Tempera{

        (-)color : ConsoleColor

        (-)marca : String

        (-)cantidad : Int32

        //constructor 3 parámetros

        (-)Mostrar() : string//instancia

        (+)Mostrar(Tempera) : string//clase

        //sobrecargas

        == (Tempera, Tempera) : bool //marca y color

        implicit (Tempera) : int // cantidad

        + (Tempera, Tempera) : Tempera

        -> si temperas iguales, acumula cantidad

        + (Tempera, int) : Tempera

        -> acumula cantidad 

        }*/
        #endregion

        private ConsoleColor color;
        private String marca;
        private Int32 cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            //set{} 
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            //set{} 
        }

        private string Mostrar()
        {
            return $"Color: {this.color} - Marca: {this.marca} - Cantidad: {this.cantidad}";
        }

        public static string Mostrar(Tempera tempera)
        {
            string ret = "";

            if (tempera is not null)
            {
                ret = tempera.Mostrar();
            }

            return ret;
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            return t1 is not null && t2 is not null && t1.marca == t2.marca && t1.color == t2.color || t1 is null && t2 is null;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1==t2);
        }

        public static implicit operator int(Tempera tempera)
        {
            int ret = -1;

            if (tempera is not null)
            {
                ret = tempera.cantidad;
            }

            return ret;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {

            if(t1==t2)
            {
                t1 += t2.cantidad;
            }

            return t1;
        }

        public static Tempera operator +(Tempera tempera, int cantidad)
        {
            tempera.cantidad += cantidad;
            return tempera;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            if (this is null && obj is null)
            {
                ret = true;
            }
            else if (obj is not null && obj is Tempera)
            {
                ret = (Tempera)obj == this;
            }

            return ret;
        }
    }
}
