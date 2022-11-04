Console.WriteLine("Selecione a tabuada (1 - 10)");
int numeroInserido = Convert.ToInt32(Console.ReadLine());

if (numeroInserido >= 1 || numeroInserido <= 10)
{
    Console.WriteLine("Tabuada do " + numeroInserido);
    Console.WriteLine(numeroInserido + " x 1 = " + numeroInserido);
    Console.WriteLine(numeroInserido + " x 2 = " + numeroInserido * 2);
    Console.WriteLine(numeroInserido + " x 3 = " + numeroInserido * 3);
    Console.WriteLine(numeroInserido + " x 4 = " + numeroInserido * 4);
    Console.WriteLine(numeroInserido + " x 5 = " + numeroInserido * 5);
    Console.WriteLine(numeroInserido + " x 6 = " + numeroInserido * 6);
    Console.WriteLine(numeroInserido + " x 7 = " + numeroInserido * 7);
    Console.WriteLine(numeroInserido + " x 8 = " + numeroInserido * 8);
    Console.WriteLine(numeroInserido + " x 9 = " + numeroInserido * 9);
    Console.WriteLine(numeroInserido + " x 10 = " + numeroInserido * 10);
}
else
{
    Console.WriteLine("Valor inválido.");
}
