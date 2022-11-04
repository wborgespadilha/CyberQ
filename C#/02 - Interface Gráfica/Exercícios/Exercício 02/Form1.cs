namespace Exercício_02
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

                double media = (Convert.ToDouble(txbNota1.Text) + Convert.ToDouble(txbNota2.Text) + Convert.ToDouble(txbNota3.Text)) / 3;

                string situacao = $"A media do aluno {txbNome.Text} foi {media:F2} e a situação é ";

                if (media < 5)
                {
                    situacao += "Reprovado(a)";
                }
                else if (media < 7)
                {
                    situacao += "Em exame";
                }
                else
                {
                    situacao += "Aprovado(a)";
                }


                MessageBox.Show(situacao);
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números nas notas!");
            }
        }
    }
}