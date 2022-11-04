Console.WriteLine("Insira o nome do produto");
string nomeProduto = Console.ReadLine();

Console.WriteLine("Insira o valor do produto");
double precoProduto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O produto " + nomeProduto + " irá custar " + precoProduto * 0.9);
