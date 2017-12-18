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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTriangulo ft = new FormTriangulo();
            ft.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCirculo fc = new FormCirculo();
            fc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHexagono fh = new FormHexagono();
            fh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormOctogono fo = new FormOctogono();
            fo.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormRetangulo fr = new FormRetangulo();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormQuadrado fq = new FormQuadrado();
            fq.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormPentagono fp = new FormPentagono();
            fp.ShowDialog();
        }
    }
}
