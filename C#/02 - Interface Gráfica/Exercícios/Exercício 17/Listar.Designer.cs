namespace Exercício_17
{
    partial class Listar
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
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblNumUsuarios = new System.Windows.Forms.Label();
            this.lblHomens = new System.Windows.Forms.Label();
            this.lblNumHomens = new System.Windows.Forms.Label();
            this.lblMulheres = new System.Windows.Forms.Label();
            this.lblNumMulheres = new System.Windows.Forms.Label();
            this.lbxEstados = new System.Windows.Forms.ListBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.lblPorcentagemHomens = new System.Windows.Forms.Label();
            this.lblPorcentagemMulheres = new System.Windows.Forms.Label();
            this.lblMaisVelha = new System.Windows.Forms.Label();
            this.txbVelha = new System.Windows.Forms.TextBox();
            this.lblNova = new System.Windows.Forms.Label();
            this.txbNova = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRelatorio.Location = new System.Drawing.Point(299, 9);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(194, 42);
            this.lblRelatorio.TabIndex = 0;
            this.lblRelatorio.Text = "Relatório:";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarios.Location = new System.Drawing.Point(12, 72);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(197, 25);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuários cadastrados:";
            // 
            // lblNumUsuarios
            // 
            this.lblNumUsuarios.AutoSize = true;
            this.lblNumUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumUsuarios.Location = new System.Drawing.Point(221, 72);
            this.lblNumUsuarios.Name = "lblNumUsuarios";
            this.lblNumUsuarios.Size = new System.Drawing.Size(23, 25);
            this.lblNumUsuarios.TabIndex = 2;
            this.lblNumUsuarios.Text = "0";
            // 
            // lblHomens
            // 
            this.lblHomens.AutoSize = true;
            this.lblHomens.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHomens.Location = new System.Drawing.Point(12, 112);
            this.lblHomens.Name = "lblHomens";
            this.lblHomens.Size = new System.Drawing.Size(195, 25);
            this.lblHomens.TabIndex = 3;
            this.lblHomens.Text = "Homens cadastrados:";
            // 
            // lblNumHomens
            // 
            this.lblNumHomens.AutoSize = true;
            this.lblNumHomens.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumHomens.Location = new System.Drawing.Point(221, 112);
            this.lblNumHomens.Name = "lblNumHomens";
            this.lblNumHomens.Size = new System.Drawing.Size(23, 25);
            this.lblNumHomens.TabIndex = 4;
            this.lblNumHomens.Text = "0";
            // 
            // lblMulheres
            // 
            this.lblMulheres.AutoSize = true;
            this.lblMulheres.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMulheres.Location = new System.Drawing.Point(12, 154);
            this.lblMulheres.Name = "lblMulheres";
            this.lblMulheres.Size = new System.Drawing.Size(203, 25);
            this.lblMulheres.TabIndex = 5;
            this.lblMulheres.Text = "Mulheres cadastradas:";
            // 
            // lblNumMulheres
            // 
            this.lblNumMulheres.AutoSize = true;
            this.lblNumMulheres.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumMulheres.Location = new System.Drawing.Point(221, 154);
            this.lblNumMulheres.Name = "lblNumMulheres";
            this.lblNumMulheres.Size = new System.Drawing.Size(23, 25);
            this.lblNumMulheres.TabIndex = 6;
            this.lblNumMulheres.Text = "0";
            // 
            // lbxEstados
            // 
            this.lbxEstados.FormattingEnabled = true;
            this.lbxEstados.ItemHeight = 15;
            this.lbxEstados.Location = new System.Drawing.Point(526, 93);
            this.lbxEstados.Name = "lbxEstados";
            this.lbxEstados.Size = new System.Drawing.Size(223, 304);
            this.lbxEstados.TabIndex = 7;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstados.Location = new System.Drawing.Point(542, 55);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(194, 25);
            this.lblEstados.TabIndex = 8;
            this.lblEstados.Text = "Usuários por estados:";
            // 
            // lblPorcentagemHomens
            // 
            this.lblPorcentagemHomens.AutoSize = true;
            this.lblPorcentagemHomens.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentagemHomens.Location = new System.Drawing.Point(250, 112);
            this.lblPorcentagemHomens.Name = "lblPorcentagemHomens";
            this.lblPorcentagemHomens.Size = new System.Drawing.Size(30, 25);
            this.lblPorcentagemHomens.TabIndex = 9;
            this.lblPorcentagemHomens.Text = "-  ";
            // 
            // lblPorcentagemMulheres
            // 
            this.lblPorcentagemMulheres.AutoSize = true;
            this.lblPorcentagemMulheres.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentagemMulheres.Location = new System.Drawing.Point(250, 154);
            this.lblPorcentagemMulheres.Name = "lblPorcentagemMulheres";
            this.lblPorcentagemMulheres.Size = new System.Drawing.Size(30, 25);
            this.lblPorcentagemMulheres.TabIndex = 10;
            this.lblPorcentagemMulheres.Text = "-  ";
            // 
            // lblMaisVelha
            // 
            this.lblMaisVelha.AutoSize = true;
            this.lblMaisVelha.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaisVelha.Location = new System.Drawing.Point(174, 222);
            this.lblMaisVelha.Name = "lblMaisVelha";
            this.lblMaisVelha.Size = new System.Drawing.Size(170, 25);
            this.lblMaisVelha.TabIndex = 11;
            this.lblMaisVelha.Text = "Pessoa mais velha:";
            // 
            // txbVelha
            // 
            this.txbVelha.Enabled = false;
            this.txbVelha.Location = new System.Drawing.Point(12, 260);
            this.txbVelha.Name = "txbVelha";
            this.txbVelha.Size = new System.Drawing.Size(491, 23);
            this.txbVelha.TabIndex = 12;
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNova.Location = new System.Drawing.Point(174, 314);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(166, 25);
            this.lblNova.TabIndex = 13;
            this.lblNova.Text = "Pessoa mais nova:";
            // 
            // txbNova
            // 
            this.txbNova.Enabled = false;
            this.txbNova.Location = new System.Drawing.Point(12, 359);
            this.txbNova.Name = "txbNova";
            this.txbNova.Size = new System.Drawing.Size(491, 23);
            this.txbNova.TabIndex = 14;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNova);
            this.Controls.Add(this.lblNova);
            this.Controls.Add(this.txbVelha);
            this.Controls.Add(this.lblMaisVelha);
            this.Controls.Add(this.lblPorcentagemMulheres);
            this.Controls.Add(this.lblPorcentagemHomens);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.lbxEstados);
            this.Controls.Add(this.lblNumMulheres);
            this.Controls.Add(this.lblMulheres);
            this.Controls.Add(this.lblNumHomens);
            this.Controls.Add(this.lblHomens);
            this.Controls.Add(this.lblNumUsuarios);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.lblRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Listar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Listar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRelatorio;
        private Label lblUsuarios;
        private Label lblNumUsuarios;
        private Label lblHomens;
        private Label lblNumHomens;
        private Label lblMulheres;
        private Label lblNumMulheres;
        private ListBox lbxEstados;
        private Label lblEstados;
        private Label lblPorcentagemHomens;
        private Label lblPorcentagemMulheres;
        private Label lblMaisVelha;
        private TextBox txbVelha;
        private Label lblNova;
        private TextBox txbNova;
    }
}