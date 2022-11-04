namespace Exercício_15
{
    public partial class Form1 : Form
    {

        string[,] jogo = new string[3, 3];


        bool vezDoX = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    jogo[i, j] = "";
                }
            }
        }

        private void verificarVitoria()
        {
            int velhas = 0;
            string letra = "";
            string winner = "";

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    letra = "X";
                }
                else
                {
                    letra = "O";
                }

                //Linhas horizontais
                if (jogo[0, 0] == letra && jogo[0, 1] == letra && jogo[0, 2] == letra)
                {
                    winner = letra;
                    break;
                }
                if (jogo[1, 0] == letra && jogo[1, 1] == letra && jogo[1, 2] == letra)
                {
                    winner = letra;
                    break;
                }
                if (jogo[2, 0] == letra && jogo[2, 1] == letra && jogo[2, 2] == letra)
                {
                    winner = letra;
                    break;
                }

                // Linhas verticais

                if (jogo[0, 0] == letra && jogo[1, 0] == letra && jogo[2, 0] == letra)
                {
                    winner = letra;
                    break;
                }
                if (jogo[0, 1] == letra && jogo[1, 1] == letra && jogo[2, 1] == letra)
                {
                    winner = letra;
                    break;
                }
                if (jogo[0, 2] == letra && jogo[1, 2] == letra && jogo[2, 2] == letra)
                {
                    winner = letra;
                    break;
                }

                // Diagonais

                if (jogo[0, 0] == letra && jogo[1, 1] == letra && jogo[2, 2] == letra)
                {
                    winner = letra;
                    break;
                }
                if (jogo[0, 2] == letra && jogo[1, 1] == letra && jogo[2, 0] == letra)
                {
                    winner = letra;
                    break;
                }
            }

            if(winner != "")
            {
                lblSituacao.Text = $"O {winner} ganhou!";
                pcb00.Enabled = false;
                pcb01.Enabled = false;
                pcb02.Enabled = false;

                pcb10.Enabled = false;
                pcb11.Enabled = false;
                pcb12.Enabled = false;

                pcb20.Enabled = false;
                pcb21.Enabled = false;
                pcb22.Enabled = false;
            }

            // Verificar velha
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[i, j] != "")
                    {
                        velhas++;
                    }
                }
            }

            if (velhas == 9)
            {
                lblSituacao.Text = "Deu velha!";
            }
            else
            {
                velhas = 0;
            }
        }

        private void pcb00_Click(object sender, EventArgs e)
        {
            if (jogo[0, 0] == "")
            {
                if (vezDoX)
                {
                    jogo[0, 0] = "X";
                    pcb00.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[0, 0] = "O";
                    pcb00.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb01_Click(object sender, EventArgs e)
        {
            if (jogo[0, 1] == "")
            {
                if (vezDoX)
                {
                    jogo[0, 1] = "X";
                    pcb01.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[0, 1] = "O";
                    pcb01.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb02_Click(object sender, EventArgs e)
        {
            if (jogo[0, 2] == "")
            {
                if (vezDoX)
                {
                    jogo[0, 2] = "X";
                    pcb02.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[0, 2] = "O";
                    pcb02.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb10_Click(object sender, EventArgs e)
        {
            if (jogo[1, 0] == "")
            {
                if (vezDoX)
                {
                    jogo[1, 0] = "X";
                    pcb10.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[1, 0] = "O";
                    pcb10.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb11_Click(object sender, EventArgs e)
        {
            if (jogo[1, 1] == "")
            {
                if (vezDoX)
                {
                    jogo[1, 1] = "X";
                    pcb11.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[1, 1] = "O";
                    pcb11.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb12_Click(object sender, EventArgs e)
        {
            if (jogo[1, 2] == "")
            {
                if (vezDoX)
                {
                    jogo[1, 2] = "X";
                    pcb12.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[1, 2] = "O";
                    pcb12.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb20_Click(object sender, EventArgs e)
        {
            if (jogo[2, 0] == "")
            {
                if (vezDoX)
                {
                    jogo[2, 0] = "X";
                    pcb20.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[2, 0] = "O";
                    pcb20.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb21_Click(object sender, EventArgs e)
        {
            if (jogo[2, 1] == "")
            {
                if (vezDoX)
                {
                    jogo[2, 1] = "X";
                    pcb21.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[2, 1] = "O";
                    pcb21.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }

        private void pcb22_Click(object sender, EventArgs e)
        {
            if (jogo[2, 2] == "")
            {
                if (vezDoX)
                {
                    jogo[2, 2] = "X";
                    pcb22.BackgroundImage = Recursos.X;
                    vezDoX = false;
                    lblTurno.Text = "Vez do O";
                }
                else
                {
                    jogo[2, 2] = "O";
                    pcb22.BackgroundImage = Recursos.O;
                    vezDoX = true;
                    lblTurno.Text = "Vez do X";
                }
                verificarVitoria();
            }
        }
    }
}