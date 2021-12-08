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
    public partial class MatrizDe4 : Form
    {
        Graphics drawArea;
        public MatrizDe4()
        {
            InitializeComponent();
            drawArea = drawingArea.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checar();
        }
        private void Checar()
        {
            if (txt1x1.Text == "1")
            {
                PC1x1.Visible = true;
            }
            if (txt1x1.Text == "0")
            {
                PC1x1.Visible = false;
            }
            if (txt1x1.Text != "1" && txt1x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt1x3.Text == "1")
            {
                PC1x3.Visible = true;
            }
            if (txt1x3.Text == "0")
            {
                PC1x3.Visible = false;
            }
            if (txt1x3.Text != "1" && txt1x3.Text != "0")
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
            if (txt2x3.Text == "1")
            {
                //PC2x3.Visible = true;
            }
            if (txt2x3.Text == "0")
            {
                //PC2X3.Visible = false;
            }
            if (txt2x3.Text != "1" && txt2x3.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt2x4.Text == "1")
            {
                PC2x4.Visible = true;
            }
            if (txt2x4.Text == "0")
            {
                PC2x4.Visible = false;
            }
            if (txt2x4.Text != "1" && txt2x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt3x1.Text == "1")
            {
                PC3x1.Visible = true;
            }
            if (txt3x1.Text == "0")
            {
                PC3x1.Visible = false;
            }
            if (txt3x1.Text != "1" && txt3x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt3x2.Text == "1")
            {
                //PC3x2.Visible = true;
            }
            if (txt3x2.Text == "0")
            {
                //PC3x2.Visible = false;
            }
            if (txt3x2.Text != "1" && txt3x2.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt3x3.Text == "1")
            {
                PC3x3.Visible = true;
            }
            if (txt3x3.Text == "0")
            {
                PC3x3.Visible = false;
            }
            if (txt3x3.Text != "1" && txt3x3.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt3x4.Text == "1")
            {
                PC3x4.Visible = true;
            }
            if (txt3x4.Text == "0")
            {
                PC3x4.Visible = false;
            }
            if (txt3x4.Text != "1" && txt3x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt4x4.Text == "1")
            {
                PC4x4.Visible = true;
            }
            if (txt4x4.Text == "0")
            {
                PC4x4.Visible = false;
            }
            if (txt4x4.Text != "1" && txt4x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt4x3.Text == "1")
            {
                PC4x3.Visible = true;
            }
            if (txt4x3.Text == "0")
            {
                PC4x3.Visible = false;
            }
            if (txt4x3.Text != "1" && txt4x3.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt4x2.Text == "1")
            {
                PC4x2.Visible = true;
            }
            if (txt4x2.Text == "0")
            {
                PC4x2.Visible = false;
            }
            if (txt4x2.Text != "1" && txt4x2.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt1x4.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea.DrawLine(blackPen, -10, 0, 700, 500);
            }
            if (txt1x4.Text == "0")
            {

            }
            if (txt1x4.Text != "1" && txt1x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt4x1.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea.DrawLine(blackPen, 0, 0, 750, 500); //4x1
            }
            if (txt4x1.Text == "0")
            {

            }
            if (txt4x1.Text != "1" && txt4x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt2x3.Text == "1")
            {
                Pen blackPen1 = new Pen(Color.Black);
                drawArea.DrawLine(blackPen1, 140, 0, 0, 90); //2x3
            }
            if (txt2x3.Text == "0")
            {

            }
            if (txt2x3.Text != "1" && txt2x3.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt3x2.Text == "1")
            {
                Pen blackPen1 = new Pen(Color.Black);
                drawArea.DrawLine(blackPen1, 150, 0, 0, 100); //3x2
            }
            if (txt3x2.Text == "0")
            {

            }
            if (txt3x2.Text != "1" && txt3x2.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
        }
    }
}
