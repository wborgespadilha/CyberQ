

for(int i = 10; i <= 120;i++)
{

    int salario = i * 100;

    double desINSS = CalcularDescontoINSS(salario);
    double desIRRF = CalcularDescontoIRRF(salario);

    double salarioComDesconto = salario - desINSS - desIRRF;

    double porcentagem = (salario - salarioComDesconto) / salario;

    Console.WriteLine($"Salário: {salario}, porcentagem: {porcentagem:P2} = {(salario - salarioComDesconto):C2}, liquido = {salarioComDesconto:C2}");

}


double CalcularDescontoINSS(double Salario)
{
    double INSS = 0;
    double Desconto = 0;

    if (Salario <= 1751.81)
    {
        Desconto = Salario * 0.08;
    }
    else if (Salario <= 2919.72)
    {
        Desconto = Salario * 0.09;
    }
    else if (Salario <= 5839.45)
    {
        Desconto = Salario * 0.11;
    }
    else
    {
        Desconto = 642.34;
    }

    INSS = Desconto;
    return Desconto;

}

double CalcularDescontoIRRF(double Salario)
{
    double IRRF = 0;
    double Desconto = 0;

    if (Salario <= 1903.98)
    {
        Desconto = 0;
    }
    else if (Salario <= 2826.65)
    {
        Desconto = Salario * 0.075;
    }
    else if (Salario <= 3751.05)
    {
        Desconto = Salario * 0.12;
    }
    else if (Salario <= 4664.68)
    {
        Desconto = Salario * 0.225;
    }
    else
    {
        Desconto = Salario * 0.275;
    }

    IRRF = Desconto;
    return Desconto;
}