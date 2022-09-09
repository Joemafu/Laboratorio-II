using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Estante
    {
        #region Consigna:
        /*Generar la clase Estante.

        Diagrama de clase

        https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/estante-diagram-92964e4b26abc3145cc9d7366cad5bab.png

            Posee dos atributos privados. Uno será un entero que indicará la ubicación del estante y el otro es un array de tipo Producto.
            El constructor de instancia privado será el único que incializará el array. La sobrecarga pública del constructor inicializará la ubicación del estante, recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
            El método público GetProductos, retornará el array de productos.
            El método público de clase (estático) MostrarEstante, retornará una cadena con toda la información del estante incluyendo el detalle de cada uno de sus productos. Reutilizar código.
            Posee las siguientes sobrecargas de operadores:
                ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
                +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
                -: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.*/
        #endregion

        private Producto[] producto;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.producto = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return producto;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ubicación del estante: {e.ubicacionEstante}.");

            foreach ( Producto item in e.GetProductos())
            {
                sb.Append($"{Producto.MostrarProducto(item)}");
            }

            sb.AppendLine();

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool ret=false;

            foreach (Producto item in e.GetProductos())
            {
                if(item==p)
                {
                    ret = true;
                }
            }

            return ret;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            int i;
            bool ret = false;

            if(e!=p)
            {
                for (i = 0; i < e.producto.Length; i++)
                {
                    if (e.producto[i] is null)
                    {
                        e.producto[i] = p;
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i;

            if (e==p)
            {
                for(i=0;i<e.producto.Length;i++)
                {
                    if(e.producto[i]==p)
                    {
                        e.producto[i] = null;
                    }
                }
            }
            return e;
        }


    }
}
