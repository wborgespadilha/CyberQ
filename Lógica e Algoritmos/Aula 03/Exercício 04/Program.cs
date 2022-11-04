int[] valores = new int[10];
bool continuar = true;

for (int i = 0; i < valores.Length; i++)
{
    while (continuar)
    {
        try
        {

            Console.WriteLine("Informe o " + (i + 1) + "º valor");
            valores[i] = Convert.ToInt32(Console.ReadLine());

            continuar = false;

            for (int j = 0; j < valores.Length; j++)
            {
                if (i != j)
                {
                    if (valores[j] == valores[i])
                    {
                        Console.WriteLine("Não são permitidos valores duplicados!");
                        continuar = true;
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Insira apenas números");
            continuar = true;
        }
    }
    continuar = true;
}

Console.Clear();

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine((i+1) + "º valor = " + valores[i]);
}
