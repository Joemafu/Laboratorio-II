using System;
using Billetes;

namespace Ejercicio04_02
{
    class Program
    {
        static void Main(string[] args)
        {
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
