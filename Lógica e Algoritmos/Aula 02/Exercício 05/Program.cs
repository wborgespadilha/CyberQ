try
{
    Console.WriteLine("Informe o primeiro número");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o segundo número");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    int evenSum = 0;
    int oddSum = 0;
    int lowerNumber = 0;
    int biggestNumber = 0;

    if (firstNumber > secondNumber)
    {
        biggestNumber = firstNumber;
        lowerNumber = secondNumber;
    }
    else
    {
        biggestNumber = secondNumber;
        lowerNumber = firstNumber;
    }


    for (int i = lowerNumber; i <= biggestNumber; i++)
    {
        Console.WriteLine(i);
        if (i % 2 == 0)
        {
            evenSum++;
        }
        else
        {
            oddSum++;
        }
    }

    Console.WriteLine("Numeros Pares: " + evenSum);
    Console.WriteLine("Numeros Imares: " + oddSum);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
