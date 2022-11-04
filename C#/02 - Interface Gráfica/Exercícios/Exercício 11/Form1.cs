namespace Exercício_11
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


                double valorInserido = txbValor.Text != "" ? Convert.ToDouble(txbValor.Text) : 0;
                int indice = cbxConversao.SelectedIndex;
                double resultado = 0;

                switch (indice)
                {
                    case 0:
                        resultado = (valorInserido * 1.8) + 32;
                        lblResultadoValor.Text = resultado + " F";
                        break;

                    case 1:
                        resultado = (valorInserido - 32) * 5 / 9;
                        lblResultadoValor.Text = $"{resultado:F2} ºC";
                        break;
                }

                lblResultado.Visible = true;
                lblResultadoValor.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxConversao.Items.Add("Celsius para Fahrenheit");
            cbxConversao.Items.Add("Fahrenheit para Celsius");
        }

    }
}