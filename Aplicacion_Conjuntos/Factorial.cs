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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            //Cambiar nombres de Variables....
            int Num = Convert.ToInt32(txtNum.Text);
            int factorial = 1, contador = 0;


            //bucle 
            for (int i = 1; i <= Num; i++)
            {
                contador = contador + 1;
                factorial = factorial * contador;
            }

            //Resultados
           lblResultado.Text = Convert.ToString("El factorial de " + Num + " es: " + factorial);
        }
    }
}
