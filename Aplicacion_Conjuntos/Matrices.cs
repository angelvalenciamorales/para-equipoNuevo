﻿using System;
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
    public partial class Matrices : Form
    {
        public Matrices()
        {
            InitializeComponent();
        }

        MatrizDe5 Matriz5 = new MatrizDe5();
        MatrizDe4 Matriz4 = new MatrizDe4();
        MatrizDe3 Matriz3 = new MatrizDe3();
        MatrizDe2 Matriz2 = new MatrizDe2();
        MatrizDe1 Matriz1 = new MatrizDe1();

        private void Matrices_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboNodos.SelectedIndex == 4)
            {
                Matriz5.Show();
            }
            if (cboNodos.SelectedIndex == 3)
            {
                Matriz4.Show();
            }
            if (cboNodos.SelectedIndex == 2)
            {
                Matriz3.Show();
            }
            if (cboNodos.SelectedIndex == 1)
            {
                Matriz2.Show();
            }
            if (cboNodos.SelectedIndex == 0)
            {
                Matriz1.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
