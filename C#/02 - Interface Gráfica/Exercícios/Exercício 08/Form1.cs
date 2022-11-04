namespace Exercício_08
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


                int umCentavo = txb1cent.Text != "" ? Convert.ToInt32(txb1cent.Text) : 0;
                int cincoCentavos = txb5cents.Text != "" ? Convert.ToInt32(txb5cents.Text) : 0;
                int dezCentavos = txb10cents.Text != "" ? Convert.ToInt32(txb10cents.Text) : 0;
                int vinteECintoCentavos = txb25cents.Text != "" ? Convert.ToInt32(txb25cents.Text) : 0;
                int cinquentaCentavos = txb50cents.Text != "" ? Convert.ToInt32(txb50cents.Text) : 0;
                int umReal = txb1real.Text != "" ? Convert.ToInt32(txb1real.Text) : 0;

                double montante = umCentavo * 0.01 + cincoCentavos * 0.05 + dezCentavos * 0.1 +
                    vinteECintoCentavos * 0.25 + cincoCentavos * 0.5 + umReal;

                lblMontante.Visible = true;

                lblValor.Visible = true;
                lblValor.Text = $"{montante:C2}";
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }
        }
    }
}