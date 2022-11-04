Random generateNumber = new Random();

int attempts = 0;
int drawnNumber = generateNumber.Next(101);

bool gameActive = true;

do
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
while (gameActive);

Console.WriteLine($"Tentativas necessárias: {attempts}");