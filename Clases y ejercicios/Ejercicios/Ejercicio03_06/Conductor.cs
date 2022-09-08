using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_06
{
    class Conductor
    {
        public string nombre;
        public int[] dias = new int[7];
        public int recorridoSemanal;

        public Conductor(string nombre, int dia1, int dia2, int dia3, int dia4, int dia5, int dia6, int dia7)
        {
            this.nombre = nombre;
            this.dias[0] = dia1;
            this.dias[1] = dia2;
            this.dias[2] = dia3;
            this.dias[3] = dia4;
            this.dias[4] = dia5;
            this.dias[5] = dia6;
            this.dias[6] = dia7;
            this.CalcularRecorridoSemanal();
        }

        private void CalcularRecorridoSemanal()
        {
            int acumulador=0;
            int i ;
            for (i=0;i<7;i++)
            {
                acumulador += this.dias[i];
            }
            this.recorridoSemanal = acumulador;
        }
    }
}
