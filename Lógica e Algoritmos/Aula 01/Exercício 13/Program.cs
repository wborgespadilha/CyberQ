Console.WriteLine("Insira o primeiro número inteiro");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo número inteiro");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o terceiro número inteiro");
int terceiroNumero = Convert.ToInt32(Console.ReadLine());


// Escrevendo o menor de todos
int menorNumero = primeiroNumero;

if(segundoNumero < menorNumero)
{
    menorNumero = segundoNumero;
}
if(terceiroNumero < menorNumero)
{
    menorNumero = terceiroNumero;
}

// Escrevendo o maior
int maiorNumero = primeiroNumero;

if(segundoNumero > maiorNumero)
{
    maiorNumero = segundoNumero;
}
if(terceiroNumero > maiorNumero)
{
    maiorNumero = terceiroNumero;
}

// Escrevendo o médio

int numeroMedio = 0;

if ((maiorNumero == segundoNumero && menorNumero == terceiroNumero) || (maiorNumero == terceiroNumero && menorNumero == segundoNumero))
{
    numeroMedio = primeiroNumero;
}
if ((maiorNumero == primeiroNumero && menorNumero == terceiroNumero) || (maiorNumero == terceiroNumero && menorNumero == primeiroNumero))
{
    numeroMedio = segundoNumero;
}
if((maiorNumero == primeiroNumero && menorNumero == segundoNumero) || (maiorNumero == segundoNumero && menorNumero == primeiroNumero))
{
    numeroMedio = terceiroNumero;
}


Console.WriteLine(menorNumero); 
Console.WriteLine(numeroMedio);
Console.WriteLine(maiorNumero);

// O programa funciona mas acho que poderia ser mais simples.