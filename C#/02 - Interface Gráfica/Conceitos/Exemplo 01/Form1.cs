namespace Exemplo_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bom dia " + txtInformeNome.Text);
        }

        private void ckbCor_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbCor.Checked)
            {
                Form1.ActiveForm.BackColor = Color.Azure;  
            }
            else
            {
                Form1.ActiveForm.BackColor = Color.Empty;
            }
        }
    }
}