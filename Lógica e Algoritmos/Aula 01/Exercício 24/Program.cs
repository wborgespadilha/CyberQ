Console.WriteLine("Digite o salário");
double salario = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a conta de luz");
double contaLuz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a conta de internet");
double contaInternet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a conta de água");
double contaAgua = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a conta de mercado");
double contaMercado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a conta do aluguel");
double contaAluguel = Convert.ToInt32(Console.ReadLine());

double sobraSalario = salario - contaLuz - contaInternet - contaAgua - contaMercado - contaAluguel;

if(sobraSalario > 0)
{
    Console.WriteLine("Sobraram " + sobraSalario + " reais do salário.");
}
if (sobraSalario == 0)
{
    Console.WriteLine("Não sobrou nada do salário!");
}
if (sobraSalario < 0)
{
    Console.WriteLine("Você ficou devendo " + sobraSalario + " reais.");
}