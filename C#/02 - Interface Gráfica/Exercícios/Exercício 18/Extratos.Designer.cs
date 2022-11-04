namespace Exercício_18
{
    partial class Extratos
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
            this.lblExtrato = new System.Windows.Forms.Label();
            this.lblExtratoCC = new System.Windows.Forms.Label();
            this.lbxExtratosCC = new System.Windows.Forms.ListBox();
            this.lblExtratosCP = new System.Windows.Forms.Label();
            this.lbxExtratosCP = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExtrato
            // 
            this.lblExtrato.AutoSize = true;
            this.lblExtrato.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtrato.Location = new System.Drawing.Point(288, 18);
            this.lblExtrato.Name = "lblExtrato";
            this.lblExtrato.Size = new System.Drawing.Size(90, 30);
            this.lblExtrato.TabIndex = 0;
            this.lblExtrato.Text = "Extrato:";
            // 
            // lblExtratoCC
            // 
            this.lblExtratoCC.AutoSize = true;
            this.lblExtratoCC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtratoCC.Location = new System.Drawing.Point(69, 79);
            this.lblExtratoCC.Name = "lblExtratoCC";
            this.lblExtratoCC.Size = new System.Drawing.Size(218, 25);
            this.lblExtratoCC.TabIndex = 1;
            this.lblExtratoCC.Text = "Extratos Conta Corrente";
            // 
            // lbxExtratosCC
            // 
            this.lbxExtratosCC.FormattingEnabled = true;
            this.lbxExtratosCC.ItemHeight = 15;
            this.lbxExtratosCC.Location = new System.Drawing.Point(53, 133);
            this.lbxExtratosCC.Name = "lbxExtratosCC";
            this.lbxExtratosCC.Size = new System.Drawing.Size(252, 289);
            this.lbxExtratosCC.TabIndex = 2;
            // 
            // lblExtratosCP
            // 
            this.lblExtratosCP.AutoSize = true;
            this.lblExtratosCP.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtratosCP.Location = new System.Drawing.Point(376, 79);
            this.lblExtratosCP.Name = "lblExtratosCP";
            this.lblExtratosCP.Size = new System.Drawing.Size(226, 25);
            this.lblExtratosCP.TabIndex = 3;
            this.lblExtratosCP.Text = "Extratos Conta Poupança";
            // 
            // lbxExtratosCP
            // 
            this.lbxExtratosCP.FormattingEnabled = true;
            this.lbxExtratosCP.ItemHeight = 15;
            this.lbxExtratosCP.Location = new System.Drawing.Point(364, 133);
            this.lbxExtratosCP.Name = "lbxExtratosCP";
            this.lbxExtratosCP.Size = new System.Drawing.Size(250, 289);
            this.lbxExtratosCP.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(246, 457);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(185, 57);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Extratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(658, 542);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbxExtratosCP);
            this.Controls.Add(this.lblExtratosCP);
            this.Controls.Add(this.lbxExtratosCC);
            this.Controls.Add(this.lblExtratoCC);
            this.Controls.Add(this.lblExtrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Extratos";
            this.Text = "Extratos";
            this.Load += new System.EventHandler(this.Extratos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblExtrato;
        private Label lblExtratoCC;
        private ListBox lbxExtratosCC;
        private Label lblExtratosCP;
        private ListBox lbxExtratosCP;
        private Button btnFechar;
    }
}