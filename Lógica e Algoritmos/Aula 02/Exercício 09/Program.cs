try
{
    Console.WriteLine("Insira o valor da aplicação:");
    double applicationValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira a taxa da aplicação (em %):");
    double applicationTax = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o tempo da aplicação (em meses)");
    int applicationTime = Convert.ToInt32(Console.ReadLine());

    applicationTax = applicationTax / 100;

    double applicationEarning = 0;

    for (int i = 1; i <= applicationTime; i++)
    {
        applicationEarning = applicationValue * applicationTax;
        applicationValue = applicationValue + applicationEarning;
        Console.WriteLine("Mês: " + i + " Ganhos: " + applicationEarning.ToString("C2") + " Total: " + applicationValue.ToString("C2"));
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}