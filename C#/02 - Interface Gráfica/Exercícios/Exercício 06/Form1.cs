namespace Exercício_06
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

                double lado1 = txbLado1.Text != "" ? Convert.ToDouble(txbLado1.Text) : 0;
                double lado2 = txbLado2.Text != "" ? Convert.ToDouble(txbLado2.Text) : 0;
                double lado3 = txbLado3.Text != "" ? Convert.ToDouble(txbLado3.Text) : 0;

                if (lado1 == lado2 && lado2 == lado3)
                {
                    lblResultado.Text = "Equilátero";
                    lblResultado.Visible = true;
                    lblTriangulo.Visible = true;
                }
                else if ((lado1 == lado2 && lado2 != lado3) || (lado2 == lado3 && lado3 != lado1) || (lado3 == lado1 && lado1 != lado2))
                {
                    lblResultado.Text = "Isóceles";
                    lblResultado.Visible = true;
                    lblTriangulo.Visible = true;
                }
                else
                {
                    lblResultado.Text = "Escaleno";
                    lblResultado.Visible = true;
                    lblTriangulo.Visible = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }
        }
    }
}