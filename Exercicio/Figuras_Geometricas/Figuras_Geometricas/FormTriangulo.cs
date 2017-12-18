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
    public partial class FormTriangulo : Form
    {
        Triangulo t = new Triangulo();
        public FormTriangulo()
        {
            InitializeComponent();
        }


        public void button2_Click(object sender, EventArgs e)
        {
            t.calcularPerimetro(Convert.ToDouble(txt_lado1.Text),0,0,0,0);
            txt_resultP.Text = Convert.ToString(t.mostrarPerimetro())+" cm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.calcularArea(Convert.ToDouble(txt_baseT.Text), Convert.ToDouble(txt_alturaT.Text));
            txt_resultA.Text = Convert.ToString(t.mostrarArea())+" cm";
        }
    }
}
