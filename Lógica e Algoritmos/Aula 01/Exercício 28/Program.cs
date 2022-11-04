Console.WriteLine("Insira o tipo de conversão");
Console.WriteLine("1 - Metros para quilômetros");
Console.WriteLine("2 - Quilômetros para metros");

int tipoConversao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o valor");

double valorInserido = Convert.ToDouble(Console.ReadLine());

if(tipoConversao == 1)
{
    Console.WriteLine(valorInserido / 1000 + " KM");
}
else if(tipoConversao == 2)
{
    Console.WriteLine(valorInserido * 1000 + " Metros");
}
else
{
    Console.WriteLine("Seleção inválida.");
}