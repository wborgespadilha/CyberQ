namespace Exercício_02
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.txbNota3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(314, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(228, 30);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Insira o nome do aluno";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(270, 77);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(331, 23);
            this.txbNome.TabIndex = 1;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(51, 143);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(81, 15);
            this.lblNota1.TabIndex = 2;
            this.lblNota1.Text = "Primeira nota:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(384, 146);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(83, 15);
            this.lblNota2.TabIndex = 3;
            this.lblNota2.Text = "Segunda nota:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(676, 143);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(77, 15);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Terceira nota:";
            // 
            // txbNota1
            // 
            this.txbNota1.Location = new System.Drawing.Point(61, 180);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(59, 23);
            this.txbNota1.TabIndex = 5;
            // 
            // txbNota2
            // 
            this.txbNota2.Location = new System.Drawing.Point(398, 180);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(57, 23);
            this.txbNota2.TabIndex = 6;
            // 
            // txbNota3
            // 
            this.txbNota3.Location = new System.Drawing.Point(691, 180);
            this.txbNota3.Name = "txbNota3";
            this.txbNota3.Size = new System.Drawing.Size(48, 23);
            this.txbNota3.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(310, 361);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(217, 77);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular Situação";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercício_02.Properties.Resources.Spy_x_Family_anya_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbNota3);
            this.Controls.Add(this.txbNota2);
            this.Controls.Add(this.txbNota1);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txbNome;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private TextBox txbNota1;
        private TextBox txbNota2;
        private TextBox txbNota3;
        private Button btnCalcular;
    }
}