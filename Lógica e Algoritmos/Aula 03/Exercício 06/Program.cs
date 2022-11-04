int[] valores = new int[5];
int contador = 0;

bool repeat = false;

for (int i = 0; i < valores.Length; i++)
{
    do
    {
        try
        {

            Console.WriteLine("Informe o " + (i + 1) + "º valor");
            valores[i] = Convert.ToInt32(Console.ReadLine());
            repeat = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Insira apenas numeros");
            repeat = true;
        }
    }
    while(repeat);
}

Console.Clear();

for (int i = 0; i < valores.Length; i++)
{
    if(valores[i] == 10)
    {
        Console.WriteLine("Existe um número 10 na posição " + i);
        contador++;
    }
}

if(contador == 0)
{
    Console.WriteLine("Não foram encontrados números 10.");
}