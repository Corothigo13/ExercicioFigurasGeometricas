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
    public partial class FormCirculo : Form
    {
        Circulo c = new Circulo();
        public FormCirculo()
        {
            InitializeComponent();
        }

        private void FormCirculo_Load(object sender, EventArgs e)
        {
        }



        private void b_Area_Click(object sender, EventArgs e)
        {
            c.calcularArea(Convert.ToDouble(txt_raioA.Text), 0);
            txt_resultA.Text = Convert.ToString(c.mostrarArea()) + " cm";


        }

        private void b_Perimetro_Click(object sender, EventArgs e)
        {
            c.calcularPerimetro(Convert.ToDouble(txt_raioP.Text), 0, 0, 0, 0);
            txt_resultP.Text = Convert.ToString(c.mostrarPerimetro()) + " cm";

        }
    }
}
