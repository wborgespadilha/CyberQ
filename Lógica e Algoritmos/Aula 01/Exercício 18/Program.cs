Console.WriteLine("Informe o dia do mês");
int diaInserido = Convert.ToInt16(Console.ReadLine());


if (diaInserido % 7 == 1)
{
    Console.WriteLine("Domingo");
}
if (diaInserido % 7 == 2)
{
    Console.WriteLine("Segunda");
}
if (diaInserido % 7 == 3)
{
    Console.WriteLine("Terça");
}
if (diaInserido % 7 == 4)
{
    Console.WriteLine("Quarta");
}
if (diaInserido % 7 == 5)
{
    Console.WriteLine("Quinta");
}
if (diaInserido % 7 == 6)
{
    Console.WriteLine("Sexta");
}
if (diaInserido % 7 == 0)
{
    Console.WriteLine("Sábado");
}

