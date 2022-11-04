string nome1 = "Ana";
string nome2 = "Caio";
string nome3 = "Daniela";

//Criar um vetor contendo três nomes
string[] nomes = { nome1, nome2, nome3 };

//Exibir nomes
for(int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

//Separar listagem
Console.WriteLine("---------");

//Exibir nomes
foreach(string nome in nomes)
{
    Console.WriteLine(nome);
}

//nome = nomes[i]

