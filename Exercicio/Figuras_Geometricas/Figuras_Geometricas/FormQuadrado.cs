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
    public partial class FormQuadrado : Form
    {
        Quadrado q = new Quadrado();
        public FormQuadrado()
        {
            InitializeComponent();
        }

        private void b_Area_Click(object sender, EventArgs e)
        {
            q.calcularArea(Convert.ToDouble(txt_baseA.Text), Convert.ToDouble(txt_alturaA.Text));
            txt_resultA.Text = Convert.ToString(q.mostrarArea()) + " cm";

        }

        private void b_Perimetro_Click(object sender, EventArgs e)
        {
            q.calcularPerimetro(Convert.ToDouble(txt_baseP.Text), 0, 0, 0, 0);
            txt_resultP.Text = Convert.ToString(q.mostrarPerimetro()) + " cm";

        }
    }
}
