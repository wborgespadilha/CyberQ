// Variável para continuar o laço de repetição
bool continuar = true;

// Laço
do
{
    try
    {

        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida");
        }
        else
        {
            continuar = false;
        }

    }
    catch(Exception erro)
    {
        Console.WriteLine("Falha ao obter a nota: " + erro.Message);
    }
}
while (continuar);