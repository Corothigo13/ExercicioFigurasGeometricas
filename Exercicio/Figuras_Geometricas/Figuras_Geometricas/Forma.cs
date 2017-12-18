using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    abstract class Forma
    {
        double area, perimetro;
        abstract public void calcularArea(double a, double b);
        abstract public void calcularPerimetro(double a, double b, double c, double d, double e);
        virtual public double mostrarArea() { return area; }
        virtual public double mostrarPerimetro() { return perimetro; }
        
    }
}
