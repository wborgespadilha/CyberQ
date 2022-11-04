namespace Exercício_17
{
    public partial class Cadastro : Form
    {

        List<Pessoa> listaPessoas = new List<Pessoa>();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbxNome.Text == "")
                {
                    MessageBox.Show("Você deve inserir um nome!");
                    return;
                }

                if (tbxIdade.Text == "")
                {
                    MessageBox.Show("Você deve inserir a idade!");
                    return;
                }

                if (cbxM.Checked == false && cbxF.Checked == false)
                {
                    MessageBox.Show("Você deve selecionar o sexo!");
                    return;
                }

                if (cbxM.Checked == true && cbxF.Checked == true)
                {
                    MessageBox.Show("Você deve selecionar apenas um sexo!");
                    return;
                }

                int indice = cbxEstado.SelectedIndex;

                if (indice == -1)
                {
                    MessageBox.Show("Você deve selecionar um estado!");
                    return;
                }

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = tbxNome.Text;
                pessoa.Idade = Convert.ToInt32(tbxIdade.Text);
                pessoa.Estado = cbxEstado.SelectedItem.ToString();
                pessoa.Genero = cbxM.Checked == true ? "M" : "F";

                listaPessoas.Add(pessoa);

                MessageBox.Show("Cadastrado com sucesso!");

                tbxNome.Text = "";
                tbxIdade.Text = "";
                cbxF.Checked = false;
                cbxM.Checked = false;
                cbxEstado.SelectedIndex = -1;
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar lista = new Listar(listaPessoas);
            lista.Show();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            cbxEstado.Items.Add("Acre");
            cbxEstado.Items.Add("Alagoas");
            cbxEstado.Items.Add("Amapá");
            cbxEstado.Items.Add("Amazonas");
            cbxEstado.Items.Add("Bahia");
            cbxEstado.Items.Add("Ceará");
            cbxEstado.Items.Add("Espírito Santo");
            cbxEstado.Items.Add("Goiás");
            cbxEstado.Items.Add("Maranhão");
            cbxEstado.Items.Add("Mato Grosso");
            cbxEstado.Items.Add("Mato Grosso do Sul");
            cbxEstado.Items.Add("Minas Gerais");
            cbxEstado.Items.Add("Pará");
            cbxEstado.Items.Add("Paraíba");
            cbxEstado.Items.Add("Paraná");
            cbxEstado.Items.Add("Pernambuco");
            cbxEstado.Items.Add("Piauí");
            cbxEstado.Items.Add("Rio de Janeiro");
            cbxEstado.Items.Add("Rio Grande do Norte");
            cbxEstado.Items.Add("Rio Grande do Sul");
            cbxEstado.Items.Add("Rondônia");
            cbxEstado.Items.Add("Roraima");
            cbxEstado.Items.Add("Santa Catarina");
            cbxEstado.Items.Add("São Paulo");
            cbxEstado.Items.Add("Sergipe");
            cbxEstado.Items.Add("Tocantins");
            cbxEstado.Items.Add("Distrito Federal");


        }
    }
}