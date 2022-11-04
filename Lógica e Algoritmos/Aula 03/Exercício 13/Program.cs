char[,] palavras = 
{
    {'B','A','T','A','T','A'},
    {'C','A','R','V','A','O'},
    {'M','I','S','T','E','R'},
    {'E','X','C','E','T','O'},
    {'V','E','R','E','D','A'}
};

//Limitação: Aceita apenas palavaras com mesmo comprimento (6)

Random random = new Random();

int errorSum = 0;
int sum = 0;

bool continueGame = true;
bool foundLetter = false;

string usedLetters = "";

int escolhida = random.Next(0, 4);
int quantidade = palavras.GetLength(1);



char[] letras = new char[quantidade]; //Gabarito
char[] palavra = new char[quantidade]; //Exibido


//Populando o gabarito e a palavra a ser exibida
for (int i = 0; i < quantidade; i++)
{
    letras[i] = palavras[escolhida,i];
    palavra[i] = '_';
}

do
{ 
    try
    {
        //Exibindo status atual
        char letter = ' ';

        Console.WriteLine($"Erros: {errorSum}");
        Console.WriteLine($"Letras usadas: {usedLetters}");
        Console.Write("Palavra: ");

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(palavra[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Insira uma letra");
        letter = Convert.ToChar(Console.ReadLine().ToUpper());

        usedLetters += letter;

        Console.Clear();

        //Verificando Acertos
        for(int i = 0; i < quantidade; i++)
        {
            if(letter == letras[i])
            {
                palavra[i] = letras[i];
                foundLetter = true;
            }
        }

        //Verificando vitória
        for(int i = 0; i < quantidade; i++)
        {
            if(palavra[i] != '_')
            {
                sum++;
                if(sum == quantidade)
                {
                    Console.WriteLine("Você venceu!");
                    Console.Write("Palavra: ");
                    for (int j = 0; j < quantidade; j++)
                    {
                        Console.Write(letras[j]);
                    }
                    continueGame = false;
                    return;
                }
            }
        }
        sum = 0;

        //Verificando erros e derrota
        if(foundLetter == false)
        {
            errorSum++;
            if (errorSum == 7)
            {
                continueGame = false;
                Console.WriteLine("Fim de jogo.");
                Console.Write("A palavra era: ");
                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write(letras[i]);
                }
                Console.WriteLine();
                return;
            }
        }
        foundLetter = false;

    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Insira apenas uma letra");
    }

}
while (continueGame);
