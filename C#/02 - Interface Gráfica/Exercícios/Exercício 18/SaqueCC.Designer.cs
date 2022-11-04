namespace Exercício_18
{
    partial class SaqueCC
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
            this.lblSaque = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaque.Location = new System.Drawing.Point(58, 25);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(228, 30);
            this.lblSaque.TabIndex = 0;
            this.lblSaque.Text = "Saque Conta Corrente";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(31, 86);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(77, 30);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // txbSaldo
            // 
            this.txbSaldo.Enabled = false;
            this.txbSaldo.Location = new System.Drawing.Point(203, 86);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(100, 23);
            this.txbSaldo.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(31, 134);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(143, 30);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Insira o valor:";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(203, 143);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 23);
            this.txbValor.TabIndex = 4;
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacar.Location = new System.Drawing.Point(108, 197);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(123, 39);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(95, 260);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(152, 30);
            this.lblErro.TabIndex = 6;
            this.lblErro.Text = "Saque inválido";
            this.lblErro.Visible = false;
            // 
            // SaqueCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(337, 320);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txbSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaqueCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaqueCC";
            this.Load += new System.EventHandler(this.SaqueCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaque;
        private Label lblSaldo;
        private TextBox txbSaldo;
        private Label lblValor;
        private TextBox txbValor;
        private Button btnSacar;
        private Label lblErro;
    }
}