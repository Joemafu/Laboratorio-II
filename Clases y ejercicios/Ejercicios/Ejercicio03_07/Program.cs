using System;

namespace Ejercicio03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascotaAux1 = new Mascota("Perro", "Ayudante de Santa", new DateTime(1989, 12, 25));
            Mascota[] arrayMascotasAux = new Mascota[] {mascotaAux1};
            Cliente cliente1 = new Cliente("Av. Siempreviva 1369", "Homero", "Simpson", "555-555", arrayMascotasAux);


            string[] arrayVacunasAux = new string[] {"Triple Felina" };
            mascotaAux1 = new Mascota("Gato", "Bola de Nieve II", new DateTime(1988, 6, 23), arrayVacunasAux);
            arrayMascotasAux = new Mascota[] { mascotaAux1 };
            Cliente cliente2 = new Cliente("Calle Falsa 123", "Barney", "Gomez", "555-777", arrayMascotasAux);


            mascotaAux1 = new Mascota("Gato", "Tomy", new DateTime(1990, 10, 3));
            arrayVacunasAux = new string[] { "Antirrábica" };
            Mascota mascotaAux2 = new Mascota("Perro", "Poochie", new DateTime(1994, 11, 19), arrayVacunasAux);
            arrayMascotasAux = new Mascota[] { mascotaAux1, mascotaAux2 } ;
            Cliente cliente3 = new Cliente("Av. Evergreen", "Montgomery", "Burns", "555-666", arrayMascotasAux);


            Console.WriteLine(cliente1.Mostrar());
            Console.WriteLine(cliente2.Mostrar());
            Console.WriteLine(cliente3.Mostrar());
        }
    }
}
