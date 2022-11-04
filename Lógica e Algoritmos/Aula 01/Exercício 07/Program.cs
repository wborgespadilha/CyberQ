Console.WriteLine("Insira o primeiro número");
double primeiroNumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o segundo número");
double segundoNumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o terceiro número");
double terceiroNumero = Convert.ToDouble(Console.ReadLine());

double menorNumero = primeiroNumero;

if(segundoNumero < menorNumero)
{
    menorNumero = segundoNumero;
}
if(terceiroNumero < menorNumero)
{
    menorNumero = terceiroNumero;
}

Console.WriteLine("Menor número: " + menorNumero);
