Console.WriteLine("Digite a quantidade de notas de 2 reais");
int doisReais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de notas de 5 reais");
int cincoReais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de notas de 10 reais");
int dezReais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de notas de 20 reais");
int vinteReais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de notas de 50 reais");
int cinquentaReais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de notas de 100 reais");
int cemReais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de notas de 200 reais");
int duzentosReais = Convert.ToInt32(Console.ReadLine());

double valorTotal = doisReais * 2 + cincoReais * 5 + vinteReais * 20 + cinquentaReais * 50 + cemReais * 100 + duzentosReais * 200;

Console.WriteLine("Valor total: " + valorTotal);