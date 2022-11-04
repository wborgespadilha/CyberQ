Console.WriteLine("Insira os números");

double sum = 0;
double number = -1;
try
{
    do
    {
        number = Convert.ToDouble(Console.ReadLine());
        sum = sum + number;
    }
    while (number != 0);
}
catch(Exception ex)
{ 
    Console.WriteLine(ex.Message); 
}

Console.WriteLine(sum);