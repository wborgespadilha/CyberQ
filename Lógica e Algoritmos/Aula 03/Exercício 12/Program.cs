int[,] matriz =
{
    {5,8,0,1,4},
    {6,8,4,1,7},
    {9,4,7,9,1},
    {8,3,6,1,4},
    {9,1,5,2,7}
};

int soma = 0;
int media = 0;
int maioresQueMedia = 0;

//Somando todos os valores
for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        soma += matriz[i,j];
    }
}

media = soma / 25;

//Verificando a quantidade de valores maiores que a média
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (matriz[i,j] > media)
        {
            maioresQueMedia++;
        }
    }
}

Console.Clear();
Console.WriteLine($"Soma da matriz: {soma}, média: {media} \nNúmeros maiores que a média {maioresQueMedia}");
Console.WriteLine("Números da diagonal principal:");
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == j)
        {
            Console.WriteLine(matriz[i,j]);
        }
    }
}

Console.WriteLine();
Console.WriteLine("Números da diagonal secundária:");
Console.WriteLine();

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(matriz[i,(4-i)]);
}