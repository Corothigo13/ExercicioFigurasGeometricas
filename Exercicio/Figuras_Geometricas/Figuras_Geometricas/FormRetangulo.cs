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
    public partial class FormRetangulo : Form
    {
        Retangulo r = new Retangulo();
        public FormRetangulo()
        {
            InitializeComponent();
        }

        private void b_Area_Click(object sender, EventArgs e)
        {
            r.calcularArea(Convert.ToDouble(txt_baseA.Text), Convert.ToDouble(txt_alturaA.Text));
            txt_resultA.Text = Convert.ToString(r.mostrarArea()) + " cm";

        }

        private void b_Perimetro_Click(object sender, EventArgs e)
        {
            r.calcularPerimetro(Convert.ToDouble(txt_baseP.Text), 0, 0, 0, 0);
            txt_resultP.Text = Convert.ToString(r.mostrarPerimetro()) + " cm";

        }

    }
}
