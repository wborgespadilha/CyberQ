string[,] clientes =
{
    {"Daniel","060","777777","12345","150","80"},
    {"Ana","070","888933","54321","750","120"},
    {"Leonardo","060","456321","336655","1250","7000"}
};

// Nome, Agência, Conta corrente, Senha, Saldo, Saldo conta poupança

string[,] extratosCorrente = new string[50, 3];
string[,] extratosPoupança = new string[50, 3];

// ID usuário ,Tipo(depósito, saque), Valor


int idLogado = -1;

bool logar = true;
bool operar = false;

int nota200 = 0;
int nota100 = 0;
int nota50 = 0;
int nota20 = 0;
int nota10 = 0;
int nota5 = 0;
int nota2 = 0;



while (true)
{

    do
    {
        //Verificação de login
        Console.WriteLine("Faça o seu login:");
        Console.WriteLine("Insira a agência");
        string agencia = Console.ReadLine();

        Console.WriteLine("Insira o número da conta");
        string conta = Console.ReadLine();

        Console.WriteLine("Insira a senha");
        string senha = Console.ReadLine();

            
        for (int i = 0; i < clientes.GetLength(0); i++)
        {
            if (clientes[i, 1] == agencia && clientes[i, 2] == conta && clientes[i, 3] == senha)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo(a) " + clientes[i, 0]);
                idLogado = i;
                logar = false;
                operar = true;
                continue;
            }
        }
        if (operar == false)
        {
            Console.Clear();
            Console.WriteLine("Login incorreto");
            Console.WriteLine();
        }
    }
    while (logar);

    do
    {
        try
        {

            //Seleção de operação
            Console.WriteLine("Selecione a operação:\n1 - Sacar\n2 - Depositar\n3 - Extrato\n4 - Saldo\n5 - Poupança\n6 - Empréstimo\n7 - Deslogar");
            int selecao = Convert.ToInt32(Console.ReadLine());

            if (selecao < 1 || selecao > 7)
            {
                Console.WriteLine("Use apenas números de 1 a 7");
            }

            switch (selecao)
            {
                case 1:
                    //Sacar dinheiro conta corrente
                    Console.WriteLine("Saldo disponível para " + clientes[idLogado, 0] + " : R$" + clientes[idLogado, 4]);
                    Console.WriteLine("Insira a quantidade para sacar:");
                    double saque = Convert.ToDouble(Console.ReadLine());

                    if (saque > Convert.ToInt32(clientes[idLogado, 4]))
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                    else
                    {
                        double total = Convert.ToDouble(clientes[idLogado, 4]) - saque;
                        clientes[idLogado, 4] = total.ToString();

                        for (int i = 0; i < extratosCorrente.GetLength(0); i++)
                        {
                            if (extratosCorrente[i, 0] == null)
                            {
                                extratosCorrente[i, 0] = idLogado.ToString();
                                extratosCorrente[i, 1] = "Saque";
                                extratosCorrente[i, 2] = "R$" + saque.ToString();
                                break;
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("Valor sacado: R$" + saque + " faça bom proveito.");

                        nota200 = saque >= 200 ? (int)saque / 200 : 0;
                        saque = saque - 200 * nota200;
                        nota100 = saque >= 100 ? (int)saque / 100 : 0;
                        saque = saque - 100 * nota100;
                        nota50 = saque >= 50 ? (int)saque / 50 : 0;
                        saque = saque - 50 * nota50;
                        nota20 = saque >= 20 ? (int)saque / 20 : 0;
                        saque = saque - 20 * nota20;
                        nota10 = saque >= 10 ? (int)saque / 10 : 0;
                        saque = saque - 10 * nota10;
                        nota5 = saque >= 5 ? (int)saque / 5 : 0;
                        saque = saque - 5 * nota5;
                        nota2 = saque >= 2 ? (int)saque / 2 : 0;
                        saque = saque - 2 * nota2;
                        Console.WriteLine();

                        Console.WriteLine("Notas sacadas:");
                        Console.WriteLine("Notas de 200: " + nota200);
                        Console.WriteLine("Notas de 100: " + nota100);
                        Console.WriteLine("Notas de 50: " + nota50);
                        Console.WriteLine("Notas de 20: " + nota20);
                        Console.WriteLine("Notas de 10: " + nota10);
                        Console.WriteLine("Notas de 5: " + nota5);
                        Console.WriteLine("Notas de 2: " + nota2);

                    }
                    break;
                case 2:
                    //Depositar dinheiro conta corrente
                    Console.WriteLine("Saldo disponível para " + clientes[idLogado, 0] + " : R$" + clientes[idLogado, 4]);
                    Console.WriteLine("Insira a quantidade para depositar:");
                    double deposito = Convert.ToDouble(Console.ReadLine());

                    double totalDeposito = Convert.ToDouble(clientes[idLogado, 4]) + deposito;
                    clientes[idLogado, 4] = totalDeposito.ToString();

                    for (int i = 0; i < extratosCorrente.GetLength(0); i++)
                    {
                        if (extratosCorrente[i, 0] == null)
                        {
                            extratosCorrente[i, 0] = idLogado.ToString();
                            extratosCorrente[i, 1] = "Depósito";
                            extratosCorrente[i, 2] = "R$" + deposito.ToString();
                            break;
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("Saldo atual: R$" + totalDeposito);

                    break;
                case 3:
                    //Mostrar extratos conta corrente e conta poupança
                    Console.Clear();
                    Console.WriteLine("Conta corrente:");
                    for (int i = 0; i < extratosCorrente.GetLength(0); i++)
                    {
                        if (extratosCorrente[i, 0] == idLogado.ToString())
                        {
                            Console.WriteLine("Tipo: " + extratosCorrente[i, 1] + " Valor: " + extratosCorrente[i, 2]);
                        }
                    }
                    Console.WriteLine("Conta poupança:");
                    for (int i = 0; i < extratosPoupança.GetLength(0); i++)
                    {
                        if (extratosPoupança[i, 0] == idLogado.ToString())
                        {
                            Console.WriteLine("Tipo: " + extratosPoupança[i, 1] + " Valor: " + extratosPoupança[i, 2]);
                        }
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    //Mostrar saldo
                    Console.Clear();
                    Console.WriteLine("O seu saldo (conta corrente) é: R$" + clientes[idLogado, 4]);
                    Console.WriteLine("O seu saldo (poupança) é: R$" + clientes[idLogado, 5]);
                    break;
                case 5:
                    //Operações conta corrente
                    Console.Clear();
                    Console.WriteLine("Poupança: \n1 - Sacar\n2 - Depositar");
                    int selecionado = Convert.ToInt32(Console.ReadLine());

                    switch (selecionado)
                    {
                        case 1:
                            //Saque poupança
                            Console.WriteLine("Saldo disponível para " + clientes[idLogado, 0] + " : R$" + clientes[idLogado, 5]);
                            Console.WriteLine("Insira a quantidade para sacar:");
                            double saquePoupanca = Convert.ToDouble(Console.ReadLine());

                            if (saquePoupanca > Convert.ToDouble(clientes[idLogado, 5]))
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                            else
                            {
                                double total = Convert.ToDouble(clientes[idLogado, 5]) - saquePoupanca;
                                clientes[idLogado, 5] = total.ToString();

                                for (int i = 0; i < extratosPoupança.GetLength(0); i++)
                                {
                                    if (extratosPoupança[i, 0] == null)
                                    {
                                        extratosPoupança[i, 0] = idLogado.ToString();
                                        extratosPoupança[i, 1] = "Saque";
                                        extratosPoupança[i, 2] = "R$" + saquePoupanca.ToString();
                                        break;
                                    }
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("Valor sacado: (poupança) R$" + saquePoupanca + " faça bom proveito.");

                            nota200 = saquePoupanca >= 200 ? (int)saquePoupanca / 200 : 0;
                            saquePoupanca = saquePoupanca - 200 * nota200;
                            nota100 = saquePoupanca >= 100 ? (int)saquePoupanca / 100 : 0;
                            saquePoupanca = saquePoupanca - 100 * nota100;
                            nota50 = saquePoupanca >= 50 ? (int)saquePoupanca / 50 : 0;
                            saquePoupanca = saquePoupanca - 50 * nota50;
                            nota20 = saquePoupanca >= 20 ? (int)saquePoupanca / 20 : 0;
                            saquePoupanca = saquePoupanca - 20 * nota20;
                            nota10 = saquePoupanca >= 10 ? (int)saquePoupanca / 10 : 0;
                            saquePoupanca = saquePoupanca - 10 * nota10;
                            nota5 = saquePoupanca >= 5 ? (int)saquePoupanca / 5 : 0;
                            saquePoupanca = saquePoupanca - 5 * nota5;
                            nota2 = saquePoupanca >= 2 ? (int)saquePoupanca / 2 : 0;
                            saquePoupanca = saquePoupanca - 2 * nota2;
                            Console.WriteLine();

                            Console.WriteLine("Notas sacadas:");
                            Console.WriteLine("Notas de 200: " + nota200);
                            Console.WriteLine("Notas de 100: " + nota100);
                            Console.WriteLine("Notas de 50: " + nota50);
                            Console.WriteLine("Notas de 20: " + nota20);
                            Console.WriteLine("Notas de 10: " + nota10);
                            Console.WriteLine("Notas de 5: " + nota5);
                            Console.WriteLine("Notas de 2: " + nota2);
                            break;
                        case 2:
                            //Depósito poupança
                            Console.WriteLine("Saldo disponível para " + clientes[idLogado, 0] + " : R$" + clientes[idLogado, 5]);
                            Console.WriteLine("Insira a quantidade para depositar:");
                            double depositoPoupança = Convert.ToDouble(Console.ReadLine());

                            double totalDepositoPoupanca = Convert.ToDouble(clientes[idLogado, 5]) + depositoPoupança;
                            clientes[idLogado, 5] = totalDepositoPoupanca.ToString();

                            for (int i = 0; i < extratosPoupança.GetLength(0); i++)
                            {
                                if (extratosPoupança[i, 0] == null)
                                {
                                    extratosPoupança[i, 0] = idLogado.ToString();
                                    extratosPoupança[i, 1] = "Depósito";
                                    extratosPoupança[i, 2] = "R$" + depositoPoupança.ToString();
                                    break;
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("Saldo atual (poupança): R$" + totalDepositoPoupanca);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Operação inválida");
                            Console.WriteLine();
                            break;
                    }

                    break;
                case 6:
                    //Empréstimo
                    double maxEmprestimo = Convert.ToDouble(clientes[idLogado, 4]) * 10;

                    Console.WriteLine("O valor máximo para seu empréstimo é : R$" + maxEmprestimo);
                    Console.WriteLine("Insira o valor do empréstimo:");
                    double emprestimo = Convert.ToDouble(Console.ReadLine());

                    if (emprestimo > maxEmprestimo)
                    {
                        Console.WriteLine("Você não pode pegar um empréstimo tão alto!");
                    }
                    else
                    {
                        emprestimo = emprestimo + Convert.ToDouble(clientes[idLogado, 4]);
                        clientes[idLogado, 4] = emprestimo.ToString();
                        Console.Clear();
                        Console.WriteLine("Saldo atual: R$" + emprestimo);
                    }

                    break;
                case 7:
                    //Deslogar
                    idLogado = -1;
                    operar = false;
                    Console.Clear();
                    break;
            }
        }
        catch(Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Insira apenas números");
            Console.WriteLine();
        }
    }
    while (operar);
}