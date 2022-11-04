Random generateNumber = new Random();

int attempts = 0;
int playerCount = 1;

bool gameActive = true;


Console.WriteLine("Insira a quantidade de jogadores:");
int qntd = Convert.ToInt32(Console.ReadLine());

string[,] jogadores = new string[qntd,2];


do
{
    Console.WriteLine("Insira o nome do " + playerCount + "º jogador");
    string nome = Console.ReadLine();

    int drawnNumber = generateNumber.Next(101);

    do
    {
        try
        {
            Console.WriteLine("Insira um número de 1 a 100");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            int difference = Math.Abs(number - drawnNumber);
            attempts++;

            if (difference == 0)
            {
                Console.WriteLine("Parabéns, você acertou!");
                gameActive = false;
            }
            else if (difference < 10)
            {
                Console.WriteLine("Muito perto.");
            }
            else if (difference < 20)
            {
                Console.WriteLine("Longe.");
            }
            else
            {
                Console.WriteLine("Muito Longe");
            }
        }
        catch(Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Insira apenas números interos");
            Console.WriteLine();
        }

    }
    while (gameActive);

    jogadores[playerCount-1, 0] = nome;
    jogadores[playerCount-1, 1] = attempts.ToString();

    attempts = 0;
    playerCount++;
    gameActive = true;

}
while (playerCount <= qntd);


//Ordenar os valores ORDEM CRESCENTE
for (int i = 0; i < jogadores.GetLength(0); i++)
{
    for (int j = 0; j < jogadores.GetLength(0); j++)
    {
        if (Convert.ToInt32(jogadores[i, 1]) < Convert.ToInt32(jogadores[j, 1]))
        {
            int temp = Convert.ToInt32(jogadores[j, 1]);
            jogadores[j, 1] = jogadores[i, 1];
            jogadores[i, 1] = temp.ToString();

            string tempStr = jogadores[j, 0];
            jogadores[j, 0] = jogadores[i, 0];
            jogadores[i, 0] = tempStr;
        }
    }
}

for(int i = 0; i < jogadores.GetLength(0); i++)
{
    Console.WriteLine($"Jogador: {jogadores[i,0]} Tentativas necessárias: {jogadores[i, 1]}");
}
