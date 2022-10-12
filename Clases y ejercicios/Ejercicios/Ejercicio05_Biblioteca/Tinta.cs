using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_Biblioteca
{
    public class Tinta
    {
        #region Consigna:
        /*Tinta{

        (-) color:ConsoleColor

        (-) tipo:ETipoTinta 

        //constructor 0, 1, 2 parametros

        //por defecto->Black; Comun

        //instancia

        (-)Mostrar():string

        //clase

        (+)Mostrar(Tinta):string

        //sobrecarga de operadores

        == (Tinta, Tinta): bool //color y tipo

        explicit (Tinta) : string //se relaciona con mostrar*/
        #endregion

        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"color: {this.color}");
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            return tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static explicit operator string(Tinta tinta)
        {
            return Mostrar(tinta);
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
            else if (obj is not null && obj is Tinta)
            {
                ret = (Tinta)obj == this;
            }

            return ret;
        }
    }
}