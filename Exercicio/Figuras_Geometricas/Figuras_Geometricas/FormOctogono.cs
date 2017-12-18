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
    public partial class FormOctogono : Form
    {
        Octogono o = new Octogono();
        public FormOctogono()
        {
            InitializeComponent();
        }

        private void b_Area_Click(object sender, EventArgs e)
        {
            o.calcularArea(Convert.ToDouble(txt_ladoA.Text), Convert.ToDouble(txt_apotemaA.Text));
            txt_resultA.Text = Convert.ToString(o.mostrarArea()) + " cm";

        }

        private void b_Perimetro_Click(object sender, EventArgs e)
        {
            o.calcularPerimetro(Convert.ToDouble(txt_ladoP.Text), 0, 0, 0, 0);
            txt_resultP.Text = Convert.ToString(o.mostrarPerimetro()) + " cm";

        }
    }
}
