string[] nome = new string[100];
int index = 0;

bool repeatQuestion = false;
bool continuar = true;

do
{
    Console.WriteLine("Insira um nome:");
    nome[index] = Console.ReadLine();
    index++;

    do
    {
        try
        {
            Console.WriteLine("Deseja continuar?\n1) Sim\n2) Não");
            int selecao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (selecao == 2)
            {
                continuar = false;
                repeatQuestion = false;
            }
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Número inválido inserido");
            repeatQuestion = true;
        }
    }
    while (repeatQuestion);
}
while(continuar);


Console.Clear();
Console.WriteLine("Nomes:");

for(int i = 0; i < nome.Length; i++)
{
    if (nome[i] != null)
    {
        Console.WriteLine(nome[i]);
    }
}