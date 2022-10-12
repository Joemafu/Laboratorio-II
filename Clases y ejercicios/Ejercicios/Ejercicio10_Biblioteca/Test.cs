using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_Biblioteca
{
    public class Test
    {
        public void MetodoUno()
        {
            try
            {
                Test.MetodoDos();
            }
            catch (MiExcepcion e)
            {
                throw new MiExcepcion("Metodo 1\n", e);
            }
        }

        public static void MetodoDos()
        {
            throw new MiExcepcion("Metodo 2\n");
        }

        
    }
}
