using System;
using Ejercicio03_Biblioteca;

namespace Ejercicio03_03
{
    class Program
    {
        static void Main(string[] args)
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

            Estudiante estudiante1 = new Estudiante("Homero", "Simpson", "135644");
            Estudiante estudiante2 = new Estudiante("Marge", "Bouvier","135356");
            Estudiante estudiante3 = new Estudiante("Montgomery", "Burns", "1");

            estudiante1.SetNotaPrimerParcial(3);
            estudiante1.SetNotaSegundoParcial(9);

            estudiante2.SetNotaPrimerParcial(7);
            estudiante2.SetNotaSegundoParcial(8);

            estudiante3.SetNotaPrimerParcial(10);
            estudiante3.SetNotaSegundoParcial(9);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
