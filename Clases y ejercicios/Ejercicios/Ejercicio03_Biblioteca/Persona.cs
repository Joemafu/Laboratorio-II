using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_Biblioteca
{
    public class Persona
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

        public string nombre;
        public DateTime fechaDeNacimiento;
        public int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.SetNombre(nombre);
            this.SetFechaDeNacimiento(fechaDeNacimiento);
            this.SetDni(dni);
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public int GetDni()
        {
            return this.dni;
        }

        private int CalcularEdad()
        {
            DateTime fecha = this.GetFechaDeNacimiento().AddYears(1);
            int ret = 0;

            while (fecha < DateTime.Today)
            {
                ret++;
                fecha = fecha.AddYears(1);
            }
            return ret;
        }

        public string Mostrar()
        {
            return $"Nombre: {this.GetNombre()} \nDNI: {this.GetDni()} \nFecha de nacimiento: {this.GetFechaDeNacimiento().ToShortDateString()} \nEdad: {this.CalcularEdad()}";
        }

        public string EsMayorDeEdad()
        {
            string ret = "Es mayor de edad\n";

            if (this.CalcularEdad() < 18)
            {
                ret = "es menor\n";
            }
            return ret;
        }
    }
}