namespace Exercício_07
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
            this.lblInsira = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvTabuada = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabuada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInsira.Location = new System.Drawing.Point(43, 35);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(129, 25);
            this.lblInsira.TabIndex = 0;
            this.lblInsira.Text = "Insira o valor:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(230, 40);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 23);
            this.txbNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(527, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(175, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Tabuada";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvTabuada
            // 
            this.dgvTabuada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabuada.Location = new System.Drawing.Point(113, 113);
            this.dgvTabuada.Name = "dgvTabuada";
            this.dgvTabuada.RowTemplate.Height = 25;
            this.dgvTabuada.Size = new System.Drawing.Size(544, 264);
            this.dgvTabuada.TabIndex = 3;
            this.dgvTabuada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTabuada);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblInsira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabuada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsira;
        private TextBox txbNumero;
        private Button btnCalcular;
        private DataGridView dgvTabuada;
    }
}