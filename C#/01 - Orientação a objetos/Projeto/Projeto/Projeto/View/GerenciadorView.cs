//Models
using Projeto.Funcionarios;
using Projeto.Interfaces;
using Projeto.Models;
//Controllers
using Projeto.Controller;
//Util
using Projeto.Util;

using System;

namespace Projeto.View
{
    internal class GerenciadorView
    {

        GerenciadorController gerenciadorController = new GerenciadorController();
        LoginController loginController = new LoginController();
        public void Login()
        {

            bool continuar = true;

            do
            {
                try
                {

                    Console.WriteLine("1) Logar na empresa");
                    Console.WriteLine("2) Cadastrar nova empresa");
                    Console.WriteLine("3) Fechar sistema");
                    Console.WriteLine();

                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:
                            LogarEmpresa();
                            break;

                        case 2:
                            CadastrarEmpresa();
                            break;

                        case 3:
                            continuar = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Insira 1,2 ou 3");
                            Console.WriteLine();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Erro ao logar:");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }

            }
            while (continuar);

        }

        public void Iniciar(string NomeEmpresa)
        {
            gerenciadorController.CarregarDB(NomeEmpresa);

            bool continuar = true;

            do
            {
                try
                {
                    Console.WriteLine($"Selecione uma operação (empresa {NomeEmpresa}):");
                    Console.WriteLine();
                    Console.WriteLine("1) Cadastrar colaborador");
                    Console.WriteLine("2) Listar colaboradores");
                    Console.WriteLine("3) Alterar colaborador");
                    Console.WriteLine("4) Deletar colaborador");
                    Console.WriteLine("5) Visualizar individual");
                    Console.WriteLine("6) Banco de dados");
                    Console.WriteLine("7) Deslogar da empresa");

                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:
                            gerenciadorController.Cadastrar(NomeEmpresa);
                            break;

                        case 2:
                            gerenciadorController.Listar();
                            break;

                        case 3:
                            gerenciadorController.Alterar(NomeEmpresa);
                            break;

                        case 4:
                            gerenciadorController.Deletar(NomeEmpresa);
                            break;

                        case 5:
                            gerenciadorController.ListarIndividual();
                            break;

                        case 6:
                            MenuBancoDeDados(NomeEmpresa);
                            break;

                        case 7:
                            Console.Clear();
                            continuar = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Insira um número de 1 a 6!");
                            Console.WriteLine();
                            break;

                    }

                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros de 1 a 6!");
                    Console.WriteLine();
                }
            }
            while (continuar);
        }

        private void MenuBancoDeDados(string NomeEmpresa)
        {
            try
            {
                GerenciadorDatabaseController gerenciadorDBController = new GerenciadorDatabaseController(NomeEmpresa);

                Console.Clear();
                Console.WriteLine("1) Gravar no banco de dados\n2) Carregar do banco de dados\n3) Limpar banco de dados");
                int selecao = Convert.ToInt32(Console.ReadLine());

                switch (selecao)
                {
                    case 1:
                        gerenciadorController.GravarDB(NomeEmpresa);
                        break;

                    case 2:
                        gerenciadorController.CarregarDB(NomeEmpresa);
                        break;

                    case 3:
                        gerenciadorController.DeletarDB(NomeEmpresa);
                        break;

                }

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Número inválido inserido!");
                Console.WriteLine();
            }
        }

        private void LogarEmpresa()
        {
            Console.Clear();

            if (loginController.NumeroEmpresas() != 0)
            {
                Console.WriteLine("Empresas disponíveis:");

                loginController.MostrarEmpresas();

                Console.WriteLine();
                Console.WriteLine("Insira o nome da empresa:");
                string nomeEmpresa = Console.ReadLine();

                if (loginController.EmpresaValida(nomeEmpresa))
                {
                    Iniciar(nomeEmpresa);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Não existe empresa com esse nome!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não foram encontradas empresas.");
                Console.WriteLine();
            }
        }

        private void CadastrarEmpresa()
        {
            Console.Clear();
            Console.WriteLine("Insira o nome da nova empresa:");
            string nomeEmpresa = Console.ReadLine();

            loginController.CadastrarEmpresa(nomeEmpresa);

            Console.Clear();
            Console.WriteLine($"Empresa {nomeEmpresa} cadastrada com sucesso!");
            Console.WriteLine();
        }
    }
}
