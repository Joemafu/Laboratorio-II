using System;
using Ejercicio04_Biblioteca;

namespace Ejercicio04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna:
            /*Crear un proyecto de consola y un proyecto de biblioteca de clases. Agregar al último tres clases Fahrenheit, Celsius y Kelvin.

            Realizar la implementación necesaria para poder convertir una temperatura en sus distintas unidades de medida (Fahrenheit, Celsius y Kelvin).

            Utilizar sobrecargas de métodos, operadores y/o conversiones.
            tip

            F = C * (9/5) + 32

            C = (F-32) * 5/9

            F = K * 9/5 – 459.67

            K = (F + 459.67) * 5/9

            “Fahrenheit 451: la temperatura a la que el papel se inflama y arde”...

            La novela de ciencia-ficción 'Fahrenheit 451' fue publicada en 1953 por el escritor estadounidense Ray Bradbury (1920-2012). Presenta una sociedad del futuro en la que los libros están prohibidos y existen «bomberos» que queman cualquier ejemplar que encuentren.*/
            #endregion

            Celsius c = new Celsius(100);
            Fahrenheit f = new Fahrenheit(451);
            Kelvin k = new Kelvin(0);

            Console.WriteLine($"Cº {c.grados}");
            Console.WriteLine($"Fº {f.grados}");
            Console.WriteLine($"Kº {k.grados}");

            Console.WriteLine($"Cº {c.grados} son Fº {((Fahrenheit)c).grados} o Kº {((Kelvin)c).grados}");
            Console.WriteLine($"Fº {f.grados} son Cº {((Celsius)f).grados} o Kº {((Kelvin)f).grados}");
            Console.WriteLine($"Kº {k.grados} son Cº {((Celsius)k).grados} o Fº {((Fahrenheit)k).grados}");
        }
    }
}
