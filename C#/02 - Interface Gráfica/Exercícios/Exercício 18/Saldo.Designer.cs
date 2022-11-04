namespace Exercício_18
{
    partial class Saldo
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoCC = new System.Windows.Forms.Label();
            this.txbSaldoCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSaldoCP = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(198, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(68, 30);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblSaldoCC
            // 
            this.lblSaldoCC.AutoSize = true;
            this.lblSaldoCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoCC.Location = new System.Drawing.Point(12, 58);
            this.lblSaldoCC.Name = "lblSaldoCC";
            this.lblSaldoCC.Size = new System.Drawing.Size(171, 21);
            this.lblSaldoCC.TabIndex = 1;
            this.lblSaldoCC.Text = "Saldo Conta Corrente:";
            // 
            // txbSaldoCC
            // 
            this.txbSaldoCC.Enabled = false;
            this.txbSaldoCC.Location = new System.Drawing.Point(286, 56);
            this.txbSaldoCC.Name = "txbSaldoCC";
            this.txbSaldoCC.Size = new System.Drawing.Size(100, 23);
            this.txbSaldoCC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo Conta Poupança:";
            // 
            // txbSaldoCP
            // 
            this.txbSaldoCP.Enabled = false;
            this.txbSaldoCP.Location = new System.Drawing.Point(286, 95);
            this.txbSaldoCP.Name = "txbSaldoCP";
            this.txbSaldoCP.Size = new System.Drawing.Size(100, 23);
            this.txbSaldoCP.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(148, 146);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 40);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(441, 198);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txbSaldoCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSaldoCC);
            this.Controls.Add(this.lblSaldoCC);
            this.Controls.Add(this.lblSaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Saldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.Saldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaldo;
        private Label lblSaldoCC;
        private TextBox txbSaldoCC;
        private Label label1;
        private TextBox txbSaldoCP;
        private Button btnFechar;
    }
}