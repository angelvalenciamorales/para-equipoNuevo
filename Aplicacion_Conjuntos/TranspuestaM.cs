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
    public partial class TranspuestaM : Form
    {
        public TranspuestaM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NUM1 = txt1x1.Text;
            txtTRANS1x1.Text = NUM1;

            string NUM2 = txt1x2.Text;
            txtTRANS2x1.Text = NUM2;

            string NUM3 = txt1x3.Text;
            txtTRANS3x1.Text = NUM3;

            string NUM4 = txt2x1.Text;
            txtTRANS1x2.Text = NUM4;

            string NUM5 = txt2x2.Text;
            txtTRANS2x2.Text = NUM5;

            string NUM6 = txt2x3.Text;
            txtTRANS3x2.Text = NUM6;

            string NUM7 = txt3x1.Text;
            txtTRANS1x3.Text = NUM7;

            string NUM8 = txt3x2.Text;
            txtTRANS2x3.Text = NUM8;

            string NUM9 = txt3x3.Text;
            txtTRANS3x3.Text = NUM9;
        }
    }
}
