namespace Exercício_18
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbAgencia = new System.Windows.Forms.TextBox();
            this.txbConta = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbLogar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(107, 31);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 32);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgencia.Location = new System.Drawing.Point(28, 99);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(94, 30);
            this.lblAgencia.TabIndex = 1;
            this.lblAgencia.Text = "Agência:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConta.Location = new System.Drawing.Point(28, 142);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(75, 30);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(28, 187);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(75, 30);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txbAgencia
            // 
            this.txbAgencia.Location = new System.Drawing.Point(166, 106);
            this.txbAgencia.Name = "txbAgencia";
            this.txbAgencia.Size = new System.Drawing.Size(100, 23);
            this.txbAgencia.TabIndex = 4;
            // 
            // txbConta
            // 
            this.txbConta.Location = new System.Drawing.Point(166, 149);
            this.txbConta.Name = "txbConta";
            this.txbConta.Size = new System.Drawing.Size(100, 23);
            this.txbConta.TabIndex = 5;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(166, 194);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 23);
            this.txbSenha.TabIndex = 6;
            // 
            // txbLogar
            // 
            this.txbLogar.Location = new System.Drawing.Point(95, 249);
            this.txbLogar.Name = "txbLogar";
            this.txbLogar.Size = new System.Drawing.Size(106, 44);
            this.txbLogar.TabIndex = 7;
            this.txbLogar.Text = "Logar";
            this.txbLogar.UseVisualStyleBackColor = true;
            this.txbLogar.Click += new System.EventHandler(this.txbLogar_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(73, 322);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(160, 30);
            this.lblErro.TabIndex = 8;
            this.lblErro.Text = "Login incorreto";
            this.lblErro.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(311, 369);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txbLogar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbConta);
            this.Controls.Add(this.txbAgencia);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogin;
        private Label lblAgencia;
        private Label lblConta;
        private Label lblSenha;
        private TextBox txbAgencia;
        private TextBox txbConta;
        private TextBox txbSenha;
        private Button txbLogar;
        private Label lblErro;
    }
}