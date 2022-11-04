Console.WriteLine("Informe as horas atuais");
int horaInserida =  Convert.ToInt32(Console.ReadLine());
// brasil = gmt -3

Console.WriteLine("Informe a cidade desejada:");
Console.WriteLine("1 - Toronto"); //gmt-4
Console.WriteLine("2 - Paris"); //gmt 2
Console.WriteLine("3 - Sydney"); //gmt 10
Console.WriteLine("4 - Moscou"); //gmt 3
Console.WriteLine("5 - Xangai"); //gmt 8

int fusoHorarioSelecionado = Convert.ToInt32(Console.ReadLine());

if(fusoHorarioSelecionado == 1)
{
    Console.WriteLine("Horas: " + (horaInserida - 1) % 24);
}
else if(fusoHorarioSelecionado == 2)
{
    Console.WriteLine("Horas: " + (horaInserida + 5) % 24);
}
else if (fusoHorarioSelecionado == 3)
{
    Console.WriteLine("Horas: " + (horaInserida + 13) % 24);
}
else if (fusoHorarioSelecionado == 4)
{
    Console.WriteLine("Horas: " + (horaInserida + 6) % 24);
}
else if (fusoHorarioSelecionado == 5)
{
    Console.WriteLine("Horas: " + (horaInserida + 11) % 24);
}