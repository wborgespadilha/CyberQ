namespace DB
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            Acoes a = new Acoes();
            a.CadastrarPessoa(txbNome.Text, Convert.ToInt32(txbIdade.Text));

            AtualizarTabela();
        }

        private void btnListarPessoas_Click(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

            FormatarDgvPessoas();
            AtualizarTabela();

        }

        private void FormatarDgvPessoas()
        {
            for (int i = 0; i < dgvPessoas.ColumnCount; i++)
            {
                dgvPessoas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AtualizarTabela()
        {
            Acoes a = new Acoes();
            a.ListarPessoas();

            dgvPessoas.Rows.Clear();

            dgvPessoas.ColumnCount = 2;
            dgvPessoas.Columns[0].Name = "Nome";
            dgvPessoas.Columns[1].Name = "Idade";

            foreach(Pessoa pessoa in Acoes.pessoas)
            {
                dgvPessoas.Rows.Add(pessoa.Nome, pessoa.Idade);
            }

        }

    }
}