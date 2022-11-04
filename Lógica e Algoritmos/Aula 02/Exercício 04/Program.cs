try
{

    Console.WriteLine("Insira um número");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Antecessores");
    for (int i = number - 10; i < number; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();

    Console.WriteLine("Sucessores");
    for (int i = number + 1; i < number + 11; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}