using System;

namespace Ejercicio01_07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

            Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.

            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
            
            Importante:
            Utilizar sentencias de iteración y selectivas.

            No es necesario ni se deben utilizar vectores/ arrays.*/
            #endregion

            float valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            bool entradaValida;
            bool yes=true;
            string continuar;
            string recibos = "";
            float bruto;
            float neto;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese valor de la hora:");
                    entradaValida = float.TryParse(Console.ReadLine(), out valorHora);
                } while (!entradaValida);

                Console.WriteLine("Ingrese nombre del empleado:");
                nombre = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese antiguedad del empleado en años:");
                    entradaValida = int.TryParse(Console.ReadLine(), out antiguedad);
                } while (!entradaValida);

                do
                {
                    Console.WriteLine("Ingrese cantidad de horas trabajadas:");
                    entradaValida = int.TryParse(Console.ReadLine(), out horasTrabajadas);
                } while (!entradaValida);

                entradaValida = false;

                do
                {
                    Console.WriteLine("Desea ingresar otro empleado? Y/N:");

                    continuar = Console.ReadLine();
                    if (continuar=="Y")
                    {
                        entradaValida = true;
                    }else if (continuar == "N")
                    {
                        entradaValida = true;
                        yes = false;
                    }
                } while (!entradaValida);

                bruto = valorHora * horasTrabajadas + 150 * antiguedad;
                neto = (float)(bruto * 0.87);

                recibos += ("\n*******************\nRecibo de " + nombre + "\nantiguedad " + antiguedad + "\nvalor de la hora " + valorHora + "\ntotal bruto "+ bruto + "\ntotal neto "+ neto + "\n*******************\n");


            } while (yes);

            Console.WriteLine(recibos);
        }
    }
}
