using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Pentagono:Forma

    {
        double area, perimetro;
        override public void calcularArea(double lado, double apotema)
        {
            area = lado * apotema * 5;
        }
        override public void calcularPerimetro(double lado, double b, double c, double d, double e)
        {
            perimetro = 5 * lado; 
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
