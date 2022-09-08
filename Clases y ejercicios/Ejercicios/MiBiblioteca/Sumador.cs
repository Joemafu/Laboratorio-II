using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Sumador
    {
        #region Consigna:
        /*Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.
        https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/diagramaSumador-c055af95d68e4c1e2a9f9b6f1259f38c.JPG
        Crear dos constructores:
            Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
            Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.

        El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
        En el caso de Sumar(long, long) sumará los valores numéricos
        En el de Sumar(string, string) concatenará las cadenas de texto.*/
        #endregion

        private int cantidadSumas;

        public Sumador () : this (0)
        {

        }

        public Sumador (int cantidadSumas) 
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar (long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar (string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (int)s1 == (int)s2;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }
    }
}
