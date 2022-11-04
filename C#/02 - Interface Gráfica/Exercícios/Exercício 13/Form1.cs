namespace Exercício_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {

                int indice = cbxConversao.SelectedIndex;

                double valorInserido = txbValor.Text != "" ? Convert.ToDouble(txbValor.Text) : 0;
                double resultado = 0;

                switch (indice)
                {
                    case 0:
                        resultado = valorInserido / 1000;
                        lblResultado.Text = $"{resultado} KM";
                        break;

                    case 1:
                        resultado = valorInserido * 1000;
                        lblResultado.Text = $"{resultado} Metros";
                        break;
                }

                lblResultado.Visible = true;

            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxConversao.Items.Add("Metros para quilômetros");
            cbxConversao.Items.Add("Quilômetros para metros");
        }
    }
}