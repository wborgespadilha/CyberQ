int[] valores = new int[5];

bool repeat = false;

//Pedir os valores
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
        catch(Exception ex)
        {
            Console.WriteLine("Insira apenas números");
            repeat = true;
        }
    }
    while (repeat);
}

//Ordenar os valores
for(int i = 0; i < valores.Length; i++)
{
    for(int j = 0; j < valores.Length; j++)
    {

        if(valores[i] > valores[j])
        {
            int temp = valores[j];
            valores[j] = valores[i];
            valores[i] = temp;
        }
    }
}


//Exibir os valores
for(int i = 0; i < valores.Length; i++)
{
    Console.WriteLine(valores[i]);
}


