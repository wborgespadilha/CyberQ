namespace Exercício_18
{
    partial class Caixa
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnSaqueCC = new System.Windows.Forms.Button();
            this.btnSaqueCP = new System.Windows.Forms.Button();
            this.btnDepositoCC = new System.Windows.Forms.Button();
            this.btnDepositoCP = new System.Windows.Forms.Button();
            this.btnEmpréstimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(50, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(170, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Seja bem vindo ";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaldo.Location = new System.Drawing.Point(12, 122);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(300, 48);
            this.btnSaldo.TabIndex = 2;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtrato.Location = new System.Drawing.Point(12, 186);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(300, 48);
            this.btnExtrato.TabIndex = 3;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnSaqueCC
            // 
            this.btnSaqueCC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaqueCC.Location = new System.Drawing.Point(12, 252);
            this.btnSaqueCC.Name = "btnSaqueCC";
            this.btnSaqueCC.Size = new System.Drawing.Size(300, 48);
            this.btnSaqueCC.TabIndex = 4;
            this.btnSaqueCC.Text = "Saque Conta Corrente";
            this.btnSaqueCC.UseVisualStyleBackColor = true;
            this.btnSaqueCC.Click += new System.EventHandler(this.btnSaqueCC_Click);
            // 
            // btnSaqueCP
            // 
            this.btnSaqueCP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaqueCP.Location = new System.Drawing.Point(12, 318);
            this.btnSaqueCP.Name = "btnSaqueCP";
            this.btnSaqueCP.Size = new System.Drawing.Size(300, 48);
            this.btnSaqueCP.TabIndex = 5;
            this.btnSaqueCP.Text = "Saque Conta Poupança";
            this.btnSaqueCP.UseVisualStyleBackColor = true;
            this.btnSaqueCP.Click += new System.EventHandler(this.btnSaqueCP_Click);
            // 
            // btnDepositoCC
            // 
            this.btnDepositoCC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepositoCC.Location = new System.Drawing.Point(12, 384);
            this.btnDepositoCC.Name = "btnDepositoCC";
            this.btnDepositoCC.Size = new System.Drawing.Size(300, 48);
            this.btnDepositoCC.TabIndex = 6;
            this.btnDepositoCC.Text = "Depósito Conta Corrente";
            this.btnDepositoCC.UseVisualStyleBackColor = true;
            this.btnDepositoCC.Click += new System.EventHandler(this.btnDepositoCC_Click);
            // 
            // btnDepositoCP
            // 
            this.btnDepositoCP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepositoCP.Location = new System.Drawing.Point(12, 450);
            this.btnDepositoCP.Name = "btnDepositoCP";
            this.btnDepositoCP.Size = new System.Drawing.Size(300, 48);
            this.btnDepositoCP.TabIndex = 7;
            this.btnDepositoCP.Text = "Depósito Conta Poupança";
            this.btnDepositoCP.UseVisualStyleBackColor = true;
            this.btnDepositoCP.Click += new System.EventHandler(this.btnDepositoCP_Click);
            // 
            // btnEmpréstimo
            // 
            this.btnEmpréstimo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmpréstimo.Location = new System.Drawing.Point(12, 518);
            this.btnEmpréstimo.Name = "btnEmpréstimo";
            this.btnEmpréstimo.Size = new System.Drawing.Size(300, 48);
            this.btnEmpréstimo.TabIndex = 8;
            this.btnEmpréstimo.Text = "Empréstimo";
            this.btnEmpréstimo.UseVisualStyleBackColor = true;
            this.btnEmpréstimo.Click += new System.EventHandler(this.btnEmpréstimo_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(324, 585);
            this.Controls.Add(this.btnEmpréstimo);
            this.Controls.Add(this.btnDepositoCP);
            this.Controls.Add(this.btnDepositoCC);
            this.Controls.Add(this.btnSaqueCP);
            this.Controls.Add(this.btnSaqueCC);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Button btnSaldo;
        private Button btnExtrato;
        private Button btnSaqueCC;
        private Button btnSaqueCP;
        private Button btnDepositoCC;
        private Button btnDepositoCP;
        private Button btnEmpréstimo;
    }
}