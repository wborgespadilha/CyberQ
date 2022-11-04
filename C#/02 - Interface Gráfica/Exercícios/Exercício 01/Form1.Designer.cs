namespace Exercício_01
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
            this.lblInsiraONome = new System.Windows.Forms.Label();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.txbValorProduto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInsiraONome
            // 
            this.lblInsiraONome.AutoSize = true;
            this.lblInsiraONome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsiraONome.Location = new System.Drawing.Point(278, 27);
            this.lblInsiraONome.Name = "lblInsiraONome";
            this.lblInsiraONome.Size = new System.Drawing.Size(227, 25);
            this.lblInsiraONome.TabIndex = 0;
            this.lblInsiraONome.Text = "Insira o nome do produto";
            this.lblInsiraONome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Location = new System.Drawing.Point(278, 68);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(227, 23);
            this.txbNomeProduto.TabIndex = 1;
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorProduto.Location = new System.Drawing.Point(284, 110);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(221, 25);
            this.lblValorProduto.TabIndex = 2;
            this.lblValorProduto.Text = "Insira o valor do produto";
            // 
            // txbValorProduto
            // 
            this.txbValorProduto.Location = new System.Drawing.Point(358, 149);
            this.txbValorProduto.Name = "txbValorProduto";
            this.txbValorProduto.Size = new System.Drawing.Size(75, 23);
            this.txbValorProduto.TabIndex = 3;
            this.txbValorProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(358, 202);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbValorProduto);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.txbNomeProduto);
            this.Controls.Add(this.lblInsiraONome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsiraONome;
        private TextBox txbNomeProduto;
        private Label lblValorProduto;
        private TextBox txbValorProduto;
        private Button btnEnviar;
    }
}