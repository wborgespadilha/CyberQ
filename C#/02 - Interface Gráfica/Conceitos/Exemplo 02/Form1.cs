namespace Exemplo_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cbxNomes.Items.Add("Alice");
            //cbxNomes.Items.Add("Bruno");
            //cbxNomes.Items.Add("Carla");

            Pessoa p1 = new Pessoa();
            p1.Nome = "Alice";
            p1.Idade = 24;

            Pessoa p2 = new Pessoa();
            p2.Nome = "Bruno";
            p2.Idade = 32;

            Pessoa p3 = new Pessoa();
            p3.Nome = "Carla";
            p3.Idade = 35;

            cbxNomes.Items.Add(p1);
            cbxNomes.Items.Add(p2);
            cbxNomes.Items.Add(p3);

        }

        private void cbxNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Obter a linha
            int linha = cbxNomes.SelectedIndex;
            //MessageBox.Show(linha.ToString());

            Pessoa obj = (Pessoa) cbxNomes.SelectedItem;

            txtNome.Text = obj.Nome;
            txtIdade.Text = obj.Idade.ToString();
             
        }
    }
}