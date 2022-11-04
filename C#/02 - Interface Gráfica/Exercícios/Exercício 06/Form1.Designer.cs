namespace Exercício_06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInsira = new System.Windows.Forms.Label();
            this.txbLado1 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.txbLado2 = new System.Windows.Forms.TextBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txbLado3 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInsira.Location = new System.Drawing.Point(257, 38);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(266, 23);
            this.lblInsira.TabIndex = 0;
            this.lblInsira.Text = "Insira os valores dos lados";
            // 
            // txbLado1
            // 
            this.txbLado1.Location = new System.Drawing.Point(132, 119);
            this.txbLado1.Name = "txbLado1";
            this.txbLado1.Size = new System.Drawing.Size(100, 23);
            this.txbLado1.TabIndex = 1;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(52, 122);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(45, 15);
            this.lblLado1.TabIndex = 2;
            this.lblLado1.Text = "Lado 1:";
            // 
            // txbLado2
            // 
            this.txbLado2.Location = new System.Drawing.Point(358, 119);
            this.txbLado2.Name = "txbLado2";
            this.txbLado2.Size = new System.Drawing.Size(100, 23);
            this.txbLado2.TabIndex = 3;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(286, 122);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(45, 15);
            this.lblLado2.TabIndex = 4;
            this.lblLado2.Text = "Lado 2:";
            // 
            // txbLado3
            // 
            this.txbLado3.Location = new System.Drawing.Point(595, 119);
            this.txbLado3.Name = "txbLado3";
            this.txbLado3.Size = new System.Drawing.Size(100, 23);
            this.txbLado3.TabIndex = 5;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(528, 122);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(45, 15);
            this.lblLado3.TabIndex = 6;
            this.lblLado3.Text = "Lado 3:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(316, 201);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(173, 37);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTriangulo.Location = new System.Drawing.Point(257, 306);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(108, 23);
            this.lblTriangulo.TabIndex = 8;
            this.lblTriangulo.Text = "Triângulo:";
            this.lblTriangulo.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Enabled = false;
            this.lblResultado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(390, 306);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.txbLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.txbLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.txbLado1);
            this.Controls.Add(this.lblInsira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsira;
        private TextBox txbLado1;
        private Label lblLado1;
        private TextBox txbLado2;
        private Label lblLado2;
        private TextBox txbLado3;
        private Label lblLado3;
        private Button btnCalcular;
        private Label lblTriangulo;
        private Label lblResultado;
    }
}