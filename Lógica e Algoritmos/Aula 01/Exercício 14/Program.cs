Console.WriteLine("Insira um número inteiro");
int numeroInserido = Convert.ToInt32(Console.ReadLine());

if(numeroInserido == 0)
{
    Console.WriteLine("Numero nulo");
}
else if (numeroInserido > 0)
{
    Console.WriteLine("Numero positivo");
}
else
{
    Console.WriteLine("Numero negativo");
}
