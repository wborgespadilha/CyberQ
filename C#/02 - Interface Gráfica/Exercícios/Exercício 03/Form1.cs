namespace Exercício_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                double numero1 = txbNum1.Text != "" ? Convert.ToDouble(txbNum1.Text) : 0;
                double numero2 = txbNum2.Text != "" ? Convert.ToDouble(txbNum2.Text) : 0;
                double numero3 = txbNum3.Text != "" ? Convert.ToDouble(txbNum3.Text) : 0;

                string resultado = "O menor número é: ";

                if (numero1 < numero2 && numero1 < numero3)
                {
                    resultado += numero1;
                }
                else if (numero2 < numero1 && numero2 < numero3)
                {
                    resultado += numero2;
                }
                else
                {
                    resultado += numero3;
                }

                MessageBox.Show(resultado);
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números");
            }

        }
    }
}