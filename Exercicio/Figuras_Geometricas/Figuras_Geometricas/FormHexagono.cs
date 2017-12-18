using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FormHexagono : Form
    {
        Hexagono h = new Hexagono();
        public FormHexagono()
        {
            InitializeComponent();
        }

        private void b_Area_Click(object sender, EventArgs e)
        {
            h.calcularArea(Convert.ToDouble(txt_ladoA.Text), 0);
            txt_resultA.Text = Convert.ToString(h.mostrarArea()) + " cm";

        }

        private void b_Perimetro_Click(object sender, EventArgs e)
        {
            h.calcularPerimetro(Convert.ToDouble(txt_ladoP.Text), 0, 0, 0, 0);
            txt_resultP.Text = Convert.ToString(h.mostrarPerimetro()) + " cm";

        }
    }
}
