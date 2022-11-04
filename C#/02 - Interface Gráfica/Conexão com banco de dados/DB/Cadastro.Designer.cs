namespace DB
{
    partial class Cadastro
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.btnCadastrarPessoa = new System.Windows.Forms.Button();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarPessoas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(132, 43);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(216, 23);
            this.txbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(21, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(21, 103);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(67, 25);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade:";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(132, 108);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(216, 23);
            this.txbIdade.TabIndex = 3;
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(107, 170);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(187, 40);
            this.btnCadastrarPessoa.TabIndex = 4;
            this.btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = true;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Idade});
            this.dgvPessoas.Location = new System.Drawing.Point(438, 43);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowTemplate.Height = 25;
            this.dgvPessoas.Size = new System.Drawing.Size(329, 380);
            this.dgvPessoas.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // btnListarPessoas
            // 
            this.btnListarPessoas.Location = new System.Drawing.Point(72, 310);
            this.btnListarPessoas.Name = "btnListarPessoas";
            this.btnListarPessoas.Size = new System.Drawing.Size(250, 67);
            this.btnListarPessoas.TabIndex = 6;
            this.btnListarPessoas.Text = "Listar Pessoas";
            this.btnListarPessoas.UseVisualStyleBackColor = true;
            this.btnListarPessoas.Click += new System.EventHandler(this.btnListarPessoas_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarPessoas);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.btnCadastrarPessoa);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNome;
        private Label lblNome;
        private Label lblIdade;
        private TextBox txbIdade;
        private Button btnCadastrarPessoa;
        private DataGridView dgvPessoas;
        private Button btnListarPessoas;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
    }
}