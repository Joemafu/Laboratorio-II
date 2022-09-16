using System;
using Ejercicio03_Biblioteca;

namespace Ejercicio03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

            Deberá tener los atributos:

                nombre
                fechaDeNacimiento
                dni

            Deberá tener un constructor que inicialice todos los atributos.

            Construir los siguientes métodos para la clase:

                Setter y getter para cada uno de los atributos.
                CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
                Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
                EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

                Instanciar 3 objetos de tipo Persona en el método Main.
                Mostrar quiénes son mayores de edad y quiénes no.*/
            #endregion

            DateTime fecha1 = new DateTime(1992,06,23);
            DateTime fecha2 = new DateTime(2016,09,17);
            DateTime fecha3 = new DateTime(2004,12,31);

            Persona persona1 = new Persona("Joel", fecha1, 38008908);
            Persona persona2 = new Persona("Damián", fecha2, 45097567);
            Persona persona3 = new Persona("Pablo", fecha3, 50362561);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());

            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());

        }
    }
}
