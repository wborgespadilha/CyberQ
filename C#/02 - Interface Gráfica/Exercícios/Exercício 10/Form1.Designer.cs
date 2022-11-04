namespace Exercício_10
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
            this.lblNotas = new System.Windows.Forms.Label();
            this.lbl2Reais = new System.Windows.Forms.Label();
            this.lbl5Reais = new System.Windows.Forms.Label();
            this.lbl10Reais = new System.Windows.Forms.Label();
            this.lbl20Reais = new System.Windows.Forms.Label();
            this.lbl50Reais = new System.Windows.Forms.Label();
            this.lbl100Reais = new System.Windows.Forms.Label();
            this.lbl200Reais = new System.Windows.Forms.Label();
            this.btnCalcularMontante = new System.Windows.Forms.Button();
            this.txb2Reais = new System.Windows.Forms.TextBox();
            this.txb5Reais = new System.Windows.Forms.TextBox();
            this.txb10Reais = new System.Windows.Forms.TextBox();
            this.txb20Reais = new System.Windows.Forms.TextBox();
            this.txb50Reais = new System.Windows.Forms.TextBox();
            this.txb100Reais = new System.Windows.Forms.TextBox();
            this.txb200Reais = new System.Windows.Forms.TextBox();
            this.lblMontante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotas.Location = new System.Drawing.Point(35, 18);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(304, 32);
            this.lblNotas.TabIndex = 0;
            this.lblNotas.Text = "Insira a quantia de notas:";
            // 
            // lbl2Reais
            // 
            this.lbl2Reais.AutoSize = true;
            this.lbl2Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2Reais.Location = new System.Drawing.Point(86, 91);
            this.lbl2Reais.Name = "lbl2Reais";
            this.lbl2Reais.Size = new System.Drawing.Size(49, 15);
            this.lbl2Reais.TabIndex = 1;
            this.lbl2Reais.Text = "2 Reais:";
            // 
            // lbl5Reais
            // 
            this.lbl5Reais.AutoSize = true;
            this.lbl5Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5Reais.Location = new System.Drawing.Point(86, 125);
            this.lbl5Reais.Name = "lbl5Reais";
            this.lbl5Reais.Size = new System.Drawing.Size(49, 15);
            this.lbl5Reais.TabIndex = 2;
            this.lbl5Reais.Text = "5 Reais:";
            // 
            // lbl10Reais
            // 
            this.lbl10Reais.AutoSize = true;
            this.lbl10Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl10Reais.Location = new System.Drawing.Point(86, 159);
            this.lbl10Reais.Name = "lbl10Reais";
            this.lbl10Reais.Size = new System.Drawing.Size(56, 15);
            this.lbl10Reais.TabIndex = 3;
            this.lbl10Reais.Text = "10 Reais:";
            // 
            // lbl20Reais
            // 
            this.lbl20Reais.AutoSize = true;
            this.lbl20Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl20Reais.Location = new System.Drawing.Point(86, 193);
            this.lbl20Reais.Name = "lbl20Reais";
            this.lbl20Reais.Size = new System.Drawing.Size(56, 15);
            this.lbl20Reais.TabIndex = 4;
            this.lbl20Reais.Text = "20 Reais:";
            // 
            // lbl50Reais
            // 
            this.lbl50Reais.AutoSize = true;
            this.lbl50Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl50Reais.Location = new System.Drawing.Point(86, 228);
            this.lbl50Reais.Name = "lbl50Reais";
            this.lbl50Reais.Size = new System.Drawing.Size(56, 15);
            this.lbl50Reais.TabIndex = 5;
            this.lbl50Reais.Text = "50 Reais:";
            // 
            // lbl100Reais
            // 
            this.lbl100Reais.AutoSize = true;
            this.lbl100Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl100Reais.Location = new System.Drawing.Point(86, 265);
            this.lbl100Reais.Name = "lbl100Reais";
            this.lbl100Reais.Size = new System.Drawing.Size(63, 15);
            this.lbl100Reais.TabIndex = 6;
            this.lbl100Reais.Text = "100 Reais:";
            // 
            // lbl200Reais
            // 
            this.lbl200Reais.AutoSize = true;
            this.lbl200Reais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl200Reais.Location = new System.Drawing.Point(86, 302);
            this.lbl200Reais.Name = "lbl200Reais";
            this.lbl200Reais.Size = new System.Drawing.Size(63, 15);
            this.lbl200Reais.TabIndex = 7;
            this.lbl200Reais.Text = "200 Reais:";
            // 
            // btnCalcularMontante
            // 
            this.btnCalcularMontante.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularMontante.Location = new System.Drawing.Point(109, 351);
            this.btnCalcularMontante.Name = "btnCalcularMontante";
            this.btnCalcularMontante.Size = new System.Drawing.Size(153, 48);
            this.btnCalcularMontante.TabIndex = 8;
            this.btnCalcularMontante.Text = "Calcular Montante";
            this.btnCalcularMontante.UseVisualStyleBackColor = true;
            this.btnCalcularMontante.Click += new System.EventHandler(this.btnCalcularMontante_Click);
            // 
            // txb2Reais
            // 
            this.txb2Reais.Location = new System.Drawing.Point(226, 88);
            this.txb2Reais.Name = "txb2Reais";
            this.txb2Reais.Size = new System.Drawing.Size(68, 23);
            this.txb2Reais.TabIndex = 9;
            // 
            // txb5Reais
            // 
            this.txb5Reais.Location = new System.Drawing.Point(226, 122);
            this.txb5Reais.Name = "txb5Reais";
            this.txb5Reais.Size = new System.Drawing.Size(68, 23);
            this.txb5Reais.TabIndex = 10;
            // 
            // txb10Reais
            // 
            this.txb10Reais.Location = new System.Drawing.Point(226, 156);
            this.txb10Reais.Name = "txb10Reais";
            this.txb10Reais.Size = new System.Drawing.Size(68, 23);
            this.txb10Reais.TabIndex = 11;
            // 
            // txb20Reais
            // 
            this.txb20Reais.Location = new System.Drawing.Point(226, 190);
            this.txb20Reais.Name = "txb20Reais";
            this.txb20Reais.Size = new System.Drawing.Size(68, 23);
            this.txb20Reais.TabIndex = 12;
            // 
            // txb50Reais
            // 
            this.txb50Reais.Location = new System.Drawing.Point(226, 225);
            this.txb50Reais.Name = "txb50Reais";
            this.txb50Reais.Size = new System.Drawing.Size(68, 23);
            this.txb50Reais.TabIndex = 13;
            // 
            // txb100Reais
            // 
            this.txb100Reais.Location = new System.Drawing.Point(226, 262);
            this.txb100Reais.Name = "txb100Reais";
            this.txb100Reais.Size = new System.Drawing.Size(68, 23);
            this.txb100Reais.TabIndex = 14;
            // 
            // txb200Reais
            // 
            this.txb200Reais.Location = new System.Drawing.Point(226, 299);
            this.txb200Reais.Name = "txb200Reais";
            this.txb200Reais.Size = new System.Drawing.Size(68, 23);
            this.txb200Reais.TabIndex = 15;
            // 
            // lblMontante
            // 
            this.lblMontante.AutoSize = true;
            this.lblMontante.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontante.Location = new System.Drawing.Point(86, 440);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(0, 33);
            this.lblMontante.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(375, 528);
            this.Controls.Add(this.lblMontante);
            this.Controls.Add(this.txb200Reais);
            this.Controls.Add(this.txb100Reais);
            this.Controls.Add(this.txb50Reais);
            this.Controls.Add(this.txb20Reais);
            this.Controls.Add(this.txb10Reais);
            this.Controls.Add(this.txb5Reais);
            this.Controls.Add(this.txb2Reais);
            this.Controls.Add(this.btnCalcularMontante);
            this.Controls.Add(this.lbl200Reais);
            this.Controls.Add(this.lbl100Reais);
            this.Controls.Add(this.lbl50Reais);
            this.Controls.Add(this.lbl20Reais);
            this.Controls.Add(this.lbl10Reais);
            this.Controls.Add(this.lbl5Reais);
            this.Controls.Add(this.lbl2Reais);
            this.Controls.Add(this.lblNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNotas;
        private Label lbl2Reais;
        private Label lbl5Reais;
        private Label lbl10Reais;
        private Label lbl20Reais;
        private Label lbl50Reais;
        private Label lbl100Reais;
        private Label lbl200Reais;
        private Button btnCalcularMontante;
        private TextBox txb2Reais;
        private TextBox txb5Reais;
        private TextBox txb10Reais;
        private TextBox txb20Reais;
        private TextBox txb50Reais;
        private TextBox txb100Reais;
        private TextBox txb200Reais;
        private Label lblMontante;
    }
}