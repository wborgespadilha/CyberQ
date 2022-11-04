Console.WriteLine("Insira o dia de nascimento:");
int diaNascimento = Convert.ToInt32(Console.ReadLine());

if(diaNascimento <= 0 || diaNascimento > 31)
{
    Console.WriteLine("Dia inválido.");
    return;
}

Console.WriteLine("Insira o mês de nascimento:");
int mesNascimento = Convert.ToInt32(Console.ReadLine());

if (mesNascimento <= 0 || mesNascimento > 12)
{
    Console.WriteLine("Mês inválido.");
    return;
}

if (mesNascimento == 1)
{
    if(diaNascimento <= 20)
    {
        Console.WriteLine("Capricórnio");
    }
    else
    {
        Console.WriteLine("Aquário");
    }
}
else if(mesNascimento == 2)
{
    if (diaNascimento <= 18)
    {
        Console.WriteLine("Aquário");
    }
    else
    {
        Console.WriteLine("Peixes");
    }
}
else if (mesNascimento == 3)
{
    if (diaNascimento <= 20)
    {
        Console.WriteLine("Peixes");
    }
    else
    {
        Console.WriteLine("Áries");
    }
}
else if (mesNascimento == 4)
{
    if (diaNascimento <= 20)
    {
        Console.WriteLine("Áries");
    }
    else
    {
        Console.WriteLine("Touro");
    }
}
else if (mesNascimento == 5)
{
    if (diaNascimento <= 21)
    {
        Console.WriteLine("Touro");
    }
    else
    {
        Console.WriteLine("Gêmeos");
    }
}
else if (mesNascimento == 6)
{
    if (diaNascimento <= 20)
    {
        Console.WriteLine("Gêmeos");
    }
    else
    {
        Console.WriteLine("Câncer");
    }
}
else if (mesNascimento == 7)
{
    if (diaNascimento <= 22)
    {
        Console.WriteLine("Câncer");
    }
    else
    {
        Console.WriteLine("Leão");
    }
}
else if (mesNascimento == 8)
{
    if (diaNascimento <= 22)
    {
        Console.WriteLine("Leão");
    }
    else
    {
        Console.WriteLine("Virgem");
    }
}
else if (mesNascimento == 9)
{
    if (diaNascimento <= 22)
    {
        Console.WriteLine("Virgem");
    }
    else
    {
        Console.WriteLine("Libra");
    }
}
else if (mesNascimento == 10)
{
    if (diaNascimento <= 22)
    {
        Console.WriteLine("Libra");
    }
    else
    {
        Console.WriteLine("Escorpião");
    }
}
else if (mesNascimento == 11)
{
    if (diaNascimento <= 21)
    {
        Console.WriteLine("Escorpião");
    }
    else
    {
        Console.WriteLine("Sagitário");
    }
}
else if (mesNascimento == 12)
{
    if (diaNascimento <= 21)
    {
        Console.WriteLine("Sagitário");
    }
    else
    {
        Console.WriteLine("Capricórnio");
    }
}
