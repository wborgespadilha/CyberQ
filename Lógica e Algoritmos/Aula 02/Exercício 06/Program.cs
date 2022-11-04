double sum = 0;
bool continueShopping = true;

do
{
    Console.WriteLine("Selecione o produto");
    Console.WriteLine("1 - Arroz 5kg, R$ 18,70");
    Console.WriteLine("2 - Feijão 1kg, R$ 5,85");
    Console.WriteLine("3 - Trigo 2 kg, R$ 4,55");
    Console.WriteLine("4 - Açúcar 1 kg, R$ 6,98");
    Console.WriteLine("5 - Macarrão 1 kg, R$ 2.89");
    Console.WriteLine("6 - Lata de milho, R$1,78");
    Console.WriteLine("7 - Lata de ervilha, R$1,67");
    Console.WriteLine("0 - Finalizar compra");
    try
    {
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 0:
                continueShopping = false;
                break;

            case 1:
                sum = sum + 18.7;
                break;

            case 2:
                sum = sum + 5.85;
                break;

            case 3:
                sum = sum + 4.55;
                break;

            case 4:
                sum = sum + 6.98;
                break;

            case 5:
                sum = sum + 2.89;
                break;

            case 6:
                sum = sum + 1.78;
                break;

            case 7:
                sum = sum + 1.67;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;

        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("");
}
while (continueShopping);

Console.WriteLine("Total da compra: " + sum.ToString("C2"));

