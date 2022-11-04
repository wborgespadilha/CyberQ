bool continueAsking = true;
int biggestAge = 0;
string name = "";

do
{
    Console.WriteLine("Insira o nome");
    string tempName = Console.ReadLine();

    Console.WriteLine("Insira a idade");
    int tempAge = Convert.ToInt32(Console.ReadLine());

    if(biggestAge == 0)
    {
        biggestAge = tempAge;
    }
    else if(tempAge > biggestAge)
    {
        biggestAge = tempAge;
        name = tempName;
    }

    Console.WriteLine("Para parar o programa digite qualquer coisa");
    Console.WriteLine("Para continuar aperte enter");

    tempName = Console.ReadLine();
    if(tempName != "")
    {
        continueAsking = false;
    }

    Console.Clear();
}

while (continueAsking);

Console.WriteLine($"A maior idade é {biggestAge} e o nome é: {name}");
