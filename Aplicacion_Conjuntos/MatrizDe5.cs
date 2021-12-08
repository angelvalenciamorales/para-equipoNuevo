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
    public partial class MatrizDe5 : Form
    {
        Graphics drawArea;
        Graphics drawArea1;
        public MatrizDe5()
        {
            InitializeComponent();
            drawArea1 = drawingArea1.CreateGraphics();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
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
            if (txt1x4.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, 100, 0, -10, 500);
            }
            if (txt1x4.Text == "0")
            {

            }
            if (txt1x4.Text != "1" && txt1x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt1x5.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, 175, 0, 250, 500);
            }
            if (txt1x5.Text == "0")
            {

            }
            if (txt1x5.Text != "1" && txt1x5.Text != "0")
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
                PC2x3.Visible = true;
            }
            if (txt2x3.Text == "0")
            {
                PC2x3.Visible = false;
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
            if (txt2x5.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, -100, 50, 300, 320);
            }
            if (txt2x5.Text == "0")
            {

            }
            if (txt2x5.Text != "1" && txt2x5.Text != "0")
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
                PC3x2.Visible = true;
            }
            if (txt3x2.Text == "0")
            {
                PC3x2.Visible = false;

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
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, 250, 100, 0, 280);
            }
            if (txt3x4.Text == "0")
            {

            }
            if (txt3x4.Text != "1" && txt3x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt3x5.Text == "1")
            {
                PC3x5.Visible = true;
            }
            if (txt3x5.Text == "0")
            {
                PC3x5.Visible = false;
            }
            if (txt3x5.Text != "1" && txt3x5.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt4x1.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, 110, 0, 0, 500);
            }
            if (txt4x1.Text == "0")
            {

            }
            if (txt4x1.Text != "1" && txt4x1.Text != "0")
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
            if (txt4x3.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, 230, 100, -20, 280);
            }
            if (txt4x3.Text == "0")
            {

            }
            if (txt4x3.Text != "1" && txt4x3.Text != "0")
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
            if (txt4x5.Text == "1")
            {
                PC4x5.Visible = true;
            }
            if (txt4x5.Text == "0")
            {
                PC4x5.Visible = false;
            }
            if (txt4x5.Text != "1" && txt4x5.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt5x1.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, 155, 0, 230, 500);
            }
            if (txt5x1.Text == "0")
            {

            }
            if (txt5x1.Text != "1" && txt5x1.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt5x2.Text == "1")
            {
                Pen blackPen = new Pen(Color.Black);
                drawArea1.DrawLine(blackPen, -70, 50, 270, 280);
            }
            if (txt5x2.Text == "0")
            {

            }
            if (txt5x2.Text != "1" && txt5x2.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt5x3.Text == "1")
            {
                PC5x3.Visible = true;
            }
            if (txt5x3.Text == "0")
            {
                PC5x3.Visible = false;
            }
            if (txt5x3.Text != "1" && txt5x3.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt5x4.Text == "1")
            {
                PC5x4.Visible = true;
            }
            if (txt5x4.Text == "0")
            {
                PC5x4.Visible = false;
            }
            if (txt5x4.Text != "1" && txt5x4.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
            if (txt5x5.Text == "1")
            {
                PC5x5.Visible = true;
            }
            if (txt5x5.Text == "0")
            {
                PC5x5.Visible = false;
            }
            if (txt5x5.Text != "1" && txt5x5.Text != "0")
            {
                MessageBox.Show("Error: Solo se admiten 1 y 0");
            }
        }
    }
}
