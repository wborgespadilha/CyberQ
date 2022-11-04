string[,] jogo =
{
    {" "," "," "},
    {" "," "," "},
    {" "," "," "}
};

int jogador = 0;
int velhas = 0;

string winner = " ";
string letra;

bool continuar = true;

do
{
    Console.WriteLine($"{jogo[0, 0]}|{jogo[0, 1]}|{jogo[0, 2]}");
    Console.WriteLine("- - -");
    Console.WriteLine($"{jogo[1, 0]}|{jogo[1, 1]}|{jogo[1, 2]}");
    Console.WriteLine("- - -");
    Console.WriteLine($"{jogo[2, 0]}|{jogo[2, 1]}|{jogo[2, 2]}");

    Console.WriteLine();
    Console.WriteLine(jogador == 0 ? "Vez do X" : "Vez do O");

    try
    {

        Console.WriteLine("Selecione uma linha");
        int linha = Convert.ToInt32(Console.ReadLine());

        if (linha < 0 || linha > 2)
        {
            Console.WriteLine("Numero inválido");
            continue;
        }

        Console.WriteLine("Selecione uma coluna");
        int coluna = Convert.ToInt32(Console.ReadLine());

        if (coluna < 0 || coluna > 2)
        {
            Console.WriteLine("Numero inválido");
            continue;
        }

        if (jogo[linha, coluna] != " ")
        {
            Console.WriteLine("Este espaço já está ocupado!");
            continue;
        }
        else
        {
            jogo[linha, coluna] = jogador == 0 ? "X" : "O";
            jogador = jogador == 0 ? jogador = 1 : 0;
        }

        for (int i = 0; i < 2; i++)
        {
            if(i == 0)
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
                continuar = false;
                break;
            }
            if (jogo[1, 0] == letra && jogo[1, 1] == letra && jogo[1, 2] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }
            if (jogo[2, 0] == letra && jogo[2, 1] == letra && jogo[2, 2] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }

            // Linhas verticais

            if (jogo[0, 0] == letra && jogo[1, 0] == letra && jogo[2, 0] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }
            if (jogo[0, 1] == letra && jogo[1, 1] == letra && jogo[2, 1] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }
            if (jogo[0, 2] == letra && jogo[1, 2] == letra && jogo[2, 2] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }

            // Diagonais

            if (jogo[0, 0] == letra && jogo[1, 1] == letra && jogo[2, 2] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }
            if (jogo[0, 2] == letra && jogo[1, 1] == letra && jogo[2, 0] == letra)
            {
                winner = letra;
                continuar = false;
                break;
            }
        }

        // Verificar velha
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if(jogo[i, j] != " ")
                {
                    velhas++;
                }
            }
        }

        if(velhas == 9)
        {
            Console.Clear();
            Console.WriteLine($"{jogo[0, 0]}|{jogo[0, 1]}|{jogo[0, 2]}");
            Console.WriteLine("- - -");
            Console.WriteLine($"{jogo[1, 0]}|{jogo[1, 1]}|{jogo[1, 2]}");
            Console.WriteLine("- - -");
            Console.WriteLine($"{jogo[2, 0]}|{jogo[2, 1]}|{jogo[2, 2]}");
            Console.WriteLine();
            Console.WriteLine("Fim de jogo. Deu velha.");
        }
        else
        {
            velhas = 0;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine("Use apenas números");
    }

    Console.Clear();

}
while (continuar) ;

Console.Clear();
Console.WriteLine($"{jogo[0, 0]}|{jogo[0, 1]}|{jogo[0, 2]}");
Console.WriteLine("- - -");
Console.WriteLine($"{jogo[1, 0]}|{jogo[1, 1]}|{jogo[1, 2]}");
Console.WriteLine("- - -");
Console.WriteLine($"{jogo[2, 0]}|{jogo[2, 1]}|{jogo[2, 2]}");
Console.WriteLine();
Console.WriteLine("Fim de jogo. Ganhador: " + winner);