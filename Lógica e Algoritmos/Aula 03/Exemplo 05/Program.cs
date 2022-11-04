// Matriz
string[,] matriz = new string[3, 2];

// Armazenar dados
for(int i = 0; i < matriz.GetLength(0); i++)
{
    Console.WriteLine("Informe o " + (i+1) + "º nome");
    matriz[i, 0] = Console.ReadLine();

    Console.WriteLine("Informe a idade de " + matriz[i,0]);
    matriz[i, 1] = Console.ReadLine();
}

// Limpar console
Console.Clear();

// Listar dados
for(int i = 0; i < matriz.GetLength(0); i++)
{
    Console.WriteLine("Nome: " + matriz[i,0]);
    Console.WriteLine("Idade: " + matriz[i,1]);
    Console.WriteLine();
}