// Vetor
string[] nomes = new string[50];

// Indice
int indice = 0;

// Laço
do
{
    // Obter um nome
    Console.WriteLine("Informe o " + (indice+1) + "º nome");
    nomes[indice] = Console.ReadLine();

    //Limpar console
    Console.Clear();

    // Incrementar o índice
    indice++;

    // Veirifica se deseja cadastrar mais um usuário
    Console.WriteLine("Deseja cadastrar mais um usuário?");
    Console.WriteLine("1) SIM");
    Console.WriteLine("2) NÃO");

    int continuar = Convert.ToInt32(Console.ReadLine());

    if(continuar == 2)
    {
        break;
    }

}
while (true);

// Limpar 
Console.Clear();

// Listar todos os usuários cadastrados
for(int i = 0; i < nomes.Length; i++)
{
    if (nomes[i] != null)
    {
        Console.WriteLine("O " + (i+1) + "º nome é " + nomes[i]);
    }
}