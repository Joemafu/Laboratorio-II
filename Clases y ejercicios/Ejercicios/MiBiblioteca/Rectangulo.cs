using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            return this.area;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            float basee;
            float altura;


            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());

            basee = Math.Abs(this.vertice4.GetX() - this.vertice1.GetX());
            altura = Math.Abs(this.vertice2.GetY() - this.vertice1.GetY());

            this.area = basee*altura;
            this.perimetro = (basee + altura) * 2;

        }
    }
}
