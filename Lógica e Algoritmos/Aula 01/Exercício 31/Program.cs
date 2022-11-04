Console.WriteLine("Insira o valor da aplicação");
double valorAplicacao = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o tempo do investimento, em meses");
int mesesInvestimento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a taxa mensal, em %");
double taxaMensal = Convert.ToInt32(Console.ReadLine());

taxaMensal = taxaMensal / 100;

double montante = valorAplicacao + (valorAplicacao * mesesInvestimento * taxaMensal);

Console.WriteLine("O montante final é de: " + montante);