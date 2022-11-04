Console.WriteLine("Insira o nome do aluno");
string nomeAluno = Console.ReadLine();

Console.WriteLine("Insira a primeira nota");
double primeiraNota = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a segunda nota");
double segundaNota = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a terceira nota");
double terceiraNota = Convert.ToDouble(Console.ReadLine());

double media = (primeiraNota + segundaNota + terceiraNota) / 3;

Console.WriteLine("Média: " + media);

if(media >= 7)
{
    Console.WriteLine(nomeAluno + " Aprovado(a)");
}
else if(media >= 5)
{
    Console.WriteLine(nomeAluno + " Em exame");
}
else
{
    Console.WriteLine(nomeAluno + " Reprovado(a)");
}
