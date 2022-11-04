//Models
using Projeto.Models;
using Projeto.Interfaces;
using Projeto.Funcionarios;
//Util
using Projeto.Util;
using System;

namespace Projeto.Controller
{
    internal class GerenciadorController : ICrud
    {

        List<Funcionario> listaFuncionarios = new List<Funcionario>();

        public void Cadastrar(string NomeEmpresa)
        {
            try
            {
                Funcionario funcionario = new Funcionario("", 0, 0, 0);

                Console.Clear();
                Console.WriteLine("Selecione o cargo:");
                Console.WriteLine("1) Desenvolvedor");
                Console.WriteLine("2) Q.A");
                Console.WriteLine("3) Analista de sistemas");
                Console.WriteLine("4) Analista de infra");
                Console.WriteLine("5) DevOps");
                Console.WriteLine("6) Segurança");
                Console.WriteLine("7) Recepcionista");
                Console.WriteLine("8) Analista de DHO");
                int cargo = Convert.ToInt32(Console.ReadLine());

                if (cargo < 1 || cargo > 8)
                {
                    Console.Clear();
                    Console.WriteLine("Cargo inválido!");
                    Console.WriteLine();

                }
                else
                {

                    GerenciadorUtil util = new GerenciadorUtil();
                    util.RequisitarInformacoes();

                    switch (cargo)
                    {
                        case 1:
                            funcionario = new Desenvolvedor(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 2:
                            funcionario = new QA(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 3:
                            funcionario = new AnalistaSistemas(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 4:
                            funcionario = new AnalistaInfra(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 5:
                            funcionario = new DevOps(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 6:
                            funcionario = new Segurança(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 7:
                            funcionario = new Recepcionista(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                        case 8:
                            funcionario = new AnalistaDHO(util.Nome, util.ValorHora, util.HorasExtras50, util.HorasExtras100);
                            break;

                    }

                    funcionario.UsaVT = util.UsaVT;
                    funcionario.UsaVA = util.UsaVA;
                    funcionario.AdicionalNoturno = util.AdicionalNoturno;
                    funcionario.ContribuiSindicato = util.ContribuiSindicato;
                    listaFuncionarios.Add(funcionario);

                    Console.Clear();
                    Console.WriteLine($"Funcionário {util.Nome} adicionado com sucesso!");

                    GravarDB(NomeEmpresa);

                }

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Tipo inválido inserido!");
                Console.WriteLine();
            }
        }

        public void Listar()
        {

            Console.Clear();
            Console.WriteLine("Pagamentos previstos para este mês:");
            Console.WriteLine();

            double totalBruto = 0;

            foreach (Funcionario obj in listaFuncionarios)
            {
                obj.CalcularSalarioLiquido();

                Console.WriteLine($"{obj.GetType().Name}: {obj.Nome}, Bruto: {obj.SalarioBruto:C2}, Líquido: " +
                    $"{obj.SalarioLiquido:C2}, Total de horas extras: {obj.HorasExtras50 + obj.HorasExtras100}");

                totalBruto += obj.SalarioBruto;
            }

            Console.WriteLine();
            Console.WriteLine($"> Total de pagamentos (bruto): {totalBruto:C2}");
            Console.WriteLine("------------------------------------------------");

        }

        public void ListarIndividual()
        {
            Console.WriteLine("Insira o nome a ser pesquisado:");
            string nome = Console.ReadLine();

            Console.Clear();

            GerenciadorUtil util = new GerenciadorUtil();
            int idFuncionario = util.ProcurarFuncionario(nome, listaFuncionarios);

            if (idFuncionario == -1)
            {
                Console.Clear();
                Console.WriteLine("Nenhum funcionário com esse nome foi encontrado.");
                Console.WriteLine();
            }
            else
            {
                Funcionario funcionario = listaFuncionarios[idFuncionario];

                funcionario.CalcularSalarioLiquido();

                Console.WriteLine("Nome: " + funcionario.Nome);
                Console.WriteLine();
                Console.WriteLine("Proventos:");
                Console.WriteLine();
                Console.WriteLine($"Valor por hora: {funcionario.ValorHora:C2}");
                Console.WriteLine($"Salário bruto: {funcionario.SalarioBruto:C2}");
                Console.WriteLine(funcionario.AdicionalNoturno == true ? $"Recebe adicional noturno (+20%) = {(funcionario.SalarioBruto * 1.2):C2}" : "Não recebe adicional noturno");
                Console.WriteLine($"Horas extras dia de semana : {funcionario.HorasExtras50} = {funcionario.ValorHorasExtras50:C2}");
                Console.WriteLine($"Horas extras fim de semana e feriados: {funcionario.HorasExtras100} = {funcionario.ValorHorasExtras100:C2}");
                Console.WriteLine();
                Console.WriteLine("Descontos:");
                Console.WriteLine();
                Console.WriteLine($"Valor pago ao INSS: {funcionario.INSS:C2}");
                Console.WriteLine($"Valor pago referente ao IRRF: {funcionario.IRRF:C2}");
                Console.WriteLine(funcionario.UsaVT == true ? $"Usa vale transporte, {funcionario.ValorVT:C2}" : "Não usa vale transporte");
                Console.WriteLine(funcionario.UsaVA == true ? $"Usa vale alimentação, {funcionario.ValorVA:C2}" : "Não usa vale alimentação");
                Console.WriteLine(funcionario.ContribuiSindicato == true ? "Contribui ao sindicato (R$ 50,00)" : "Não contribui ao sindicato");
                Console.WriteLine();
                Console.WriteLine($"Salário líquido: {funcionario.SalarioLiquido:C2}");
                Console.WriteLine("--------------------------------------------------");
            }

        }

        public void Alterar(string NomeEmpresa)
        {
            Console.WriteLine("Insira o nome a ser alterado:");
            string nome = Console.ReadLine();

            GerenciadorUtil util = new GerenciadorUtil();
            int idFuncionario = util.ProcurarFuncionario(nome, listaFuncionarios);

            if (idFuncionario == -1)
            {
                Console.Clear();
                Console.WriteLine("Nenhum funcionário com esse nome foi encontrado.");
                Console.WriteLine();
            }
            else
            {
                util.RequisitarInformacoes();

                listaFuncionarios[idFuncionario].Nome = util.Nome;
                listaFuncionarios[idFuncionario].ValorHora = util.ValorHora;
                listaFuncionarios[idFuncionario].HorasExtras50 = util.HorasExtras50;
                listaFuncionarios[idFuncionario].HorasExtras100 = util.HorasExtras100;
                listaFuncionarios[idFuncionario].UsaVT = util.UsaVT;
                listaFuncionarios[idFuncionario].UsaVA = util.UsaVA;
                listaFuncionarios[idFuncionario].AdicionalNoturno = util.AdicionalNoturno;
                listaFuncionarios[idFuncionario].ContribuiSindicato = util.ContribuiSindicato;

                GravarDB(NomeEmpresa);

                Console.Clear();
                Console.WriteLine($"Funcionário {nome} atualizado com sucesso!");
                Console.WriteLine();

            }


        }

        public void Deletar(string NomeEmpresa)
        {
            Console.WriteLine("Insira o nome a ser alterado:");
            string nome = Console.ReadLine();

            GerenciadorUtil util = new GerenciadorUtil();
            int idFuncionario = util.ProcurarFuncionario(nome, listaFuncionarios);

            if (idFuncionario == -1)
            {
                Console.Clear();
                Console.WriteLine("Nenhum funcionário com esse nome foi encontrado.");
                Console.WriteLine();
            }
            else
            {
                listaFuncionarios.RemoveAt(idFuncionario);

                GravarDB(NomeEmpresa);

                Console.Clear();
                Console.WriteLine("Colaborador removido com sucesso!");
                Console.WriteLine();
            }
        }

        public void GravarDB(string NomeEmpresa)
        {
            GerenciadorDatabaseController gerenciadorDBController = new GerenciadorDatabaseController(NomeEmpresa);
            gerenciadorDBController.GravarBancoDeDados(listaFuncionarios);
        }

        public void CarregarDB(string NomeEmpresa)
        {
            GerenciadorDatabaseController gerenciadorDBController = new GerenciadorDatabaseController(NomeEmpresa);
            listaFuncionarios.Clear();
            listaFuncionarios = gerenciadorDBController.CarregarBancoDeDados(listaFuncionarios);
        }

        public void DeletarDB(string NomeEmpresa)
        {
            GerenciadorDatabaseController gerenciadorDBController = new GerenciadorDatabaseController(NomeEmpresa);
            listaFuncionarios.Clear();
            gerenciadorDBController.DeletarBancoDeDados();
        }

    }
}
