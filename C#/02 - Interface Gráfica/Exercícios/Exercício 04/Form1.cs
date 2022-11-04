namespace Exercício_04
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
                double num1 = txbNum1.Text != "" ? Convert.ToDouble(txbNum1.Text) : 0;
                double num2 = txbNum2.Text != "" ? Convert.ToDouble(txbNum2.Text) : 0;

                double resultado = num1 == num2 ? num1 + num2 : num1 * num2;

                MessageBox.Show("O resultado é " + resultado);

            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }
        }
    }
}