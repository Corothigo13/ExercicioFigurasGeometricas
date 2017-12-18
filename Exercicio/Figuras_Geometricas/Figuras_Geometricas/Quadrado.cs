using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Quadrado: Forma
    {
        double area, perimetro;
        override public void calcularArea(double altura, double bAse)
        {
            area = bAse * altura;
        }
        override public void calcularPerimetro(double lado, double b, double c, double d, double e)
        {
            perimetro = lado * 4;
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
