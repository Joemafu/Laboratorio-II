﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Fahrenheit
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
        public float grados;

        public Fahrenheit(float grados)
        {
            this.grados = grados;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.grados-32)*(5/9f));
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return (Kelvin)(Celsius)f;
        }
    }
}
