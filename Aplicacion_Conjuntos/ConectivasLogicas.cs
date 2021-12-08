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
    public partial class ConectivasLogicas : Form
    {
        public ConectivasLogicas()
        {
            InitializeComponent();
        }

        private void ConectivasLogicas_Load(object sender, EventArgs e)
        {

        }
        private void btnNegar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnConj_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCond_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBic_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            

        }
        /*------ Convectivas codigo de compilacion boton negar-----*/
        private void btnNegar_Click_1(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(cboNegar.SelectedIndex + 1);
            int x = 1;

            if (x < num)
            {
                lblResNeg.Text = "Verdadero";
            }
            else
            {
                lblResNeg.Text = "Falso";
            }
        }

        //Boton Conjuncion
        private void btnConj_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(cboConjP.SelectedIndex + 1);
            int num2 = Convert.ToInt32(cboConjQ.SelectedIndex + 1);
            int p = 1;
            int q = 1;

            //condicionale 
            if (p <= num1 && q <= num2)
            {
                lblResConj.Text = "Verdadero";
            }
            if (p <= num1 && q < num2)
            {
                lblResConj.Text = "Falso";
            }
            if (p < num1 && q >= num2)
            {
                lblResConj.Text = "Falso";
            }
        }
        //boton disyuncion 
        private void btnDis_Click_1(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(cboDisP.SelectedIndex + 1);
            int num1 = Convert.ToInt32(cboDisQ.SelectedIndex + 1);
            int p = 1;
            int q = 1;

            if (p <= num && q <= num1)
            {
                lblResDis.Text = "Verdadero";
            }
            if (p < num && q >= num1)
            {
                lblResDis.Text = "Verdadero";
            }
            if (p <= num && q < num1)
            {
                lblResDis.Text = "Verdadero";
            }
            if (p < num && q < num1)
            {
                lblResDis.Text = "Falso";
            }
        }

        //condicional 
        private void btnCond_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(cboCondP.SelectedIndex + 1);
            int num2 = Convert.ToInt32(cboCondQ.SelectedIndex + 1);
            int p = 1;
            int q = 1;

            if (p <= num1 && q <= num2)
            {
                lblResCond.Text = "Verdadero";
            }
            if (p < num1 && q >= num2)
            {
                lblResCond.Text = "Verdadero";
            }
            if (p <= num1 && q < num2)
            {
                lblResCond.Text = "Falso";
            }
            if (p < num1 && q < num2)
            {
                lblResCond.Text = "Verdadero";
            }
        }
        //biconcicional 
        private void btnBic_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(cboBicP.SelectedIndex + 1);
            int num2 = Convert.ToInt32(cboBicQ.SelectedIndex + 1);
            int p = 1;
            int q = 1;

            if (p <= num1 && q <= num2)
            {
                lblResBic.Text = "Verdadero";
            }
            if (p <= num1 && q < num2)
            {
                lblResBic.Text = "Falso";
            }
            if (p < num1 && q >= num2)
            {
                lblResBic.Text = "Falso";
            }
            if (p < num1 && q < num2)
            {
                lblResBic.Text = "Verdadero";
            }
        }

        //boton limpiar

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            lblResBic.Text = "";
            lblResCond.Text = "";
            lblResConj.Text = "";
            lblResDis.Text = "";
            lblResNeg.Text = "";
        }
    }
}