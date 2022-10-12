using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07_Biblioteca
{
    public class Paleta
    {
        #region Consigna:
        /*Paleta{

        (-)temperas : List<Tempera>

        (-)cantidadMaximaColores : int

        //constructor

        (-)()//inicializa las temperas

        (-)(int)//cantidad máx de colores

        implicit (int) : Paleta

        (-)Mostrar() : string

        (-)obtenerIndice(Tempera) : int

        *->retorna el índice donde se encuentra la tempera o valor neg. si no la encuentra.

        explicit (Paleta) : string

        ==(Paleta, Tempera) : bool

        *->si tempera está en paleta --> true

        +(Paleta, Tempera) : Paleta

        *->si tempera está en paleta --> incrementa la cantidad en la tempera.

        *->si no está --> agrega la tempera en la paleta, siempre y cuando, no supere la cantidad máxima de colores.

        -(Paleta, Tempera) : Paleta

        *->si tempera está en paleta -> decrementa la cantidad en la tempera.

        *)si la cantidad es menor o igual a cero, elimina la tempera (RemoveAt)

        +(Paleta, Paleta) : Paleta

        *->genera una paleta con los colores de ambas paletas.

        *)si temperas son iguales-->suma cantidades

        }*/
        #endregion

        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        public Tempera this[int i]
        { 
            get
            {
                Tempera ret = null;
                if(this is not null && i >= 0 && i < this.temperas.Count)
                {
                    ret = this.temperas[i];
                }
                return ret;
            }
            set
            {
                if (this is not null && i >= 0 && i < this.temperas.Count)
                {
                    this.temperas[i] = value;
                }                
            }
        }

        public int CantidadTemperas
        {
            get { return this.temperas.Count; }
            //set {  }
        }

        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }

        private Paleta(int cantidad):this()
        {
            this.cantidadMaximaColores = cantidad;
        }

        public static implicit operator Paleta (int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad de paleta: {this.cantidadMaximaColores}");
            foreach (Tempera item in this.temperas)
            {
                sb.AppendLine(Tempera.Mostrar(item));
            }

            return sb.ToString();
        }

        private int obtenerIndice(Tempera tempera)
        {
            int i=0;
            int ret = -1;

            foreach(Tempera item in this.temperas)
            {
                if (item==tempera)
                {
                    ret = i;
                    break;
                }
                i++;
            }

            return ret;
        }

        public static explicit operator string (Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            return paleta.obtenerIndice(tempera) > -1;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta==tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            if(paleta==tempera)
            {
                paleta.temperas[paleta.obtenerIndice(tempera)]+=tempera;
            }
            else if (paleta.cantidadMaximaColores>paleta.temperas.Count)
            {
                paleta.temperas.Add(tempera);
            }

            return paleta;
        }

        public static Paleta operator-(Paleta paleta, Tempera tempera)
        {
            int negativo = tempera*-1;
            int i = paleta.obtenerIndice(tempera);

            if(i>-1)
            {
                paleta.temperas[i] += negativo;
                if(paleta.temperas[i]<1)
                {
                    paleta.temperas.RemoveAt(i);
                }
            }

            return paleta;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta ret = new Paleta(p1.cantidadMaximaColores + p2.cantidadMaximaColores);

            ret.temperas = p1.temperas;

            foreach (Tempera item in p2.temperas)
            {
                ret += item;
            }

            return ret;
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
            else if (obj is not null && obj is Paleta)
            {
                ret = (Paleta)obj == this;
            }

            return ret;
        }
    }
}
