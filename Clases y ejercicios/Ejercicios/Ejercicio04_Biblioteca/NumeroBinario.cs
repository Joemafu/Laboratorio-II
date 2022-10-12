using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02_Biblioteca;

namespace Ejercicio04_Biblioteca
{
    public class NumeroBinario
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

        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario bin, NumeroDecimal dec)
        {
            int entero = int.Parse(bin.numero);

            entero = Conversor.ConvertirBinarioADecimal(entero);

            return (Conversor.ConvertirDecimalABinario(entero + (int)dec.numero)).ToString();
        }

        public static string operator -(NumeroBinario bin, NumeroDecimal dec)
        {
            int entero = int.Parse(bin.numero);

            entero = Conversor.ConvertirBinarioADecimal(entero);

            return (Conversor.ConvertirDecimalABinario(entero - (int)dec.numero)).ToString();
        }

        public static bool operator ==(NumeroBinario bin, NumeroDecimal dec)
        {
            string cadena;

            cadena = Conversor.ConvertirDecimalABinario((int)dec.numero);

            return cadena == bin.numero;
        }

        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }

        public static implicit operator NumeroBinario(string bin)
        {
            return new NumeroBinario(bin);
        }

        public static explicit operator string(NumeroBinario bin)
        {
            return bin.numero;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            if (this is null && obj is null)
            {
                ret = true;
            }
            else if (obj is not null && obj is NumeroBinario)
            {
                ret = (NumeroBinario)obj == this;
            }

            return ret;
        }
    }
}