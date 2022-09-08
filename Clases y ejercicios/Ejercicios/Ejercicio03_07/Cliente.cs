using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_07
{
    class Cliente
    {
        public string domicilio;
        public string nombre;
        public string apellido;
        public string telefono;
        public static int MAXIMODEMASCOTAS = 100;
        public Mascota[] mascotas = new Mascota[MAXIMODEMASCOTAS];


        public Cliente(string domicilio, string nombre, string apellido, string telefono, Mascota[] mascota)
        {
            int i;

            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;

            for(i=0;i<mascota.Length;i++)
            {
                this.mascotas[i] = mascota[i];
            }
        }

        public string Mostrar()
        {
            int i;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Teléfono: {this.telefono} ");

            if (this.mascotas!= null)
            {
                sb.AppendLine($"Mascota/s: ");

                for (i = 0; i < this.mascotas.Length &&this.mascotas[i]!=null; i++)
                {
                    sb.AppendLine(this.mascotas[i].Mostrar());
                }
            }
            

            return sb.ToString();
        }
    }
}
