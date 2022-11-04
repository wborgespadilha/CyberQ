namespace Exercício_15
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
            this.lblJogo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.pcb00 = new System.Windows.Forms.PictureBox();
            this.pcb01 = new System.Windows.Forms.PictureBox();
            this.pcb02 = new System.Windows.Forms.PictureBox();
            this.pcb10 = new System.Windows.Forms.PictureBox();
            this.pcb11 = new System.Windows.Forms.PictureBox();
            this.pcb12 = new System.Windows.Forms.PictureBox();
            this.pcb20 = new System.Windows.Forms.PictureBox();
            this.pcb21 = new System.Windows.Forms.PictureBox();
            this.pcb22 = new System.Windows.Forms.PictureBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb22)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJogo.Location = new System.Drawing.Point(76, 9);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(196, 37);
            this.lblJogo.TabIndex = 0;
            this.lblJogo.Text = "Jogo da Velha";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTurno.Location = new System.Drawing.Point(114, 75);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(91, 25);
            this.lblTurno.TabIndex = 1;
            this.lblTurno.Text = "Vez do: X";
            // 
            // pcb00
            // 
            this.pcb00.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb00.Location = new System.Drawing.Point(48, 141);
            this.pcb00.Name = "pcb00";
            this.pcb00.Size = new System.Drawing.Size(58, 66);
            this.pcb00.TabIndex = 2;
            this.pcb00.TabStop = false;
            this.pcb00.Click += new System.EventHandler(this.pcb00_Click);
            // 
            // pcb01
            // 
            this.pcb01.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb01.Location = new System.Drawing.Point(130, 141);
            this.pcb01.Name = "pcb01";
            this.pcb01.Size = new System.Drawing.Size(58, 66);
            this.pcb01.TabIndex = 3;
            this.pcb01.TabStop = false;
            this.pcb01.Click += new System.EventHandler(this.pcb01_Click);
            // 
            // pcb02
            // 
            this.pcb02.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb02.Location = new System.Drawing.Point(214, 141);
            this.pcb02.Name = "pcb02";
            this.pcb02.Size = new System.Drawing.Size(58, 66);
            this.pcb02.TabIndex = 4;
            this.pcb02.TabStop = false;
            this.pcb02.Click += new System.EventHandler(this.pcb02_Click);
            // 
            // pcb10
            // 
            this.pcb10.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb10.Location = new System.Drawing.Point(48, 231);
            this.pcb10.Name = "pcb10";
            this.pcb10.Size = new System.Drawing.Size(58, 66);
            this.pcb10.TabIndex = 5;
            this.pcb10.TabStop = false;
            this.pcb10.Click += new System.EventHandler(this.pcb10_Click);
            // 
            // pcb11
            // 
            this.pcb11.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb11.Location = new System.Drawing.Point(130, 231);
            this.pcb11.Name = "pcb11";
            this.pcb11.Size = new System.Drawing.Size(58, 66);
            this.pcb11.TabIndex = 6;
            this.pcb11.TabStop = false;
            this.pcb11.Click += new System.EventHandler(this.pcb11_Click);
            // 
            // pcb12
            // 
            this.pcb12.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb12.Location = new System.Drawing.Point(214, 231);
            this.pcb12.Name = "pcb12";
            this.pcb12.Size = new System.Drawing.Size(58, 66);
            this.pcb12.TabIndex = 7;
            this.pcb12.TabStop = false;
            this.pcb12.Click += new System.EventHandler(this.pcb12_Click);
            // 
            // pcb20
            // 
            this.pcb20.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb20.Location = new System.Drawing.Point(48, 319);
            this.pcb20.Name = "pcb20";
            this.pcb20.Size = new System.Drawing.Size(58, 66);
            this.pcb20.TabIndex = 8;
            this.pcb20.TabStop = false;
            this.pcb20.Click += new System.EventHandler(this.pcb20_Click);
            // 
            // pcb21
            // 
            this.pcb21.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb21.Location = new System.Drawing.Point(130, 319);
            this.pcb21.Name = "pcb21";
            this.pcb21.Size = new System.Drawing.Size(58, 66);
            this.pcb21.TabIndex = 9;
            this.pcb21.TabStop = false;
            this.pcb21.Click += new System.EventHandler(this.pcb21_Click);
            // 
            // pcb22
            // 
            this.pcb22.BackColor = System.Drawing.Color.DarkGreen;
            this.pcb22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb22.Location = new System.Drawing.Point(214, 319);
            this.pcb22.Name = "pcb22";
            this.pcb22.Size = new System.Drawing.Size(58, 66);
            this.pcb22.TabIndex = 10;
            this.pcb22.TabStop = false;
            this.pcb22.Click += new System.EventHandler(this.pcb22_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.Location = new System.Drawing.Point(106, 402);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 25);
            this.lblSituacao.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.pcb22);
            this.Controls.Add(this.pcb21);
            this.Controls.Add(this.pcb20);
            this.Controls.Add(this.pcb12);
            this.Controls.Add(this.pcb11);
            this.Controls.Add(this.pcb10);
            this.Controls.Add(this.pcb02);
            this.Controls.Add(this.pcb01);
            this.Controls.Add(this.pcb00);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJogo;
        private Label lblTurno;
        private PictureBox pcb00;
        private PictureBox pcb01;
        private PictureBox pcb02;
        private PictureBox pcb10;
        private PictureBox pcb11;
        private PictureBox pcb12;
        private PictureBox pcb20;
        private PictureBox pcb21;
        private PictureBox pcb22;
        private Label lblSituacao;
    }
}