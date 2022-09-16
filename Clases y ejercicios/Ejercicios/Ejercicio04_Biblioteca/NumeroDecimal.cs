using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Biblioteca
{
    public class NumeroDecimal
    {
        #region Consigna:
        /*Partiendo del ejercicio Conversor binario, se pide agregar las clases:

        NumeroBinario:

            Único atributo numero de tipo string.
            Único constructor privado (recibe un parámetro de tipo string).

        NumeroDecimal:

            Único atributo numero de tipo double.
            Único constructor privado (recibe un parámetro de tipo double).

        Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:

        NumeroBinario:

            string + (NumeroBinario, NumeroDecimal)
            string - (NumeroBinario, NumeroDecimal)
            bool == (NumeroBinario, NumeroDecimal)
            bool != (NumeroBinario, NumeroDecimal) 

        NumeroDecimal:

            double + (NumeroDecimal, NumeroBinario)
            double - (NumeroDecimal, NumeroBinario)
            bool == (NumeroDecimal, NumeroBinario)
            bool != (NumeroDecimal, NumeroBinario) 

        Agregar conversiones implícitas para poder ejecutar:

        NumeroBinario objBinario = "1001";
        NumeroDecimal objDecimal = 9;

        Agregar conversiones explícitas para poder ejecutar:

        string binario = (string)objBinario;
        double numeroDecimal = (double)objDecimal;

        Generar el código en el método Main para instanciar un objeto de cada tipo y operar entre ellos, imprimiendo cada resultado por pantalla. */
        #endregion

        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static double operator +(NumeroDecimal dec, NumeroBinario bin)
        {
            return double.Parse(bin + dec);
        }

        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {
            return double.Parse(bin - dec);
        }

        public static bool operator ==(NumeroDecimal dec, NumeroBinario bin)
        {
            return bin == dec;
        }

        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return bin != dec;
        }

        public static implicit operator NumeroDecimal(double dec)
        {
            return new NumeroDecimal(dec);
        }

        public static implicit operator double(NumeroDecimal dec)
        {
            return dec.numero;
        }
    }
}