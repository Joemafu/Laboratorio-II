using System;
using Billetes;

namespace Ejercicio04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna:
            /*Crear un proyecto de tipo biblioteca de clases.Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dolar.

            https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/diagramaConversor-32ee7e2889ce0f22f6c006523ef93e25.png

            https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/diagramaConversor-32ee7e2889ce0f22f6c006523ef93e25.png

            https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/assets/images/diagramaConversor-32ee7e2889ce0f22f6c006523ef93e25.png

            Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.

            tip:
            Para operar dos tipos de monedas distintos, primero se deberá convertir todo a una misma moneda y luego realizar la operación.Por ejemplo, si quiero sumar Dolar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.

              El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

              Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.

              Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.

              Los operadores de comparación == compararán cantidades.


              Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.

              Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.*/
            #endregion

            Peso peso = new Peso(120.10);

            Dolar dolar = new Dolar(1.17);

            Euro euro = new Euro(1);

            Console.WriteLine($"Tengo {peso.GetCantidad()} pesos!");

            Console.WriteLine($"+ Sumo {dolar.GetCantidad()} dolares a los pesos");

            peso += dolar;

            Console.WriteLine($"Tengo {peso.GetCantidad()} pesos!");

            Console.WriteLine($"+ Sumo {euro.GetCantidad()} euro a los pesos");

            peso += euro;

            Console.WriteLine($"Tengo {peso.GetCantidad()} pesos!");

            Console.WriteLine($"- Resto {dolar.GetCantidad()} dolares a los pesos");

            peso -= dolar;

            Console.WriteLine($"Tengo {peso.GetCantidad()} pesos!");

            Console.WriteLine($"- Resto {euro.GetCantidad()} euro a los pesos");

            peso -= euro;

            Console.WriteLine($"Tengo {peso.GetCantidad()} pesos!");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine($"+ Sumo {peso.GetCantidad()} pesos a los dolares");

            dolar += peso;

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine($"+ Sumo {euro.GetCantidad()} euro a los dolares");

            dolar += euro;

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine($"- Resto {peso.GetCantidad()} pesos a los dolares");

            dolar -= peso;

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine($"- Resto {euro.GetCantidad()} euro a los dolares");

            dolar -= euro;

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine($"Tengo {euro.GetCantidad()} euros!");

            Console.WriteLine($"+ Sumo {peso.GetCantidad()} pesos a los euros");

            euro += peso;

            Console.WriteLine($"Tengo {euro.GetCantidad()} euros!");

            Console.WriteLine($"+ Sumo {dolar.GetCantidad()} dolares a los euros");

            euro += dolar;

            Console.WriteLine($"Tengo {euro.GetCantidad()} euros!");

            Console.WriteLine($"- Resto {peso.GetCantidad()} pesos a los euros");

            euro -= peso;

            Console.WriteLine($"Tengo {euro.GetCantidad()} euros!");

            Console.WriteLine($"- Resto {dolar.GetCantidad()} dolares a los euros");

            euro -= dolar;

            Console.WriteLine($"Tengo {euro.GetCantidad()} euros!");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine($"= Convierto {dolar.GetCantidad()} dolares a euros");

            euro = (Euro)dolar;

            Console.WriteLine($"Tengo {euro.GetCantidad()} euro!");

            Console.WriteLine($"= Convierto {euro.GetCantidad()} euros a dolares");

            dolar = (Dolar)euro;

            Console.WriteLine($"Tengo {dolar.GetCantidad()} dolares!");

            Console.WriteLine($"= Convierto {dolar.GetCantidad()} dolares a pesos");

            peso = (Peso)dolar;

            Console.WriteLine($"Tengo {peso.GetCantidad()} pesos!");
        }
    }
}
