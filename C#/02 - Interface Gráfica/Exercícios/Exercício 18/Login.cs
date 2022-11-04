namespace Exercício_18
{
    public partial class Login : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "João";
            cliente.Agencia = 60;
            cliente.ContaCorrente = 123;
            cliente.Senha = 123;
            cliente.SaldoCC = 5000.0;
            cliente.SaldoCP = 1300.0;

            listaClientes.Add(cliente);
        }

        private void txbLogar_Click(object sender, EventArgs e)
        {
            try
            {

                int agencia = txbAgencia.Text != "" ? Convert.ToInt32(txbAgencia.Text) : 0;
                int conta = txbConta.Text != "" ? Convert.ToInt32(txbConta.Text) : 0;
                int senha = txbSenha.Text != "" ? Convert.ToInt32(txbSenha.Text) : 0;

                foreach (Cliente cliente in listaClientes)
                {
                    if (cliente.Agencia == agencia &&
                        cliente.ContaCorrente == conta &&
                        cliente.Senha == senha)
                    {

                        Caixa caixa = new Caixa(cliente);
                        caixa.Show();

                        txbAgencia.Text = "";
                        txbConta.Text = "";
                        txbSenha.Text = "";
                        lblErro.Visible = false;
                        return;
                    }
                }

                lblErro.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}