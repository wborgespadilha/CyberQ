Console.WriteLine("Selecione o estado");
Console.WriteLine("1 - Santa Catarina");
Console.WriteLine("2 - Paraná");
Console.WriteLine("3 - Rio grande do sul");
int estadoSelecionado = Convert.ToInt16(Console.ReadLine());

if (estadoSelecionado == 1)
{
    Console.WriteLine("Selecione a cidade");
    Console.WriteLine("1 - Blumenau");
    Console.WriteLine("2 - Pomerode");
    Console.WriteLine("3 - Timbó");
    int cidadeSelecionada = Convert.ToInt16(Console.ReadLine());
    if (cidadeSelecionada == 1)
    {
        Console.WriteLine("Blumenau possui cerca de 300 mil habitantes");
    }
    else if (cidadeSelecionada == 2)
    {
        Console.WriteLine("Pomerode é a cidade mais alemã do brasil");
    }
    else if (cidadeSelecionada == 3)
    {
        Console.WriteLine("Timbó tem uma população de 45 mil habitantes");
    }
    else
    {
        Console.WriteLine("Cidade selecionada inválida");
    }
}
else if (estadoSelecionado == 2)
{
    Console.WriteLine("Selecione a cidade");
    Console.WriteLine("1 - Curitiba");
    Console.WriteLine("2 - Quedas do iguaçu");
    Console.WriteLine("3 - Foz do iguaçu");
    int cidadeSelecionada = Convert.ToInt16(Console.ReadLine());
    if (cidadeSelecionada == 1)
    {
        Console.WriteLine("Curitiba significa 'muito pinhão' em lingua indígena");
    }
    else if (cidadeSelecionada == 2)
    {
        Console.WriteLine("A maior empresa de quedas é a madeireira Araupel");
    }
    else if (cidadeSelecionada == 3)
    {
        Console.WriteLine("Foz do inguaçu faz fronteira com o paraguai");
    }
    else
    {
        Console.WriteLine("Cidade selecionada inválida");
    }
}
else if (estadoSelecionado == 3)
{
    Console.WriteLine("Selecione a cidade");
    Console.WriteLine("1 - Porto alegre");
    Console.WriteLine("2 - Gramado");
    Console.WriteLine("3 - Soledade");
    int cidadeSelecionada = Convert.ToInt16(Console.ReadLine());
    if (cidadeSelecionada == 1)
    {
        Console.WriteLine("Porto alegre é a capital do rio grande");
    }
    else if (cidadeSelecionada == 2)
    {
        Console.WriteLine("Gramado é uma cidade altamente turística");
    }
    else if (cidadeSelecionada == 3)
    {
        Console.WriteLine("Soledade tem uma música própria, 'Xote soledade'");
    }
    else
    {
        Console.WriteLine("Cidade selecionada inválida");
    }
}
else
{
    Console.WriteLine("Estado selecionado inválido");
}