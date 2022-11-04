namespace Exemplo_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter linhas selecionada
            int linha = e.RowIndex;

            MessageBox.Show("A linha selecionada é: " + linha);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Colunas do grid
            dgvProdutos.ColumnCount = 3;

            dgvProdutos.ColumnHeadersVisible = true;
            dgvProdutos.Columns[0].Name = "Produto";
            dgvProdutos.Columns[1].Name = "Marca";
            dgvProdutos.Columns[2].Name = "Valor";

            // Dados do grid

            dgvProdutos.Rows.Add(new object[] {
                "Notebook Inspiron 1800",
                "Dell",
                "1700"
            });

        }
    }
}