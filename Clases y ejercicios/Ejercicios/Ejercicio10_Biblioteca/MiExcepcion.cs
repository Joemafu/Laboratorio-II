using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_Biblioteca
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje) : base(mensaje)
        {
            
        }

        public MiExcepcion(string mensaje, Exception inner) : this(inner.Message + mensaje)
        {

        }
    }
}