Console.WriteLine("Insira o primeiro numero");
double primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo numero");
double segundoNumero = Convert.ToInt32(Console.ReadLine());

if(primeiroNumero == segundoNumero)
{
    Console.WriteLine(primeiroNumero + segundoNumero);
}
else
{
    Console.WriteLine(primeiroNumero * segundoNumero);
}
