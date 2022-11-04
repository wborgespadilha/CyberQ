using Exercício_02;

Caixa caixa = new Caixa();
Cliente cliente = new Cliente();
Cliente cliente2 = new Cliente();
Cliente cliente3 = new Cliente();

cliente.Nome = "Daniel";
cliente.Agencia = 060;
cliente.Conta = 777777;
cliente.Senha = 12345;
cliente.SaldoContaCorrente = 1500;
cliente.SaldoContaPoupanca = 800;

caixa.AdicionarUsuario(cliente);

cliente2.Nome = "Ana";
cliente2.Agencia = 070;
cliente2.Conta = 888933;
cliente2.Senha = 54321;
cliente2.SaldoContaCorrente = 750;
cliente2.SaldoContaPoupanca = 120;

caixa.AdicionarUsuario(cliente2);

cliente3.Nome = "Leonardo";
cliente3.Agencia = 060;
cliente3.Conta = 456321;
cliente3.Senha = 336655;
cliente3.SaldoContaCorrente = 1250;
cliente3.SaldoContaPoupanca = 7000;

caixa.AdicionarUsuario(cliente3);

caixa.Login();
