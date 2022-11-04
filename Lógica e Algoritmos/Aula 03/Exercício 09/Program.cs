int[] valores = new int[10];
int soma = 0;
int somaMaiores = 0;
double media;
bool repeat = false;

for (int i = 0; i < valores.Length; i++)
{
    do
    {
        try
        {
            Console.WriteLine("Informe o " + (i + 1) + "º valor");
            valores[i] = Convert.ToInt32(Console.ReadLine());
            soma += valores[i];
            Console.Clear();
            repeat = false;
        }
        catch(Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Insira apenas números");
            repeat = true;
        }
    }
    while (repeat);
}

media = soma / 10;
Console.Clear();

Console.WriteLine("Soma dos 10 valores: " + soma);
Console.WriteLine("Média dos 10 valores: " + media);
Console.WriteLine();

for(int i = 0; i < valores.Length; i++)
{
    if (valores[i] > media)
    {
        Console.WriteLine("O número " + valores[i] + " é maior do que a média");
        somaMaiores++;
    }
}

Console.WriteLine();
Console.WriteLine("No total existem " + somaMaiores + " números maiores que a média");