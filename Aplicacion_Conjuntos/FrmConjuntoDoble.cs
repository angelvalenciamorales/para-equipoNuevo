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
    public partial class FrmConjuntoDoble : Form
    {
        private HashSet<string> conjuntoA = new HashSet<string>();
        private HashSet<string> conjuntoB = new HashSet<string>();
        private HashSet<string> unionAB = new HashSet<string>();
        private HashSet<string> interseccionAB = new HashSet<string>();
        private HashSet<string> diferenciaAB = new HashSet<string>();
        private HashSet<string> diferenciaBA = new HashSet<string>();
        private HashSet<string> diferenciaSimetrica = new HashSet<string>();

        ConjuntoDoble conjunto;

        public FrmConjuntoDoble()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtInterseccionAB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConjuntoDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnJE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConectivasL_Click(object sender, EventArgs e)
        {
            ConectivasLogicas CT = new ConectivasLogicas();
            CT.Show();
        }

        private void btnNMayor_Click(object sender, EventArgs e)
        {
            NMayor NuMayor = new NMayor();
            NuMayor.Show();
        }

        private void btnNMenor_Click(object sender, EventArgs e)
        {
            NMedio NuMedio = new NMedio();
            NuMedio.Show();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            Bisiesto ABisiesto = new Bisiesto();
            ABisiesto.Show();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            Factorial Fac = new Factorial();
            Fac.Show();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            TranspuestaM T = new TranspuestaM();
            T.Show();
        }

        private void btnUID_Click(object sender, EventArgs e)
        {
            Form1 IDC = new Form1();
            IDC.Show();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            Primo p = new Primo();
            p.Show();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            Matrices G = new Matrices();
            G.Show();
        }
    }
}