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
    public partial class Primo : Form
    {
        public Primo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cambiar nombre de variables 
            int numero = 0, conteo = 0;

            numero = Convert.ToInt32(txtEntrada.Text);

            try
            {

                for (int i = 1; i < (numero + 1); i++)
                {

                    if (numero % i == 0)
                    {
                        conteo++;
                    }
                    if (conteo != 2)
                    {

                        lblResultado.Text = Convert.ToString("El numero no es primo: \t" +
                        numero);

                    }
                    else
                    {
                        lblResultado.Text = Convert.ToString("El numero es primo: \t" + numero);

                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Lo sentimos introdujo un valor de tipo caracter" + error);

            }
        }
    }
}    
