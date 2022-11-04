Console.WriteLine("Insira o primeiro lado");
double primeiroLado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo lado");
double segundoLado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o terceiro lado");
double terceiroLado = Convert.ToInt32(Console.ReadLine());

if(primeiroLado == segundoLado && segundoLado == terceiroLado)
{
    Console.WriteLine("Triangulo equilátero");
}
if(primeiroLado == segundoLado || segundoLado == terceiroLado || primeiroLado == terceiroLado)
{
    Console.WriteLine("Triangulo isóceles");
}
else
{
    Console.WriteLine("Triangulo escaleno");
}