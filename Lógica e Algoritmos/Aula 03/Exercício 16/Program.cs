Random random = new Random();

int[,] matriz = new int[10, 10];
string[,] ui = new string[10, 10];

for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        ui[i, j] = " ";
    }
}


int bombCounter = 0;

bool continuarInsercao = true;
bool continuarJogo = true;

/*
1 = bomba
2 = navio
*/

// Inserindo o navio
matriz[random.Next(0,10), random.Next(0,10)] = 2;

// Inserindo as bombas
for (int i = 0; i < 4; i++)
{
    while (continuarInsercao)
    {
        int x = random.Next(0, 10);
        int y = random.Next(0, 10);

        if (matriz[x, y] != 1 && matriz[x, y] != 2)
        {
            matriz[x, y] = 1;
            continuarInsercao = false;
        }
    }
    continuarInsercao = true;
}

do
{
    for(int i = 0; i < 10; i++)
    {
        Console.Write("|");
        for(int j = 0; j < 10; j++)
        {
            Console.Write(ui[i,j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine(" - - - - - - - - - -");
    }

    try
    {

        Console.WriteLine("Insira uma linha (0 - 9)");
        int linha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira uma coluna (0 - 9)");
        int coluna = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        switch (matriz[linha, coluna])
        {
            case 1:
                Console.WriteLine("Bomba!");
                ui[linha, coluna] = "B";
                bombCounter++;
                break;
            case 2:
                Console.WriteLine("Navio encontrado! Fim de jogo.");
                ui[linha, coluna] = "N";
                continuarJogo = false;
                break;
            default:
                Console.WriteLine("Nada aqui");
                ui[linha, coluna] = "O";
                for (int i = (linha > 0 ? linha - 1 : 0); i < linha + 2; i++)
                {
                    for (int j = (coluna > 0 ? coluna - 1 : 0); j < coluna + 2; j++)
                    {
                        if (i < 10 && j < 10)
                        {
                            if (matriz[i, j] == 1)
                            {
                                Console.WriteLine("Uma bomba está próxima!");
                            }
                            else if (matriz[i, j] == 2)
                            {
                                Console.WriteLine("O navio está próximo!");
                            }
                        }
                    }
                }
                break;
        }
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Insira apenas números");
        Console.WriteLine();
    }

    if(bombCounter == 3)
    {
        Console.WriteLine("Você estourou as 3 bombas. Fim de jogo.");
        continuarJogo = false;
    }

}
while(continuarJogo);