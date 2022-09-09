using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Producto
    {
        #region Consigna:
        /*Crear un proyecto de tipo biblioteca de clases que contenga la clase Producto.

        Diagrama de clase

        https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/producto-diagram-765be2d7770aabd572e603a495bef7a2.png

            Todos sus atributos son privados.
            Posee sólo un constructor de instancia.
            El método GetMarca, retornará el valor correspondiente al atributo marca.
            También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través de la conversión explícita nombrada más adelante.
            El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
            Posee las siguientes sobrecargas de operadores:
                explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
                == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
                == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.*/
        #endregion

        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.marca} Código: {(string)p} Precio: {p.precio}");
            return sb.ToString();
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;
            if(p1 is not null && p2 is not null)
            {
                if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    ret = true;
                }
            }

            return ret;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
