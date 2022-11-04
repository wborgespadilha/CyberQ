Console.WriteLine("Insira o primeiro número");
double primeiroNumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o segundo número");
double segundoNumero = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Selecione o tipo de operação");
Console.WriteLine("1 - soma");
Console.WriteLine("2 - subtração");
Console.WriteLine("3 - multiplicação");
Console.WriteLine("4 - divisão");

int codigoOperacao = Convert.ToInt32(Console.ReadLine());

if(codigoOperacao == 1)
{
    Console.WriteLine(primeiroNumero + segundoNumero);
}
else if(codigoOperacao == 2)
{
    Console.WriteLine(primeiroNumero - segundoNumero);
}
else if(codigoOperacao == 3)
{
    Console.WriteLine(primeiroNumero * segundoNumero);
}
else if (codigoOperacao == 4)
{
    Console.WriteLine(primeiroNumero / segundoNumero);
}
else
{
    Console.WriteLine("Seleção inválida.");
}
