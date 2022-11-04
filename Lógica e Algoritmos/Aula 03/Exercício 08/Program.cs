string[] nomes = new string[5];
bool continuar = true;

for (int i = 0; i < nomes.Length; i++)
{
    while (continuar)
    {
        Console.WriteLine("Informe o " + (i + 1) + "º nome");
        nomes[i] = Console.ReadLine();

        continuar = false;

        for (int j = 0; j < nomes.Length; j++)
        {
            if (i != j)
            {
                if (nomes[j] == nomes[i])
                {
                    Console.WriteLine("Não são permitidos valores duplicados!");
                    continuar = true;
                }
            }
        }
    }
    continuar = true;
}

Console.Clear();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine((i + 1) + "º nome = " + nomes[i]);
}
