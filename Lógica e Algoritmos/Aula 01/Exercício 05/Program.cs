Console.WriteLine("Insira o ano");
int anoInserido = Convert.ToInt32(Console.ReadLine());

if(anoInserido % 4 == 0)
{
    Console.WriteLine("O ano é bissexto");
}
else
{
    Console.WriteLine("O ano não é bissexto");
}
