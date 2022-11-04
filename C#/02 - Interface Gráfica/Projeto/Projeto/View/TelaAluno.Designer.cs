namespace Projeto
{
    partial class TelaAluno
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
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNota = new System.Windows.Forms.Label();
            this.txbNota = new System.Windows.Forms.TextBox();
            this.dgvAvaliacoes = new System.Windows.Forms.DataGridView();
            this.Avaliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAluno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turma});
            this.dgvTurmas.Location = new System.Drawing.Point(27, 21);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.ReadOnly = true;
            this.dgvTurmas.RowTemplate.Height = 25;
            this.dgvTurmas.Size = new System.Drawing.Size(179, 394);
            this.dgvTurmas.TabIndex = 0;
            this.dgvTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellContentClick);
            // 
            // Turma
            // 
            this.Turma.HeaderText = "Turma";
            this.Turma.Name = "Turma";
            this.Turma.ReadOnly = true;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNota.Location = new System.Drawing.Point(513, 114);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(248, 37);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "Nota da avaliação";
            // 
            // txbNota
            // 
            this.txbNota.Enabled = false;
            this.txbNota.Location = new System.Drawing.Point(555, 184);
            this.txbNota.Name = "txbNota";
            this.txbNota.Size = new System.Drawing.Size(144, 23);
            this.txbNota.TabIndex = 3;
            // 
            // dgvAvaliacoes
            // 
            this.dgvAvaliacoes.AllowUserToAddRows = false;
            this.dgvAvaliacoes.AllowUserToDeleteRows = false;
            this.dgvAvaliacoes.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaliacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Avaliacao});
            this.dgvAvaliacoes.Location = new System.Drawing.Point(266, 21);
            this.dgvAvaliacoes.Name = "dgvAvaliacoes";
            this.dgvAvaliacoes.ReadOnly = true;
            this.dgvAvaliacoes.RowTemplate.Height = 25;
            this.dgvAvaliacoes.Size = new System.Drawing.Size(179, 394);
            this.dgvAvaliacoes.TabIndex = 4;
            this.dgvAvaliacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvaliacoes_CellContentClick);
            // 
            // Avaliacao
            // 
            this.Avaliacao.HeaderText = "Avaliacao";
            this.Avaliacao.Name = "Avaliacao";
            this.Avaliacao.ReadOnly = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(500, 325);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(261, 80);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAluno.Location = new System.Drawing.Point(555, 35);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(97, 32);
            this.lblAluno.TabIndex = 6;
            this.lblAluno.Text = "Aluno: ";
            // 
            // TelaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvAvaliacoes);
            this.Controls.Add(this.txbNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.dgvTurmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAluno";
            this.Load += new System.EventHandler(this.TelaAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaliacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTurmas;
        private DataGridViewTextBoxColumn Turma;
        private Label lblNota;
        private TextBox txbNota;
        private DataGridView dgvAvaliacoes;
        private DataGridViewTextBoxColumn Avaliacao;
        private Button btnFechar;
        private Label lblAluno;
    }
}