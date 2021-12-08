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
    public partial class Bisiesto : Form
    {
        public Bisiesto()
        {
            InitializeComponent();
        }

        private void Bisiesto_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(txtAño.Text);

            bool esBisiesto = ((año % 4 == 0) && (año % 100 != 0)) || (año % 400 == 0);
            if (esBisiesto)
            {
                MessageBox.Show("El año " + año + " es bisiesto");
            }
            else
            {
                MessageBox.Show("El año " + año + " no bisiesto");
            }
        }
    }
}
