using System;


namespace Exercício_02
{
    internal class Caixa
    {

        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Extrato> listaExtratos = new List<Extrato>();


        public void AdicionarUsuario(Cliente cliente)
        {
            this.listaClientes.Add(cliente);
            Console.WriteLine($"{cliente.Nome}, {cliente.Agencia}, {cliente.Conta}, {cliente.Senha}");
        }

        public void Login()
        {
            bool clienteEncontrado = false;

            do
            {
                try
                {

                    //Verificação de login
                    Console.WriteLine("Faça o seu login:");
                    Console.WriteLine();
                    Console.WriteLine("Insira a agência");
                    int agencia = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Insira o número da conta");
                    int conta = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Insira a senha");
                    int senha = Convert.ToInt32(Console.ReadLine());


                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        Cliente cliente = listaClientes[i];
                        if (cliente.Agencia == agencia && cliente.Conta == conta && cliente.Senha == senha)
                        {
                            Console.Clear();
                            Console.WriteLine("Seja bem vindo(a) " + cliente.Nome);
                            clienteEncontrado = true;
                            Menu(i);
                            continue;
                        }
                    }

                    if (clienteEncontrado == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Login incorreto");
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                    Console.WriteLine();
                }
            }
            while (true);
        }

        private void Menu(int idClienteLogado)
        {
            bool Operar = true;

            do
            {
                try
                {

                    //Seleção de operação
                    Console.WriteLine("Selecione a operação:\n1 - Sacar\n2 - Depositar\n3 - Extrato\n4 - Saldo\n5 - Poupança\n6 - Empréstimo\n7 - Deslogar");
                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:
                            SacarContaCorrente(idClienteLogado);
                            break;

                        case 2:
                            DepositarContaCorrente(idClienteLogado);
                            break;

                        case 3:
                            MostrarExtratos(idClienteLogado);
                            break;

                        case 4:
                            MostrarSaldo(idClienteLogado);
                            break;

                        case 5:
                            OperacoesContaPoupanca(idClienteLogado);
                            break;

                        case 6:
                            EmprestarDinheiro(idClienteLogado);
                            break;

                        case 7:
                            Operar = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Use apenas números de 1 a 7");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números");
                    Console.WriteLine();
                }
            }
            while (Operar);

            Console.Clear();

        }

        private void SacarContaCorrente(int idClienteLogado)
        {
            //Sacar dinheiro conta corrente

            try
            {

                Cliente cliente = listaClientes[idClienteLogado];

                Console.WriteLine($"Saldo disponível para {cliente.Nome} : {cliente.SaldoContaCorrente:C2}");
                Console.WriteLine("Insira a quantidade para sacar:");
                double valorSaque = Convert.ToDouble(Console.ReadLine());

                if (valorSaque > cliente.SaldoContaCorrente)
                {
                    Console.Clear();
                    Console.WriteLine("Saldo insuficiente.");
                    Console.WriteLine();
                }
                else
                {
                    //Atualiza o saldo
                    double total = cliente.SaldoContaCorrente - valorSaque;
                    cliente.SaldoContaCorrente = total;

                    //Cria o extrato
                    Extrato extrato = new Extrato();

                    extrato.Id = idClienteLogado;
                    extrato.Valor = valorSaque;
                    extrato.Tipo = "Saque";
                    extrato.ContaCorrente = true;

                    listaExtratos.Add(extrato);

                    Console.Clear();
                    Console.WriteLine("Valor sacado: R$" + valorSaque + " faça bom proveito.");

                    SacarNotas(valorSaque);
                }

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Insira apenas valores!");
                Console.WriteLine();
            }
        }

        private void SacarContaPoupanca(int idClienteLogado)
        {
            //Sacar dinheiro conta poupança

            try
            {

                Cliente cliente = listaClientes[idClienteLogado];

                Console.WriteLine($"Saldo disponível para {cliente.Nome} : {cliente.SaldoContaPoupanca:C2}");
                Console.WriteLine("Insira a quantidade para sacar:");
                double valorSaque = Convert.ToDouble(Console.ReadLine());

                if (valorSaque > cliente.SaldoContaPoupanca)
                {
                    Console.Clear();
                    Console.WriteLine("Saldo insuficiente.");
                    Console.WriteLine();
                }
                else
                {
                    //Atualiza o saldo
                    double total = cliente.SaldoContaPoupanca - valorSaque;
                    cliente.SaldoContaPoupanca = total;

                    //Cria o extrato
                    Extrato extrato = new Extrato();

                    extrato.Id = idClienteLogado;
                    extrato.Valor = valorSaque;
                    extrato.Tipo = "Saque";
                    extrato.ContaCorrente = false;

                    listaExtratos.Add(extrato);

                    Console.Clear();
                    Console.WriteLine("Valor sacado: R$" + valorSaque + " faça bom proveito.");

                    SacarNotas(valorSaque);

                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Insira apenas valores!");
                Console.WriteLine();
            }
        }

        private void SacarNotas(double valor)
        {

            int[] notas = new int[7];

            notas[0] = valor >= 200 ? (int)valor / 200 : 0;
            valor = valor - 200 * notas[0];

            notas[1] = valor >= 100 ? (int)valor / 100 : 0;
            valor = valor - 100 * notas[1];

            notas[2] = valor >= 50 ? (int)valor / 50 : 0;
            valor = valor - 50 * notas[2];

            notas[3] = valor >= 20 ? (int)valor / 20 : 0;
            valor = valor - 20 * notas[3];

            notas[4] = valor >= 10 ? (int)valor / 10 : 0;
            valor = valor - 10 * notas[4];

            notas[5] = valor >= 5 ? (int)valor / 5 : 0;
            valor = valor - 5 * notas[5];

            notas[6] = valor >= 2 ? (int)valor / 2 : 0;
            valor = valor - 2 * notas[6];

            Console.WriteLine();
            Console.WriteLine("Notas sacadas:");
            Console.WriteLine("Notas de 200: " + notas[0]);
            Console.WriteLine("Notas de 100: " + notas[1]);
            Console.WriteLine("Notas de 50: " + notas[2]);
            Console.WriteLine("Notas de 20: " + notas[3]);
            Console.WriteLine("Notas de 10: " + notas[4]);
            Console.WriteLine("Notas de 5: " + notas[5]);
            Console.WriteLine("Notas de 2: " + notas[6]);
            Console.WriteLine();
        }

        private void DepositarContaCorrente(int idClienteLogado)
        {
            //Depositar dinheiro conta corrente
            try
            {

                Cliente cliente = listaClientes[idClienteLogado];

                Console.WriteLine($"Saldo disponível para {cliente.Nome} : {cliente.SaldoContaCorrente:C2}");
                Console.WriteLine("Insira a quantidade para depositar:");
                double deposito = Convert.ToDouble(Console.ReadLine());

                //Atualiza o saldo
                double totalDeposito = cliente.SaldoContaCorrente + deposito;
                cliente.SaldoContaCorrente = totalDeposito;

                //Cria o extrato
                Extrato extrato = new Extrato();

                extrato.Id = idClienteLogado;
                extrato.Valor = deposito;
                extrato.Tipo = "Depósito";
                extrato.ContaCorrente = true;

                listaExtratos.Add(extrato);

                Console.Clear();
                Console.WriteLine("Saldo atual: R$" + totalDeposito);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Insira apenas valores!");
                Console.WriteLine();
            }
        }

        private void DepositarContaPoupanca(int idClienteLogado)
        {
            //Depositar dinheiro conta poupança

            try
            {
                Cliente cliente = listaClientes[idClienteLogado];

                Console.WriteLine($"Saldo disponível para {cliente.Nome} : {cliente.SaldoContaPoupanca:C2}");
                Console.WriteLine("Insira a quantidade para depositar:");
                double deposito = Convert.ToDouble(Console.ReadLine());

                //Atualiza o saldo
                double totalDeposito = cliente.SaldoContaPoupanca + deposito;
                cliente.SaldoContaPoupanca = totalDeposito;

                //Cria o extrato
                Extrato extrato = new Extrato();

                extrato.Id = idClienteLogado;
                extrato.Valor = deposito;
                extrato.Tipo = "Depósito";
                extrato.ContaCorrente = false;

                listaExtratos.Add(extrato);

                Console.Clear();
                Console.WriteLine("Saldo atual: R$" + totalDeposito);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Insira apenas valores!");
                Console.WriteLine();
            }
        }

        private void MostrarExtratos(int idClienteLogado)
        {
            //Mostrar extratos conta corrente
            Console.Clear();
            Console.WriteLine("Conta corrente:");
            for (int i = 0; i < listaExtratos.Count; i++)
            {
                Extrato extrato = listaExtratos[i];
                if (extrato.Id == idClienteLogado && extrato.ContaCorrente == true)
                {
                    Console.WriteLine("Tipo: " + extrato.Tipo + " Valor: " + extrato.Valor);
                }
            }
            //Mostrar extratos conta poupança
            Console.WriteLine("Conta poupança:");
            for (int i = 0; i < listaExtratos.Count; i++)
            {
                Extrato extrato = listaExtratos[i];
                if (extrato.Id == idClienteLogado && extrato.ContaCorrente == false)
                {
                    Console.WriteLine("Tipo: " + extrato.Tipo + " Valor: " + extrato.Valor);
                }
            }
            Console.WriteLine();
        }

        private void MostrarSaldo(int idClienteLogado)
        {
            //Mostrar saldo

            Cliente cliente = listaClientes[idClienteLogado];

            Console.Clear();
            Console.WriteLine("O seu saldo (conta corrente) é: R$" + cliente.SaldoContaCorrente);
            Console.WriteLine("O seu saldo (poupança) é: R$" + cliente.SaldoContaPoupanca);
            Console.WriteLine();
        }

        private void OperacoesContaPoupanca(int idClienteLogado)
        {
            //Operações conta corrente
            Console.Clear();
            Console.WriteLine("Poupança: \n1 - Sacar\n2 - Depositar");
            int selecionado = Convert.ToInt32(Console.ReadLine());

            switch (selecionado)
            {
                case 1:
                    SacarContaPoupanca(idClienteLogado);
                    break;
                case 2:
                    DepositarContaPoupanca(idClienteLogado);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Operação inválida");
                    Console.WriteLine();
                    break;
            }
        }

        private void EmprestarDinheiro(int idClienteLogado)
        {
            //Empréstimo

            try
            {

                Cliente cliente = listaClientes[idClienteLogado];

                double maxEmprestimo = cliente.SaldoContaCorrente * 10;

                Console.WriteLine("O valor máximo para seu empréstimo é : R$" + maxEmprestimo);
                Console.WriteLine("Insira o valor do empréstimo:");
                double emprestimo = Convert.ToDouble(Console.ReadLine());

                if (emprestimo > maxEmprestimo)
                {
                    Console.WriteLine("Você não pode pegar um empréstimo tão alto!");
                }
                else
                {
                    //Atualiza o saldo
                    emprestimo = emprestimo + cliente.SaldoContaCorrente;
                    cliente.SaldoContaCorrente = emprestimo;
                    Console.Clear();
                    Console.WriteLine("Saldo atual: R$" + emprestimo);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Insira apenas valores!");
                Console.WriteLine();
            }
        }

    }
}
