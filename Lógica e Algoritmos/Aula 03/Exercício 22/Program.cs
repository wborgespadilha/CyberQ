string[] cidades = { "Pomerode", "Blumenau", "Timbó", "Rio dos cedros", "Jaraguá", "Florianópolis", "Brusque", "Chapecó", "Ituporanga", "São Paulo" };
int[] valoresLidos = new int[10];

Random random = new Random();

int cidadeSorteada;
int indice = 0;
int sucessos = 0;

while(sucessos < 5)
{

    cidadeSorteada = random.Next(0, 10);

    bool jaLido = false;
        
    //Comparando o valor sorteado com a lista de valores já usados
    for (int j = 0; j < 10; j++)
    {
        if (cidadeSorteada == valoresLidos[j])
        {
            jaLido = true;
        }
    }

    if (jaLido == false)
    {
        valoresLidos[indice] = cidadeSorteada;

        sucessos++;
        indice++;

        Console.WriteLine(cidades[cidadeSorteada]);
    }

}