namespace Exemplo_01
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
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.lblInformeNome = new System.Windows.Forms.Label();
            this.txtInformeNome = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbCor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Location = new System.Drawing.Point(92, 12);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(116, 40);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "clicaki";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
            // 
            // lblInformeNome
            // 
            this.lblInformeNome.AutoSize = true;
            this.lblInformeNome.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformeNome.ForeColor = System.Drawing.Color.Coral;
            this.lblInformeNome.Location = new System.Drawing.Point(58, 66);
            this.lblInformeNome.Name = "lblInformeNome";
            this.lblInformeNome.Size = new System.Drawing.Size(187, 29);
            this.lblInformeNome.TabIndex = 1;
            this.lblInformeNome.Text = "Informe seu nome";
            // 
            // txtInformeNome
            // 
            this.txtInformeNome.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInformeNome.Location = new System.Drawing.Point(12, 98);
            this.txtInformeNome.Name = "txtInformeNome";
            this.txtInformeNome.Size = new System.Drawing.Size(269, 26);
            this.txtInformeNome.TabIndex = 2;
            this.txtInformeNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(113, 145);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ckbCor
            // 
            this.ckbCor.AutoSize = true;
            this.ckbCor.Location = new System.Drawing.Point(12, 187);
            this.ckbCor.Name = "ckbCor";
            this.ckbCor.Size = new System.Drawing.Size(83, 19);
            this.ckbCor.TabIndex = 4;
            this.ckbCor.Text = "Alterar Cor";
            this.ckbCor.UseVisualStyleBackColor = true;
            this.ckbCor.CheckedChanged += new System.EventHandler(this.ckbCor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.ckbCor);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtInformeNome);
            this.Controls.Add(this.lblInformeNome);
            this.Controls.Add(this.btnCliqueAqui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCliqueAqui;
        private Label lblInformeNome;
        private TextBox txtInformeNome;
        private Button btnEnviar;
        private CheckBox ckbCor;
    }
}