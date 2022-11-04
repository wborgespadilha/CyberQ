Console.WriteLine("Insira o valor");
double valorInserido = Convert.ToDouble(Console.ReadLine());

if(valorInserido <= 1903.98)
{
    Console.WriteLine("Isento de imposto de renda");
}
else if(valorInserido <= 2826.65)
{
    Console.WriteLine("Deverá pagar: " + valorInserido * 0.075);
}
else if (valorInserido <= 3751.05)
{
    Console.WriteLine("Deverá pagar: " + valorInserido * 0.15);
}
else if (valorInserido <= 4664.68)
{
    Console.WriteLine("Deverá pagar: " + valorInserido * 0.225);
}
else
{
    Console.WriteLine("Deverá pagar: " + valorInserido * 0.275);
}
