using System;
using Ejercicio10_Biblioteca;

namespace Ejercicio10_EnClase02
{
    class Program
    {
        /*Crear una clase que derive de Exception con una propiedad llamada Mensaje que concatene el mensaje que 
        tiene como parámetro de entrada en el constructor con el ya existente.

        Realizar un burbujeo partiendo de un método, capturando y re lanzando esta misma excepción como mínimo 3 
        (tres) veces, creando los métodos que sean necesarios y colocando un nuevo mensaje por cada nuevo Throw 
        que se realice.
        */

        static void Main(string[] args)
        {
            try
            {
                Program.MetodoUno();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void MetodoUno()
        {
            try
            {
                Program.MetodoDos();
            }
            catch (MiExcepcion e)
            {
                throw new MiExcepcion("Metodo 1\n", e);
            }
        }

        static void MetodoDos()
        {
            try
            {
                Program.MetodoTres();
            }
            catch (MiExcepcion e)
            {
                throw new MiExcepcion("Metodo 2\n",e);
            }
        }

        static void MetodoTres()
        {
           throw new MiExcepcion("Método 3\n");   
        }
    }
}


/*
Siguiendo con la misma lógica del ejercicio anterior, se pide: Realizar el burbujeo de una excepción propia, 
comenzando en un método de instancia, pasando por un método de estático y capturando por última vez en el “main”. 
*/