try
{

    Console.WriteLine("A tabuada de qual número você deseja ver?");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Deseja ver até que termo?");
    int limit = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Tabuada do: " + number);

    int index = 1;
    while (index <= limit)
    {
        Console.WriteLine(index + " x " + number + " = " + number * index);
        index++;
    }
}
catch(Exception ex)
{ 
    Console.WriteLine(ex.Message); 
}
