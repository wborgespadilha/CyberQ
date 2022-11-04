// Matriz
string[,] dados =
{
    {"Ana",      "20"},
    {"Caio",     "31"},
    {"Daniela" , "34"},
};

// Exibir o primeiro nome e a idade
Console.WriteLine("O primeiro nome é: " + dados[0,0] + " e tem " + dados[0,1] + " anos");

// Separar
Console.WriteLine("------------");

// Listar todos os dados
for(int i = 0; i < dados.GetLength(0); i++)
{
    Console.WriteLine((i+1) + "º usuário cadastrado:");
    Console.WriteLine("Nome : " + dados[i,0]);
    Console.WriteLine("Idade: " + dados[i,1]);
    Console.WriteLine();
}