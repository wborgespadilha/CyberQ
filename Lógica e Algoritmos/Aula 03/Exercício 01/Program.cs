string[] nomes = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Insira o " + (i + 1) + "º nome");
    nomes[i] = Console.ReadLine();
}

Console.Clear();

for(int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("Nome : " + nomes[i]);
}

