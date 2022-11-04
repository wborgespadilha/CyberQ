Console.WriteLine("Insira o primeiro lado");
double primeiroLado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo lado");
double segundoLado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o terceiro lado");
double terceiroLado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o quarto lado");
double quartoLado = Convert.ToInt32(Console.ReadLine());

if(primeiroLado == segundoLado && segundoLado == terceiroLado && terceiroLado == quartoLado)
{
    Console.WriteLine("A figura é um quadrado");
}
else
{
    Console.WriteLine("A figura não é um quadrado");
}