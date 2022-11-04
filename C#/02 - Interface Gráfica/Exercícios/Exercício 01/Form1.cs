namespace Exercício_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txbValorProduto.Text);
                MessageBox.Show($"O produto {txbNomeProduto.Text} Vai custar {(valor * 0.9):C2} Com desconto de 10%");
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números no campo 'valor' !");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}