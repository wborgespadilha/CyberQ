int[] valores = new int[5];

for(int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("Insira o valor");
        valores[i] = Convert.ToInt32(Console.ReadLine());
    }
    catch(Exception ex)
    {
        Console.WriteLine("Insira apenas números");
    }
}

Console.Clear();

for(int i = 4; i >= 0; i--)
{
    Console.WriteLine(valores[i]);
}