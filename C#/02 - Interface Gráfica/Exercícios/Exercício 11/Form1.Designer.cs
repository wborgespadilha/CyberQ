namespace Exercício_11
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
            this.lblSelecione = new System.Windows.Forms.Label();
            this.cbxConversao = new System.Windows.Forms.ComboBox();
            this.lblInsiraValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoValor = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelecione.Location = new System.Drawing.Point(37, 25);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(273, 32);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "Selecione a conversão:";
            // 
            // cbxConversao
            // 
            this.cbxConversao.FormattingEnabled = true;
            this.cbxConversao.Location = new System.Drawing.Point(72, 77);
            this.cbxConversao.Name = "cbxConversao";
            this.cbxConversao.Size = new System.Drawing.Size(199, 23);
            this.cbxConversao.TabIndex = 1;
            // 
            // lblInsiraValor
            // 
            this.lblInsiraValor.AutoSize = true;
            this.lblInsiraValor.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInsiraValor.Location = new System.Drawing.Point(97, 134);
            this.lblInsiraValor.Name = "lblInsiraValor";
            this.lblInsiraValor.Size = new System.Drawing.Size(143, 30);
            this.lblInsiraValor.TabIndex = 2;
            this.lblInsiraValor.Text = "Insira o valor:";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(109, 197);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(112, 23);
            this.txbValor.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(109, 317);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(122, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Visible = false;
            // 
            // lblResultadoValor
            // 
            this.lblResultadoValor.AutoSize = true;
            this.lblResultadoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoValor.Location = new System.Drawing.Point(134, 370);
            this.lblResultadoValor.Name = "lblResultadoValor";
            this.lblResultadoValor.Size = new System.Drawing.Size(0, 30);
            this.lblResultadoValor.TabIndex = 5;
            this.lblResultadoValor.Visible = false;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(97, 253);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(143, 35);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblResultadoValor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblInsiraValor);
            this.Controls.Add(this.cbxConversao);
            this.Controls.Add(this.lblSelecione);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelecione;
        private ComboBox cbxConversao;
        private Label lblInsiraValor;
        private TextBox txbValor;
        private Label lblResultado;
        private Label lblResultadoValor;
        private Button btnConverter;
    }
}