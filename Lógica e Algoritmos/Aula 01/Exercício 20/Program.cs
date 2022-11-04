Console.WriteLine("Insira o tipo de conversão");
Console.WriteLine("1 - Real para Dólar");
Console.WriteLine("2 - Dólar para Real");
Console.WriteLine("3 - Real para Euro");
Console.WriteLine("4 - Euro para Real");
Console.WriteLine("5 - Real para Libra");
Console.WriteLine("6 - Libra para Real");
Console.WriteLine("7 - Real para Peso Argentino");
Console.WriteLine("8 - Peso Argentino para Real");

int conversaoSelecionada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o valor");

double valorInserido = Convert.ToDouble(Console.ReadLine());

if (conversaoSelecionada == 1)
{
    Console.WriteLine(valorInserido / 4.8 +" Dólares");
}
else if (conversaoSelecionada == 2)
{
    Console.WriteLine(valorInserido * 4.8 +" Reais");
}
else if (conversaoSelecionada == 3)
{
    Console.WriteLine(valorInserido / 5.12 +" Euros");
}
else if (conversaoSelecionada == 4)
{
    Console.WriteLine(valorInserido * 5.12 +" Reais");
}
else if (conversaoSelecionada == 5)
{
    Console.WriteLine(valorInserido / 6.03 +" Libras");
}
else if (conversaoSelecionada == 6)
{
    Console.WriteLine(valorInserido * 6.03 +" Reais");
}
else if (conversaoSelecionada == 7)
{
    Console.WriteLine(valorInserido / 0.04 +" Pesos");
}
else if (conversaoSelecionada == 8)
{
    Console.WriteLine(valorInserido * 0.04 +" Reais");
}