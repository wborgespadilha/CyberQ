int[] numeros = new int[10];
int[] ints = new int[10];
double[] resultados = new double[10];

try
{

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine("Insira o " + (i + 1) + "º numero do primeiro vetor");
        numeros[i] = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
    }

    for (int i = 0; i < ints.Length; i++)
    {
        Console.WriteLine("Insira o " + (i + 1) + "º numero do segundo vetor");
        ints[i] = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
    }


    Console.WriteLine("Selecione a operação");
    Console.WriteLine("1) Soma \n2) Subtração \n3) Multiplicação \n4) Divisão");

    int selecao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    switch (selecao)
    {
        case 1:
            for (int i = 0; i < 10; i++)
            {
                resultados[i] = numeros[i] + ints[i];
            }
            break;
        case 2:
            for (int i = 0; i < 10; i++)
            {
                resultados[i] = numeros[i] - ints[i];
            }
            break;
        case 3:
            for (int i = 0; i < 10; i++)
            {
                resultados[i] = numeros[i] * ints[i];
            }
            break;
        case 4:
            for (int i = 0; i < 10; i++)
            {
                resultados[i] = numeros[i] / ints[i];
            }
            break;
    }

}
catch(Exception ex)
{
    Console.WriteLine("Insira apenas números inteiros");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Resultado: " + resultados[i]);
}
