Console.WriteLine("Insira os números");

int totalNumbers = 0;
double number = -1;

int evenNumbers = 0;
int oddNumbers = 0;
int positiveNumbers = 0;
int negativeNumbers = 0;

try
{

    do
    {
        number = Convert.ToDouble(Console.ReadLine());
        if (number != 0)
        {
            totalNumbers++;
        }

        if (number < 0)
        {
            negativeNumbers++;
        }
        if (number > 0)
        {
            positiveNumbers++;
        }

        if (number % 2 == 0)
        {
            evenNumbers++;
        }
        else
        {
            oddNumbers++;
        }
    }
    while (number != 0);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Quantidade de números informados: " + totalNumbers);
Console.WriteLine("Numeros pares: " + evenNumbers);
Console.WriteLine("Numeros impares: " + oddNumbers);
Console.WriteLine("Numeros positivos: " + positiveNumbers);
Console.WriteLine("Numeros negativos: " + negativeNumbers);