namespace Exercício_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxConversao.Items.Add("Real para Dólar");
            cbxConversao.Items.Add("Dólar para Real");
            cbxConversao.Items.Add("Real para Euro");
            cbxConversao.Items.Add("Euro para Real");
            cbxConversao.Items.Add("Real para Libra");
            cbxConversao.Items.Add("Libra para Real");
            cbxConversao.Items.Add("Real para Peso Argentino");
            cbxConversao.Items.Add("Peso Argentino para Real");
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                double valorInserido = txbValor.Text != "" ? Convert.ToDouble(txbValor.Text) : 0;
                int indice = cbxConversao.SelectedIndex;

                switch (indice)
                {
                    case 0:
                        txbResultado.Text = $"$ {(valorInserido / 5.12):F2}";
                        break;
                    case 1:
                        txbResultado.Text = $"{(valorInserido * 5.12):C2}";
                        break;
                    case 2:
                        txbResultado.Text = $"€ {(valorInserido / 5.35):F2}";
                        break;
                    case 3:
                        txbResultado.Text = $"{(valorInserido * 5.35):C2}";
                        break;
                    case 4:
                        txbResultado.Text = $"£ {(valorInserido / 6.23):F2}";
                        break;
                    case 5:
                        txbResultado.Text = $"{(valorInserido * 6.23):C2}";
                        break;
                    case 6:
                        txbResultado.Text = $"$ {(valorInserido / 0.042):F2}";
                        break;
                    case 7:
                        txbResultado.Text = $"{(valorInserido * 0.042):C2}";
                        break;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }

        }
    }
}