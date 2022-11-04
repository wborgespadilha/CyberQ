namespace Exercício_09
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
            this.cbxConversao = new System.Windows.Forms.ComboBox();
            this.lblConversao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxConversao
            // 
            this.cbxConversao.FormattingEnabled = true;
            this.cbxConversao.Location = new System.Drawing.Point(186, 25);
            this.cbxConversao.Name = "cbxConversao";
            this.cbxConversao.Size = new System.Drawing.Size(182, 23);
            this.cbxConversao.TabIndex = 0;
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConversao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConversao.Location = new System.Drawing.Point(29, 28);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(133, 15);
            this.lblConversao.TabIndex = 1;
            this.lblConversao.Text = "Selecione a conversão:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(29, 81);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 15);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Insira o valor:";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(233, 78);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 23);
            this.txbValor.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverter.Location = new System.Drawing.Point(123, 142);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(127, 42);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(123, 235);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(127, 32);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // txbResultado
            // 
            this.txbResultado.Enabled = false;
            this.txbResultado.Location = new System.Drawing.Point(142, 318);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(86, 23);
            this.txbResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(385, 380);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.cbxConversao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxConversao;
        private Label lblConversao;
        private Label lblValor;
        private TextBox txbValor;
        private Button btnConverter;
        private Label lblResultado;
        private TextBox txbResultado;
    }
}