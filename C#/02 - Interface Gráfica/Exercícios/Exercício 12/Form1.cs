namespace Exercício_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSigno_Click(object sender, EventArgs e)
        {
            DateTime data = dtpDataNascimento.Value;

            lblSeuSigno.Visible = true;

            switch(data.Month)
            {
                case 1:
                    if(data.Day <= 20)
                    {
                        lblSigno.Text = "Capricórnio";
                    }
                    else
                    {
                        lblSigno.Text = "Aquário";
                    }
                    break;

                case 2:
                    if(data.Day <= 18)
                    {
                        lblSigno.Text = "Aquário";
                    }
                    else
                    {
                        lblSigno.Text = "Peixes";
                    }
                    break;

                case 3:
                    if(data.Day <= 20)
                    {
                        lblSigno.Text = "Peixes";
                    }
                    else
                    {
                        lblSigno.Text = "Áries";
                    }
                    break;

                case 4:
                    if (data.Day <= 20)
                    {
                        lblSigno.Text = "Áries";
                    }
                    else
                    {
                        lblSigno.Text = "Touro";
                    }
                    break;

                case 5:
                    if (data.Day <= 21)
                    {
                        lblSigno.Text = "Touro";
                    }
                    else
                    {
                        lblSigno.Text = "Gêmeos";
                    }
                    break;

                case 6:
                    if (data.Day <= 20)
                    {
                        lblSigno.Text = "Gêmeos";
                    }
                    else
                    {
                        lblSigno.Text = "Câncer";
                    }
                    break;

                case 7:
                    if (data.Day <= 22)
                    {
                        lblSigno.Text = "Câncer";
                    }
                    else
                    {
                        lblSigno.Text = "Leão";
                    }
                    break;

                case 8:
                    if (data.Day <= 22)
                    {
                        lblSigno.Text = "Leão";
                    }
                    else
                    {
                        lblSigno.Text = "Virgem";
                    }
                    break;

                case 9:
                    if(data.Day <= 22)
                    {
                        lblSigno.Text = "Virgem";
                    }
                    else
                    {
                        lblSigno.Text = "Libra";
                    }
                    break;

                case 10:
                    if (data.Day <= 22)
                    {
                        lblSigno.Text = "Libra";
                    }
                    else
                    {
                        lblSigno.Text = "Escorpião";
                    }
                    break;

                case 11:
                    if (data.Day <= 21)
                    {
                        lblSigno.Text = "Escorpião";
                    }
                    else
                    {
                        lblSigno.Text = "Sagitário";
                    }
                    break;

                case 12:
                    if (data.Day <= 21)
                    {
                        lblSigno.Text = "Sagitário";
                    }
                    else
                    {
                        lblSigno.Text = "Capricórnio";
                    }
                    break;

            }

        }
    }
}