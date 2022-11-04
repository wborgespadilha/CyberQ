Console.WriteLine("Digite a quantidade de moedas de 1 centavo");
int umCentavo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 5 centavos");
int cincoCentavos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 10 centavos");
int dezCentavos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 25 centavos");
int vinteCincoCentavos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 50 centavos");
int cinquentaCentavos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 1 real");
int cemCentavos = Convert.ToInt32(Console.ReadLine());

double valorTotal = umCentavo * 0.01 + cincoCentavos * 0.05 + dezCentavos * 0.10 + vinteCincoCentavos * 0.25 + cinquentaCentavos * 0.5 + cemCentavos;

Console.WriteLine("Valor total: " + valorTotal);