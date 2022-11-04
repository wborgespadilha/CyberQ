namespace Exercício_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMontante_Click(object sender, EventArgs e)
        {
            try
            {

                int doisReais = txb2Reais.Text != "" ? Convert.ToInt32(txb2Reais.Text) : 0;
                int cincoReais = txb5Reais.Text != "" ? Convert.ToInt32(txb5Reais.Text) : 0;
                int dezReais = txb10Reais.Text != "" ? Convert.ToInt32(txb10Reais.Text) : 0;
                int vinteReais = txb20Reais.Text != "" ? Convert.ToInt32(txb20Reais.Text) : 0;
                int cinquentaReais = txb50Reais.Text != "" ? Convert.ToInt32(txb50Reais.Text) : 0;
                int cemReais = txb100Reais.Text != "" ? Convert.ToInt32(txb100Reais.Text) : 0;
                int duzentosReais = txb200Reais.Text != "" ? Convert.ToInt32(txb200Reais.Text) : 0;

                double montante = doisReais * 2 + cincoReais * 5 + dezReais * 10 + vinteReais * 20
                    + cinquentaReais * 50 + cemReais * 100 + duzentosReais * 200;

                lblMontante.Text = $"{montante:C2}";
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }

        }
    }
}