namespace Exercício_14
{
    public partial class Form1 : Form
    {
        int numeroSorteado = 0;
        int tentativas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {

                int valorInserido = txbNumero.Text != "" ? Convert.ToInt32(txbNumero.Text) : 0;
                int diferenca = Math.Abs(valorInserido - numeroSorteado);

                if (diferenca == 0)
                {
                    lblRetorno.Text = "Parabéns, você acertou!";
                }
                else if(diferenca <= 10)
                {
                    lblRetorno.Text = "Muito perto.";
                }
                else if(diferenca <= 20)
                {
                    lblRetorno.Text = "Longe";
                }
                else
                {
                    lblRetorno.Text = "Muito Longe";
                }

                tentativas++;
                lblTentativas.Text = $"Tentativas: {tentativas}";
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números inteiros!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            numeroSorteado = random.Next(101);
        }
    }
}