using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_Biblioteca
{
    public class Mascota
    {
        public string especie;
    public string nombre;
    public DateTime fechaDeNacimiento;
    public static int MAXIMOVACUNAS = 10;
    public string[] vacunas = new string[MAXIMOVACUNAS];

    public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
    {
        this.especie = especie;
        this.nombre = nombre;
        this.fechaDeNacimiento = fechaDeNacimiento;
    }

    public Mascota(string especie, string nombre, DateTime fechaDeNacimiento, string[] vacuna) : this(especie, nombre, fechaDeNacimiento)
    {
        int i;

        this.vacunas[0] = "sin vacunar";

        for (i = 0; i < vacuna.Length; i++)
        {
            this.vacunas[i] = vacuna[i];
        }
    }

    public string Mostrar()
    {
        int i;
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.especie} - {this.nombre} - nacido el {this.fechaDeNacimiento.ToShortDateString()} ");

        for (i = 0; i < this.vacunas.Length && this.vacunas[i] != null; i++)
        {
            sb.AppendLine($"Vacuna {this.vacunas[i]} recibida.");
        }

        return sb.ToString();
    }
}
}
