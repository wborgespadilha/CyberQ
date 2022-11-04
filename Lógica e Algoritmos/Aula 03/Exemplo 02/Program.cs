// Criar vetor de nomes
string[] nomes = new string[3];

// Cadastrar três nomes

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("Informe o " + (i + 1) + "º nome");
    nomes[i] = Console.ReadLine();
}

// Listar nomes
foreach(string nome in nomes)
{
    Console.WriteLine(nome);
}