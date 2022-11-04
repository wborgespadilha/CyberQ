string[,] matriz =
{
    {"João","12345"},
    {"William","abcde"},
    {"Leo","ABCDEF"}
};

bool continuar = true;
int erros = 0;

while(continuar)
{
    Console.WriteLine("Insira o usuário");
    string usuario = Console.ReadLine();

    Console.WriteLine("Insira a senha");
    string senha = Console.ReadLine();

    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        if(usuario == matriz[i, 0] && senha == matriz[i, 1])
        {
            continuar = false;
            break;
        }
    }

    if (continuar)
    {
        Console.Clear();
        Console.WriteLine("Senha ou usuário inválidos");

        erros++;

        if (erros == 3)
        {
            Console.WriteLine("Aguarde 30 segundos para tentar novamente");
            Thread.Sleep(30000);
        }
    }

}