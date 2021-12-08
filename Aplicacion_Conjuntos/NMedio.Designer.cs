
namespace Aplicacion_Conjuntos
{
    partial class NMedio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMedio = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(340, 613);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 63);
            this.lblResultado.TabIndex = 21;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedio
            // 
            this.btnMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.Location = new System.Drawing.Point(442, 211);
            this.btnMedio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(254, 117);
            this.btnMedio.TabIndex = 20;
            this.btnMedio.Text = "Calcular";
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(36, 397);
            this.txtC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(196, 68);
            this.txtC.TabIndex = 19;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(36, 260);
            this.txtB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(196, 68);
            this.txtB.TabIndex = 18;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(36, 119);
            this.txtA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(196, 68);
            this.txtA.TabIndex = 17;
            // 
            // NMedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 775);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NMedio";
            this.Text = "NMedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
    }
}