namespace Exercício_12
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
            this.lblInsiraData = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularSigno = new System.Windows.Forms.Button();
            this.lblSeuSigno = new System.Windows.Forms.Label();
            this.lblSigno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInsiraData
            // 
            this.lblInsiraData.AutoSize = true;
            this.lblInsiraData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInsiraData.Location = new System.Drawing.Point(35, 24);
            this.lblInsiraData.Name = "lblInsiraData";
            this.lblInsiraData.Size = new System.Drawing.Size(259, 25);
            this.lblInsiraData.TabIndex = 0;
            this.lblInsiraData.Text = "Insira a data de nascimento:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(44, 78);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(234, 23);
            this.dtpDataNascimento.TabIndex = 1;
            // 
            // btnCalcularSigno
            // 
            this.btnCalcularSigno.Location = new System.Drawing.Point(95, 156);
            this.btnCalcularSigno.Name = "btnCalcularSigno";
            this.btnCalcularSigno.Size = new System.Drawing.Size(130, 57);
            this.btnCalcularSigno.TabIndex = 2;
            this.btnCalcularSigno.Text = "Calcular Signo";
            this.btnCalcularSigno.UseVisualStyleBackColor = true;
            this.btnCalcularSigno.Click += new System.EventHandler(this.btnCalcularSigno_Click);
            // 
            // lblSeuSigno
            // 
            this.lblSeuSigno.AutoSize = true;
            this.lblSeuSigno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeuSigno.Location = new System.Drawing.Point(105, 275);
            this.lblSeuSigno.Name = "lblSeuSigno";
            this.lblSeuSigno.Size = new System.Drawing.Size(101, 21);
            this.lblSeuSigno.TabIndex = 3;
            this.lblSeuSigno.Text = "Seu signo é:";
            this.lblSeuSigno.Visible = false;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSigno.Location = new System.Drawing.Point(124, 339);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(0, 21);
            this.lblSigno.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.lblSeuSigno);
            this.Controls.Add(this.btnCalcularSigno);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblInsiraData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsiraData;
        private DateTimePicker dtpDataNascimento;
        private Button btnCalcularSigno;
        private Label lblSeuSigno;
        private Label lblSigno;
    }
}