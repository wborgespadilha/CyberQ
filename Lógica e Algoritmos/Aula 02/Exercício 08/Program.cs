char firstLetter = '_';
char secondLetter = '_';
char thirdLetter = '_';
char fourLetter = '_';
char fifthLetter = '_';
char sixLetter = '_';
char sevenLetter = '_';

int errorSum = 0;
bool continueGame = true;
string usedLetters = null;

Console.WriteLine("Palavra: " + firstLetter + secondLetter + thirdLetter + fourLetter + fifthLetter + sixLetter + sevenLetter);

do
{
    Console.WriteLine("Insira uma letra");
    try
    {
        char letter = Convert.ToChar(Console.ReadLine().ToUpper());
        Console.Clear();

        switch (letter)
        {
            case 'E':
                firstLetter = 'E';
                break;

            case 'S':
                secondLetter = 'S';
                break;

            case 'T':
                thirdLetter = 'T';
                break;

            case 'U':
                fourLetter = 'U';
                break;

            case 'D':
                fifthLetter = 'D';
                break;

            case 'A':
                sixLetter = 'A';
                break;

            case 'R':
                sevenLetter = 'R';
                break;

            default:
                errorSum++;
                if (errorSum == 7)
                {
                    continueGame = false;
                    Console.WriteLine("Fim de jogo. A palavra era ESTUDAR.");
                    return;
                }
                break;
        }
        usedLetters = usedLetters + " " + letter;

        Console.WriteLine($"Erros: {errorSum}");
        Console.WriteLine($"Letras usadas: {usedLetters}");
        Console.WriteLine("Palavra: " + firstLetter + secondLetter + thirdLetter + fourLetter + fifthLetter + sixLetter + sevenLetter);

        if (firstLetter != '_' && secondLetter != '_' && thirdLetter != '_' && fourLetter != '_' && fifthLetter != '_' && sixLetter != '_' && sevenLetter != '_')
        {
            Console.WriteLine("Você acertou!");
            continueGame = false;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


}
while (continueGame);