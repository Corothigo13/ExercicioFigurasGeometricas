using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Hexagono:Forma
    {
        double area, perimetro;
        override public void calcularArea(double lado, double b)
        {
            area = (3 * (lado * lado) * 1.73205080)/2;
        }
        override public void calcularPerimetro(double lado, double b, double c, double d, double e)
        {
            perimetro = lado * 6;
        }
        override public double mostrarArea()
        {
            /* label_resultA.Text = area;
               label_resultP.Text = perimetro;*/
            return area;
        }
        public override double mostrarPerimetro()
        {
            return perimetro;
        }

    }
}
