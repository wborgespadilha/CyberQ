namespace Exercício_15
{
    public partial class Form1 : Form
    {

        string[,] jogo = new string[3, 3];


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

        private string verificarVitoria()
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

            return winner;

        }

        private void botJogar()
        {
            int velhas = 0;

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

            string retorno = verificarVitoria();

            if (velhas < 8 && retorno == "")
            {

                bool continuar = true;
                while (continuar)
                {
                    Random random = new Random();
                    int i = random.Next(3);
                    int j = random.Next(3);

                    if (jogo[i, j] == "")
                    {
                        jogo[i, j] = "O";
                        verificarJogadaBot();
                        verificarVitoria();
                        continuar = false;
                    }
                }
            }
        }

        private void verificarJogadaBot()
        {
            if (jogo[0, 0] == "O")
            {
                pcb00.BackgroundImage = Recursos.O;
            }
            if (jogo[0, 1] == "O")
            {
                pcb01.BackgroundImage = Recursos.O;
            }
            if (jogo[0, 2] == "O")
            {
                pcb02.BackgroundImage = Recursos.O;
            }

            if (jogo[1, 0] == "O")
            {
                pcb10.BackgroundImage = Recursos.O;
            }
            if (jogo[1, 1] == "O")
            {
                pcb11.BackgroundImage = Recursos.O;
            }
            if (jogo[1, 2] == "O")
            {
                pcb12.BackgroundImage = Recursos.O;
            }

            if (jogo[2, 0] == "O")
            {
                pcb20.BackgroundImage = Recursos.O;
            }
            if (jogo[2, 1] == "O")
            {
                pcb21.BackgroundImage = Recursos.O;
            }
            if (jogo[2, 2] == "O")
            {
                pcb22.BackgroundImage = Recursos.O;
            }

        }

        private void pcb00_Click(object sender, EventArgs e)
        {
            if (jogo[0, 0] == "")
            {
                jogo[0, 0] = "X";
                pcb00.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb01_Click(object sender, EventArgs e)
        {
            if (jogo[0, 0] == "")
            {
                jogo[0, 1] = "X";
                pcb01.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb02_Click(object sender, EventArgs e)
        {
            if (jogo[0, 2] == "")
            {

                jogo[0, 2] = "X";
                pcb02.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb10_Click(object sender, EventArgs e)
        {
            if (jogo[1, 0] == "")
            {

                jogo[1, 0] = "X";
                pcb10.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb11_Click(object sender, EventArgs e)
        {
            if (jogo[1, 1] == "")
            {

                jogo[1, 1] = "X";
                pcb11.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb12_Click(object sender, EventArgs e)
        {
            if (jogo[1, 2] == "")
            {
                jogo[1, 2] = "X";
                pcb12.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb20_Click(object sender, EventArgs e)
        {
            if (jogo[2, 0] == "")
            {

                jogo[2, 0] = "X";
                pcb20.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb21_Click(object sender, EventArgs e)
        {
            if (jogo[2, 1] == "")
            {
                jogo[2, 1] = "X";
                pcb21.BackgroundImage = Recursos.X;
                botJogar();
            }
        }

        private void pcb22_Click(object sender, EventArgs e)
        {
            if (jogo[2, 2] == "")
            {

                jogo[2, 2] = "X";
                pcb22.BackgroundImage = Recursos.X;
                botJogar();
            }
        }
    }
}