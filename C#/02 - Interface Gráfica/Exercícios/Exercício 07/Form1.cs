namespace Exercício_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int valor = txbNumero.Text != "" ? Convert.ToInt32(txbNumero.Text) : 0;

                for (int i = 0; i <= 100; i++)
                {
                    dgvTabuada.Rows.Add(new object[] {
                    valor,
                    "X",
                    i,
                    "=",
                    i*valor
                });
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTabuada.ColumnCount = 5;
            dgvTabuada.ColumnHeadersVisible = true;
           
            dgvTabuada.Columns[0].Name = "Num. Primário";
            dgvTabuada.Columns[1].Name = "Vezes";
            dgvTabuada.Columns[2].Name = "Num. Secundário";
            dgvTabuada.Columns[3].Name = "Igual";
            dgvTabuada.Columns[4].Name = "Resultado";
        }
    }
}