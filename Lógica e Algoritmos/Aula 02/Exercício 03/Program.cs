int sumFirstCandidate = 0;
int sumSecondCandidate = 0;
int sumThirdCandidate = 0;

bool continueElection = true;

do
{
    Console.WriteLine("Insira 1 para votar no Kraken");
    Console.WriteLine("Insira 2 para votar em Cthulhu");
    Console.WriteLine("insira 3 para votar em Godzilla");
    Console.WriteLine("insira 0 para finalizar a votação");
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

            case 0:
                continueElection = false;
                break;

            default:
                Console.WriteLine("Número inválido");
                break;

        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("");
    Console.WriteLine("");
}
while (continueElection);

Console.WriteLine("Votos para o Kraken: " + sumFirstCandidate);
Console.WriteLine("Votos para Cthulhu: " + sumSecondCandidate);
Console.WriteLine("Votos para o Godzilla: " + sumThirdCandidate);