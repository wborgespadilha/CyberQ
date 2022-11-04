Console.WriteLine("Insira o nome do produto");
string nomeProduto = Console.ReadLine();

Console.WriteLine("Insira a forma de pagamento");
Console.WriteLine("1 - a vista");
Console.WriteLine("2 - a prazo");
int formaPagamento = Convert.ToInt16(Console.ReadLine());

if(formaPagamento > 2 || formaPagamento < 1)
{
    Console.WriteLine("Forma de pagamento inválida");
    return;
}

Console.WriteLine("Insira o valor do produto");
double valorProduto = Convert.ToDouble(Console.ReadLine());

if(formaPagamento == 1 && valorProduto > 500)
{
    Console.WriteLine("Produto comprado: " + nomeProduto + " valor da compra: " + valorProduto * 0.9);
}
else
{
    Console.WriteLine("Produto comprado: " + nomeProduto + " valor da compra: " + valorProduto);
}