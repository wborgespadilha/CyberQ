string[,] matriz = new string[5, 3];

int cadastrados = 0;

while(cadastrados < 5)
{
    Console.WriteLine("Insira um nome");
    string nome = Console.ReadLine();

    DateTime dataHora = DateTime.Now;

    matriz[cadastrados, 0] = nome;
    matriz[cadastrados, 1] = dataHora.ToString("dd/MM/yyyy");
    matriz[cadastrados, 2] = dataHora.ToString("HH:mm:ss");

    cadastrados++;

    Console.Clear();
}

Console.Clear();
Console.WriteLine("Nomes e datas e horas:");
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(matriz[i, 0] + " - " + matriz[i, 1] + " - " + matriz[i, 2]);
}