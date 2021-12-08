using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Conjuntos
{
    public partial class MatrizDe2 : Form
    {
        public MatrizDe2()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Checar();
        }
        private void Checar()
        {
            if (txt1x1.Text == "1")
            {
                PC1X1.Visible = true;
            }
            if (txt1x1.Text == "0")
            {
                PC1X1.Visible = false;
            }
            if (txt1x1.Text != "1" && txt1x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt1x2.Text == "1")
            {
                PC1x2.Visible = true;
            }
            if (txt1x2.Text == "0")
            {
                PC1x2.Visible = false;
            }
            if (txt1x2.Text != "1" && txt1x2.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt2x1.Text == "1")
            {
                PC2x1.Visible = true;
            }
            if (txt2x1.Text == "0")
            {
                PC2x1.Visible = false;
            }
            if (txt2x1.Text != "1" && txt2x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt2x2.Text == "1")
            {
                PC2x2.Visible = true;
            }
            if (txt2x2.Text == "0")
            {
                PC2x2.Visible = false;
            }
            if (txt2x2.Text != "1" && txt2x2.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
        }
    }
}
