namespace Exercício_13
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
            this.lblConversao = new System.Windows.Forms.Label();
            this.cbxConversao = new System.Windows.Forms.ComboBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConversao.Location = new System.Drawing.Point(12, 19);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(164, 20);
            this.lblConversao.TabIndex = 0;
            this.lblConversao.Text = "Selecione a conversão:";
            // 
            // cbxConversao
            // 
            this.cbxConversao.FormattingEnabled = true;
            this.cbxConversao.Location = new System.Drawing.Point(12, 79);
            this.cbxConversao.Name = "cbxConversao";
            this.cbxConversao.Size = new System.Drawing.Size(227, 23);
            this.cbxConversao.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverter.Location = new System.Drawing.Point(76, 254);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(106, 42);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(76, 341);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 30);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Visible = false;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(76, 159);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 23);
            this.txbValor.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(86, 141);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(77, 15);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Insira o valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercício_13.Properties.Resources.Hatsune_Miku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cbxConversao);
            this.Controls.Add(this.lblConversao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConversao;
        private ComboBox cbxConversao;
        private Button btnConverter;
        private Label lblResultado;
        private TextBox txbValor;
        private Label lblValor;
    }
}