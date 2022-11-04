Console.WriteLine("Insira o tipo de conversão");
Console.WriteLine("1 - Celsius para Fahrenheit");
Console.WriteLine("2 - Fahrenheit para Celsius");

int tipoConversao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o valor");

double valorInserido = Convert.ToDouble(Console.ReadLine());

if (tipoConversao == 1)
{
    Console.WriteLine( (valorInserido * 1.8) + 32);
}
else if(tipoConversao == 2)
{
    Console.WriteLine( ((valorInserido - 32) * 5) / 9);
}
else
{
    Console.WriteLine("Converão inválida.");
}