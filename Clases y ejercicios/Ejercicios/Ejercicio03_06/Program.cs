using System;

namespace Ejercicio03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int recorridoGanador = -1;
            int ganadorSemanaIndex = -1;
            int recordDia3 = -1;
            int ganadorDia3Index = -1;
            int recordDia5 = -1;
            int ganadorDia5Index = -1;
            Conductor conductor1 = new Conductor("Homero", 13, 35, 51, 56, 84, 68, 15);
            Conductor conductor2 = new Conductor("Barney", 456, 45, 0, 64, 564, 0, 456);
            Conductor conductor3 = new Conductor("Moe", 0, 0, 0, 0, 0, 1586, 0);
            Conductor[] arrayConductores = new Conductor[] { conductor1,conductor2,conductor3};

            for (i=0; i<3 ;i++)
            {
                if (i==0 || recorridoGanador < arrayConductores[i].recorridoSemanal)
                {
                    recorridoGanador = arrayConductores[i].recorridoSemanal;
                    ganadorSemanaIndex = i;
                }
                if (i == 0 || recordDia3 < arrayConductores[i].dias[2])
                {
                    recordDia3 = arrayConductores[i].dias[2];
                    ganadorDia3Index = i;
                }
                if (i == 0 || recordDia5 < arrayConductores[i].dias[4])
                {
                    recordDia5 = arrayConductores[i].dias[4];
                    ganadorDia5Index = i;
                }
            }

            Console.WriteLine($"El chofer que hizo mas kms esta semana es {arrayConductores[ganadorSemanaIndex].nombre} con {arrayConductores[ganadorSemanaIndex].recorridoSemanal}");
            Console.WriteLine($"El chofer que hizo mas kms el dia 3 es {arrayConductores[ganadorDia3Index].nombre} con {arrayConductores[ganadorDia3Index].dias[2]}");
            Console.WriteLine($"El chofer que hizo mas kms el dia 5 es {arrayConductores[ganadorDia5Index].nombre} con {arrayConductores[ganadorDia5Index].dias[4]}");
        }
    }
}
