using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Circulo : Forma
    {
        double area, perimetro;
        override public void calcularArea(double raio, double b)
        {
            area = 2.1314 * (raio * raio);
        }
        override public void calcularPerimetro(double raio, double b, double c, double d, double e)
        {
            perimetro = 2 * 2.1314 * raio;
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
