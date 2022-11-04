string firstName = "";
string secondName = "";
string thirdName = "";

bool firstInformed = false;
bool secondInformed = false;
bool thirdInformed = false;

bool continueAsking = true;

do
{
    Console.WriteLine("Insira um nome");
    string tempName = Console.ReadLine();

    if (tempName != firstName && tempName != secondName && tempName != thirdName)
    {
        if (firstInformed == false)
        {
            firstName = tempName;
        }
        if(secondInformed == false && firstInformed == true)
        {
            secondName = tempName;
        }
        if(thirdInformed == false && secondInformed == true && firstInformed == true)
        {
            thirdName = tempName;
        }

        if(firstName != "")
        {
            firstInformed = true;
        }
        if (secondName != "")
        {
            secondInformed = true;
        }
        if (thirdName != "")
        {
            thirdInformed = true;
            continueAsking = false;
        }
    }
    else
    {
        Console.WriteLine("Não são permitidos nomes iguais!");
    }
} 
while (continueAsking);

Console.WriteLine($"Nome 1: {firstName}, nome 2: {secondName}, nome 3:{thirdName}");
