bool continuar = true;

string entrada = "";
int indice = 0;

while(continuar)
{
    Console.WriteLine("Insira um nome, insira sair para continuar");
    string nome = Console.ReadLine();

    if (nome == "sair")
    {
        continuar = false;
        continue;
    }

    entrada += nome + ",";

}

string[] vetor = entrada.Split(",");

string[,] matriz = new string[100, 2];

for(int i = 0; i < vetor.Length; i++)
{
    bool existe = false;
    for (int j = 0; j < matriz.GetLength(0); j++)
    {
        if (vetor[i] == matriz[j,0])
        {
            matriz[j, 1] = Convert.ToString(Convert.ToInt32(matriz[j, 1]) + 1);
            existe = true;
            break;
        }
    }
    if(existe == false)
    {
        matriz[indice, 0] = vetor[i];
        matriz[indice, 1] = Convert.ToString(Convert.ToInt32(matriz[indice, 1]) + 1);
        indice++;
    }
}

Console.Clear();
Console.WriteLine("Nomes:");
for(int i = 0; i < matriz.GetLength(0); i++)
{
    if (matriz[i , 0] != null && matriz[i, 0] != "")
    {
        Console.WriteLine(matriz[i, 0] + " vezes: " + matriz[i, 1]);
    }
}