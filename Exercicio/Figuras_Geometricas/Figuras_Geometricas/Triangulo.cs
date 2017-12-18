using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Triangulo : Forma
    {
        double area, perimetro;
        override public void calcularArea(double a, double b)
        {
            area = (a * b) / 2;
        }
        override public void calcularPerimetro(double a, double b, double c, double d, double e)
        {
            perimetro = a *3;
        }
        override public double mostrarArea()
        {
            return area;
        }
        public override double mostrarPerimetro()
        {

            return perimetro;
        }

    }
}
