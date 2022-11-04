namespace Exercício_19
{
    public partial class Form1 : Form
    {

        List<Produto> produtos = new List<Produto>();
        List<Marca> marcas = new List<Marca>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txbNome.Text == "")
            {
                MessageBox.Show("Você deve inserir um nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Marca obj in marcas)
            {
                if(obj.Nome == txbNome.Text)
                {
                    MessageBox.Show("Já existe uma marca cadastrada com esse nome!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }

            Marca marca = new Marca(txbNome.Text,0);
            marcas.Add(marca);


            txbNome.Text = "";
            MessageBox.Show("Marca adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if(txbOldName.Text == "" || txbNewName.Text == "")
            {
                MessageBox.Show("Você deve inserir um nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Produto produto in produtos)
            {
                if(produto.Marca == txbOldName.Text)
                {
                    MessageBox.Show("Existem produtos vinculados a essa marca!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool marcaEncontrda = false;

            for(int i = 0; i < marcas.Count; i++)
            {
                if(marcas[i].Nome == txbOldName.Text)
                {
                    marcas[i].Nome = txbNewName.Text;
                    marcaEncontrda = true;
                    break;
                }
            }

            if(marcaEncontrda)
            {
                txbOldName.Text = "";
                txbNewName.Text = "";
                MessageBox.Show("Marca alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Marca não foi encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(txbNameDelete.Text == "")
            {
                MessageBox.Show("Você deve inserir um nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Produto produto in produtos)
            {
                if (produto.Marca == txbNameDelete.Text)
                {
                    MessageBox.Show("Existem produtos vinculados a essa marca!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool marcaEncontrda = false;

            foreach (Marca marca in marcas)
            {
                if(marca.Nome == txbNameDelete.Text)
                {
                    marcas.Remove(marca);
                    marcaEncontrda = true;
                    break;
                }
            }

            if (marcaEncontrda)
            {
                txbNameDelete.Text = "";
                MessageBox.Show("Marca deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Marca não foi encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {

                if(txbProduto.Text == "" || txbValorProduto.Text == "" || txbMarcaProduto.Text == "")
                {
                    MessageBox.Show("Você deve inserir os valores!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool marcaEncontrada = false;

                foreach (Marca marca in marcas)
                {
                    if (marca.Nome == txbMarcaProduto.Text)
                    {
                        marcaEncontrada = true;
                        marca.Quantidade += 1;
                        break;
                    }
                }

                if (!marcaEncontrada)
                {
                    MessageBox.Show("Essa marca não foi cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Produto produto = new Produto(txbProduto.Text, Convert.ToDouble(txbValorProduto.Text), txbMarcaProduto.Text);
                produtos.Add(produto);

                txbProduto.Text = "";
                txbValorProduto.Text = "";
                txbMarcaProduto.Text = "";
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception)
            {
                MessageBox.Show("Dados inseridos incorretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {


            lbxListaProdutos.Items.Clear();
            foreach(Produto produto in produtos)
            {
                lbxListaProdutos.Items.Add($"{produto.Nome}, marca: {produto.Marca} - {produto.Valor:C2}");
            }
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            lbxEstatisticas.Items.Clear();
            foreach(Marca marca in marcas)
            {
                lbxEstatisticas.Items.Add($"{marca.Nome} - quantidade: {marca.Quantidade}");
            }
        }
    }
}