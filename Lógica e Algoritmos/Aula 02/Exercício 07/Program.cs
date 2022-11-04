Console.WriteLine("Insira um número");
try
{
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = number - 1; i >= 1; i--)
    {
        Console.WriteLine(number + " x " + i + " = " + number * i);
        number = number * i;
    }
}
catch(Exception ex)
{ 
    Console.WriteLine(ex.Message); 
}
