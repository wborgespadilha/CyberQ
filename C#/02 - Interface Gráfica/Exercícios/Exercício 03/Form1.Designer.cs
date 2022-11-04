namespace Exercício_03
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
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.txbNum3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblInsira.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInsira.Location = new System.Drawing.Point(295, 35);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(205, 30);
            this.lblInsira.TabIndex = 0;
            this.lblInsira.Text = "Insira 3 números";
            // 
            // txbNum1
            // 
            this.txbNum1.BackColor = System.Drawing.SystemColors.Info;
            this.txbNum1.Location = new System.Drawing.Point(61, 102);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(100, 23);
            this.txbNum1.TabIndex = 1;
            // 
            // txbNum2
            // 
            this.txbNum2.BackColor = System.Drawing.SystemColors.Info;
            this.txbNum2.Location = new System.Drawing.Point(344, 102);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(100, 23);
            this.txbNum2.TabIndex = 2;
            // 
            // txbNum3
            // 
            this.txbNum3.BackColor = System.Drawing.SystemColors.Info;
            this.txbNum3.Location = new System.Drawing.Point(648, 102);
            this.txbNum3.Name = "txbNum3";
            this.txbNum3.Size = new System.Drawing.Size(103, 23);
            this.txbNum3.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCalcular.Location = new System.Drawing.Point(303, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(197, 43);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbNum3);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.txbNum1);
            this.Controls.Add(this.lblInsira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsira;
        private TextBox txbNum1;
        private TextBox txbNum2;
        private TextBox txbNum3;
        private Button btnCalcular;
    }
}