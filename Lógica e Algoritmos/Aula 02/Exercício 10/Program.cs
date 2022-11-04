int sumFirstCandidate = 0;
int sumSecondCandidate = 0;
int sumThirdCandidate = 0;
int sumFourthCandidate = 0;

bool continueElection = true;

do
{
    Console.WriteLine("Insira 1 para votar no Kraken");
    Console.WriteLine("Insira 2 para votar em Cthulhu");
    Console.WriteLine("insira 3 para votar em Godzilla");
    Console.WriteLine("Insira 4 para votar em King Kong");

    try
    {
        int vote = Convert.ToInt32(Console.ReadLine());

        switch (vote)
        {
            case 1:
                sumFirstCandidate++;
                break;

            case 2:
                sumSecondCandidate++;
                break;

            case 3:
                sumThirdCandidate++;
                break;

            case 4:
                sumFourthCandidate++;
                break;

            default:
                Console.WriteLine("Voto inválido");
                break;
        }

        Console.WriteLine("Deseja continuar a votação?");
        Console.WriteLine("1- Sim, 2 - Não");

        vote = Convert.ToInt32(Console.ReadLine());

        if (vote != 1)
        {
            continueElection = false;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);  
    }

    Console.WriteLine();
}
while (continueElection);

double totalSum = sumFirstCandidate + sumSecondCandidate + sumThirdCandidate + sumFourthCandidate;

double firstPorcentage = sumFirstCandidate / totalSum;
double secondPorcentage = sumSecondCandidate / totalSum;
double thirdPorcentage = sumThirdCandidate / totalSum;
double fourthPorcentage = sumFourthCandidate / totalSum;

Console.WriteLine("Kraken, votos: " + sumFirstCandidate + " Porcentagem: " + firstPorcentage.ToString("P2"));
Console.WriteLine("Cthulhu, votos: " + sumSecondCandidate + " Porcentagem: " + secondPorcentage.ToString("P2"));
Console.WriteLine("Godzilla, votos: " + sumThirdCandidate + " Porcentagem: " + thirdPorcentage.ToString("P2"));
Console.WriteLine("King Kong, votos: " + sumFourthCandidate + " Porcentagem: " + fourthPorcentage.ToString("P2"));

int biggestSum = sumFirstCandidate;
if(sumSecondCandidate > biggestSum) { biggestSum = sumSecondCandidate; }
if(sumThirdCandidate > biggestSum) { biggestSum = sumThirdCandidate; }
if(sumFourthCandidate > biggestSum) { biggestSum = sumFourthCandidate; }

if(biggestSum == sumFirstCandidate)
{
    Console.WriteLine("O candidato eleito é o Kraken!");
}
if (biggestSum == sumSecondCandidate)
{
    Console.WriteLine("O candidato eleito é o Cthulhu!");
}
if (biggestSum == sumThirdCandidate)
{
    Console.WriteLine("O candidato eleito é o Godzilla!");
}
if (biggestSum == sumFourthCandidate)
{
    Console.WriteLine("O candidato eleito é o King Kong!");
}