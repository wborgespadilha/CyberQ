Console.WriteLine("Insira a velocidade máxima da pista");
int velocidadeMaxima = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a velocidade do veículo");
int velocidadeRegistrada = Convert.ToInt32(Console.ReadLine());


if (velocidadeRegistrada > (velocidadeMaxima + 30))
{
    Console.WriteLine("Multa de R$300,00");
}
else if (velocidadeRegistrada > (velocidadeMaxima + 20))
{
    Console.WriteLine("Multa de R$200,00");
}
else if (velocidadeRegistrada > (velocidadeMaxima + 10))
{
    Console.WriteLine("Multa de R$100,00");
}
else if (velocidadeRegistrada > velocidadeMaxima)
{
    Console.WriteLine("Multa de R$50,00");
}
else
{
    Console.WriteLine("Bom motorista, sem multa :D");
}
