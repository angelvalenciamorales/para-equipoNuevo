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
    public partial class NMayor : Form
    {
        public NMayor()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Cambiar Nombres de variables 

            int Num1 = Convert.ToInt32(txtNum1.Text);
            int Num2 = Convert.ToInt32(txtNum2.Text);
            int Num3 = Convert.ToInt32(txtNum3.Text);

            if (Num1 >= Num2)
            {
                if (Num1 > Num3)
                {
                    MessageBox.Show("El Numero mayor es: " + Num1);
                }
                if (Num3 > Num1)
                {
                    MessageBox.Show("El Numero mayor es: " + Num3);
                }
            }

            if (Num2 > Num1)
            {
                if (Num2 > Num3)
                {
                    MessageBox.Show("El Numero mayor es: " + Num2);
                }
                if (Num3 > Num2)
                {
                    MessageBox.Show("El Numero mayor es: " + Num3);
                }
            }
        }
    }
}
