bool continueRegister = true;

int productsRegistered = 0;
int productsRegistredFirstSegment = 0;
int productsRegistredSecondSegment = 0;
int productsRegisteredThirdSegment = 0;
int productsRegisteredFourthSegment = 0;
int productsRegisteredFifthSegment = 0;

double firstSegmentValue = 0;
double secondSegmentValue = 0;
double thirdSegmentValue = 0;
double fourthSegmentValue = 0;
double fifthSegmentValue = 0;

string mostExpensiveProductName = "";
double mostExpensiveProductValue = 0;
int mostExpensiveProductSegment = 0;

do
{
    Console.WriteLine("Selecione o segmento:");
    Console.WriteLine("1 - Alimentício");
    Console.WriteLine("2 - Audio e vídeo");
    Console.WriteLine("3 - Computadores e notebooks");
    Console.WriteLine("4 - Smartphones");
    Console.WriteLine("5 - Vestuário");

    try
    {
        int segment = Convert.ToInt32(Console.ReadLine());

        if (segment < 1 || segment > 5)
        {
            Console.WriteLine();
            Console.WriteLine("Segmento inválido");
            Console.WriteLine();
            continue;
        }

        Console.WriteLine("Insira o nome do produto");
        string productName = Console.ReadLine();

        if (productName == "")
        {
            Console.WriteLine();
            Console.WriteLine("O nome do produto não pode ser vazio!");
            Console.WriteLine();
            continue;
        }

        Console.WriteLine("Insira o valor do produto");
        double productPrice = Convert.ToDouble(Console.ReadLine());

        switch(segment)
        {
            case 1:
                productsRegistredFirstSegment++;
                productsRegistered++;
                firstSegmentValue += productPrice;
            break;
            
            case 2:
                productsRegistredSecondSegment++;
                productsRegistered++;
                secondSegmentValue += productPrice;
            break;

            case 3:
                productsRegisteredThirdSegment++;
                productsRegistered++;
                thirdSegmentValue += productPrice;
            break;

            case 4:
                productsRegisteredFourthSegment++;
                productsRegistered++;
                fourthSegmentValue += productPrice;
            break;

            case 5:
                productsRegisteredFifthSegment++;
                productsRegistered++;
                fifthSegmentValue += productPrice;
            break;
        }

        if(productPrice > mostExpensiveProductValue)
        {
            mostExpensiveProductValue = productPrice;
            mostExpensiveProductName = productName;
            mostExpensiveProductSegment = segment;
        }

        Console.WriteLine("Para continuar inserindo aperte enter, para parar digite qualquer coisa");
        string continueCheck = Console.ReadLine();
        if (continueCheck != "")
        {
            continueRegister = false;
        }

        Console.Clear();

    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine();
    }

}
while (continueRegister);

double firstSegmentAveragePrice = productsRegistredFirstSegment > 0 ? firstSegmentValue / productsRegistredFirstSegment : 0;
double secondSegmentAveragePrice = productsRegistredSecondSegment > 0 ? secondSegmentValue / productsRegistredSecondSegment : 0;
double thirdSegmentAveragePrice = productsRegisteredThirdSegment > 0 ? thirdSegmentValue / productsRegisteredThirdSegment : 0;
double fourthSegmentAveragePrice = productsRegisteredFourthSegment > 0 ? fourthSegmentValue / productsRegisteredFourthSegment : 0;
double fifthSegmentAveragePrice = productsRegisteredFifthSegment > 0 ? fifthSegmentValue / productsRegisteredFifthSegment : 0;

Console.Clear();
Console.WriteLine($"Total de produtos Cadastrados {productsRegistered}");
Console.WriteLine("Produtos por segmento:");
Console.WriteLine($"Segmento 1 - Alimentício: {productsRegistredFirstSegment}, Média de valor: {firstSegmentAveragePrice:C2}");
Console.WriteLine($"Segmento 2 - Áudio e Vídeo: {productsRegistredSecondSegment}, Média de valor: {secondSegmentAveragePrice:C2}");
Console.WriteLine($"Segmento 3 - Computadores e Notebooks: {productsRegisteredThirdSegment}, Média de valor: {thirdSegmentAveragePrice:C2}");
Console.WriteLine($"Segmento 4 - Smartphones: {productsRegisteredFourthSegment}, Média de valor: {fourthSegmentAveragePrice:C2}");
Console.WriteLine($"Segmento 5 - Vestuário: {productsRegisteredFifthSegment}, Média de valor: {fifthSegmentAveragePrice:C2}");
Console.WriteLine($"Produto mais caro: {mostExpensiveProductName}, Segmento: {mostExpensiveProductSegment}, valor: {mostExpensiveProductValue}");