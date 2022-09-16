using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_Biblioteca
{
    public class Estudiante
    {
        #region Consigna
        /*Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

        https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/el-ejemplo-universal-diagram-9ff4c151adf0d04eaba52472e5c95fec.png

        La clase Estudiante:

            Tendrá un constructor estático que inicializará el atributo estático random.
            Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
            El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
            El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
            El método privado CalcularPromedio retornará el promedio de las dos notas.
            El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
            El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
                Nombre, apellido y legajo.
                Nota del primer y segundo parcial.
                Promedio.
                Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado". 

            Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.

        Importante:
        Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.*/
        #endregion

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / (float)2;
        }

        public double CalcularNotaFinal()
        {
            double ret = -1;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                ret = Estudiante.random.Next(6, 11);
            }

            return ret;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            sb.AppendLine($"{this.nombre} {this.apellido} legajo Nº {this.legajo}");
            sb.AppendLine($"Primer parcial {this.notaPrimerParcial} - Segundo parcial {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio {this.CalcularPromedio()}");

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }

            return sb.ToString();
        }
    }
}
