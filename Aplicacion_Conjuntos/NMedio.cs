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
    public partial class NMedio : Form
    {
        public NMedio()
        {
            InitializeComponent();
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {

            //cambiar nombres de variables etc

            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            double C = Convert.ToDouble(txtC.Text);

            if (A < B)
            {
                if (B < C)
                {
                    lblResultado.Text = B.ToString();
                }
            }
            if (C < B)
            {
                if (B < A)
                {
                    lblResultado.Text = B.ToString();
                }
            }
            if (B < C)
            {
                if (C < A)
                {
                    lblResultado.Text = C.ToString();
                }
            }
            if (A < C)
            {
                if (C < B)
                {
                    lblResultado.Text = C.ToString();
                }
            }
            if (C < A)
            {
                if (A < B)
                {
                    lblResultado.Text = A.ToString();
                }
            }
            if (B < A)
            {
                if (A < C)
                {
                    lblResultado.Text = A.ToString();
                }
            }
            if (A == B)
            {
                MessageBox.Show("Error: un digito esta repetido");
            }
            if (B == C)
            {
                MessageBox.Show("Error: un digito esta repetido");
            }
            if (A == C)
            {
                MessageBox.Show("Error: un digito esta repetido");
            }
        }
    }
}
