namespace Exercício_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxPagamento.Items.Add("A vista");
            cbxPagamento.Items.Add("A prazo");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int indice = cbxPagamento.SelectedIndex;
                double valor = Convert.ToDouble(txbValor.Text);

                switch (indice)
                {
                    case 0:
                        if (valor >= 500)
                        {
                            lblResultado.Text = $"{(valor * 0.9):C2}";
                        }
                        else
                        {
                            lblResultado.Text = $"{valor:C2}";
                        }
                        break;

                    case 1:
                        lblResultado.Text = $"{valor:C2}";
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números no campo valor!");
            }

        }
    }
}