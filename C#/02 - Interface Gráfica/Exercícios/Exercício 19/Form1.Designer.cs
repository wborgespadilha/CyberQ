namespace Exercício_19
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txbOldName = new System.Windows.Forms.TextBox();
            this.lblOldName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbNameDelete = new System.Windows.Forms.TextBox();
            this.lblNameDelete = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txbValorProduto = new System.Windows.Forms.TextBox();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMarcaProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbxListaProdutos = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.lbxEstatisticas = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.txbNome);
            this.tabPage1.Controls.Add(this.lblCadastrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(309, 235);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 61);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(237, 134);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(327, 23);
            this.txbNome.TabIndex = 1;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastrar.Location = new System.Drawing.Point(290, 49);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(225, 25);
            this.lblCadastrar.TabIndex = 0;
            this.lblCadastrar.Text = "Insira o nome da marca:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.txbNewName);
            this.tabPage2.Controls.Add(this.lblNewName);
            this.tabPage2.Controls.Add(this.txbOldName);
            this.tabPage2.Controls.Add(this.lblOldName);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(272, 336);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(187, 47);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txbNewName
            // 
            this.txbNewName.Location = new System.Drawing.Point(193, 272);
            this.txbNewName.Name = "txbNewName";
            this.txbNewName.Size = new System.Drawing.Size(348, 23);
            this.txbNewName.TabIndex = 4;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewName.Location = new System.Drawing.Point(229, 210);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(276, 25);
            this.lblNewName.TabIndex = 3;
            this.lblNewName.Text = "Insira o novo nome da marca:";
            // 
            // txbOldName
            // 
            this.txbOldName.Location = new System.Drawing.Point(193, 127);
            this.txbOldName.Name = "txbOldName";
            this.txbOldName.Size = new System.Drawing.Size(348, 23);
            this.txbOldName.TabIndex = 2;
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOldName.Location = new System.Drawing.Point(229, 47);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(288, 25);
            this.lblOldName.TabIndex = 1;
            this.lblOldName.Text = "Insira o antigo nome da marca:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.txbNameDelete);
            this.tabPage3.Controls.Add(this.lblNameDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(798, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remover";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(309, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 61);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbNameDelete
            // 
            this.txbNameDelete.Location = new System.Drawing.Point(237, 134);
            this.txbNameDelete.Name = "txbNameDelete";
            this.txbNameDelete.Size = new System.Drawing.Size(327, 23);
            this.txbNameDelete.TabIndex = 2;
            // 
            // lblNameDelete
            // 
            this.lblNameDelete.AutoSize = true;
            this.lblNameDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameDelete.Location = new System.Drawing.Point(290, 49);
            this.lblNameDelete.Name = "lblNameDelete";
            this.lblNameDelete.Size = new System.Drawing.Size(225, 25);
            this.lblNameDelete.TabIndex = 1;
            this.lblNameDelete.Text = "Insira o nome da marca:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage4.Controls.Add(this.txbValorProduto);
            this.tabPage4.Controls.Add(this.lblValorProduto);
            this.tabPage4.Controls.Add(this.btnCadastrarProduto);
            this.tabPage4.Controls.Add(this.txbProduto);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txbMarcaProduto);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(798, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cadastrar Produtos";
            // 
            // txbValorProduto
            // 
            this.txbValorProduto.Location = new System.Drawing.Point(26, 354);
            this.txbValorProduto.Name = "txbValorProduto";
            this.txbValorProduto.Size = new System.Drawing.Size(327, 23);
            this.txbValorProduto.TabIndex = 8;
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorProduto.Location = new System.Drawing.Point(58, 298);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(242, 25);
            this.lblValorProduto.TabIndex = 7;
            this.lblValorProduto.Text = "Insira o valor do produto:";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarProduto.Location = new System.Drawing.Point(508, 172);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(194, 85);
            this.btnCadastrarProduto.TabIndex = 6;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(26, 242);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(327, 23);
            this.txbProduto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira o nome do produto:";
            // 
            // txbMarcaProduto
            // 
            this.txbMarcaProduto.Location = new System.Drawing.Point(26, 112);
            this.txbMarcaProduto.Name = "txbMarcaProduto";
            this.txbMarcaProduto.Size = new System.Drawing.Size(327, 23);
            this.txbMarcaProduto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o nome da marca:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage5.Controls.Add(this.btnListar);
            this.tabPage5.Controls.Add(this.lbxListaProdutos);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(798, 425);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Listar Produtos";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListar.Location = new System.Drawing.Point(96, 147);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(210, 99);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbxListaProdutos
            // 
            this.lbxListaProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
            this.lbxListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxListaProdutos.FormattingEnabled = true;
            this.lbxListaProdutos.ItemHeight = 15;
            this.lbxListaProdutos.Location = new System.Drawing.Point(409, 51);
            this.lbxListaProdutos.Name = "lbxListaProdutos";
            this.lbxListaProdutos.Size = new System.Drawing.Size(376, 362);
            this.lbxListaProdutos.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage6.Controls.Add(this.btnEstatisticas);
            this.tabPage6.Controls.Add(this.lbxEstatisticas);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(798, 425);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Estatísticas";
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstatisticas.Location = new System.Drawing.Point(96, 147);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(210, 99);
            this.btnEstatisticas.TabIndex = 2;
            this.btnEstatisticas.Text = "Listar";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // lbxEstatisticas
            // 
            this.lbxEstatisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(130)))), ((int)(((byte)(55)))));
            this.lbxEstatisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxEstatisticas.FormattingEnabled = true;
            this.lbxEstatisticas.ItemHeight = 15;
            this.lbxEstatisticas.Location = new System.Drawing.Point(409, 51);
            this.lbxEstatisticas.Name = "lbxEstatisticas";
            this.lbxEstatisticas.Size = new System.Drawing.Size(376, 362);
            this.lbxEstatisticas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button btnCadastrar;
        private TextBox txbNome;
        private Label lblCadastrar;
        private Button btnAlterar;
        private TextBox txbNewName;
        private Label lblNewName;
        private TextBox txbOldName;
        private Label lblOldName;
        private Button btnDelete;
        private TextBox txbNameDelete;
        private Label lblNameDelete;
        private Button btnCadastrarProduto;
        private TextBox txbProduto;
        private Label label2;
        private TextBox txbMarcaProduto;
        private Label label1;
        private Button btnListar;
        private ListBox lbxListaProdutos;
        private Button btnEstatisticas;
        private ListBox lbxEstatisticas;
        private TextBox txbValorProduto;
        private Label lblValorProduto;
    }
}