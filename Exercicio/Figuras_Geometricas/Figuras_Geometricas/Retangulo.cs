using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Retangulo:Forma
    {
        double area, perimetro;
        override public void calcularArea(double altura, double _base)
        {
            area = altura * _base;
        }
        override public void calcularPerimetro(double altura, double _base, double c, double d, double e)
        {
            perimetro = 2 * (altura + _base);
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
