//Models
using Projeto.Models;
using Projeto.Interfaces;
using Projeto.Funcionarios;

using System;

namespace Projeto.Controller
{
    internal class GerenciadorDatabaseController : IDBCrud
    {
        private string path = "";

        private string Path { get => path; set => path = value; }

        public GerenciadorDatabaseController(string database)
        {
            Path = @"C:\Database" + database + ".txt";
        }

        public void GravarBancoDeDados(List<Funcionario> listaFuncionarios)
        {
            try
            {

                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }

                using (FileStream fileStream = File.Create(Path));

                using StreamWriter arquivo = new(Path);
                {
                    foreach (Funcionario funcionario in listaFuncionarios)
                    {
                        switch (funcionario.GetType().Name)
                        {
                            case "Desenvolvedor":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},DEV");
                                break;

                            case "QA":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},QA");
                                break;

                            case "AnalistaSistemas":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},ANALSIS");
                                break;

                            case "AnalistaInfra":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},ANALINFRA");
                                break;

                            case "DevOps":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},DEVOPS");
                                break;

                            case "Segurança":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},SEGURANCA");
                                break;

                            case "Recepcionista":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},RECEPCAO");
                                break;

                            case "AnalistaDHO":
                                arquivo.WriteLine($"{funcionario.Nome},{funcionario.ValorHora},{funcionario.HorasExtras50},{funcionario.HorasExtras100}," +
                                $"{funcionario.UsaVA},{funcionario.UsaVT},{funcionario.AdicionalNoturno},{funcionario.ContribuiSindicato},ANALDHO");
                                break;

                            default:
                                Console.WriteLine("Uma nova classe não foi corretamente implementada!");
                                Console.WriteLine("Classe: " + funcionario.GetType().Name);
                                break;
                        }

                    }
                }

                arquivo.Close();

                Console.Clear();
                Console.WriteLine("Os dados foram gravados!");
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ocorreu um erro ao atualizar o banco de dados");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

        }

        public List<Funcionario> CarregarBancoDeDados(List<Funcionario> listaFuncionarios)
        {
            try
            {

                if (!File.Exists(Path))
                {
                    Console.Clear();
                    Console.WriteLine("O banco ainda não foi criado!");
                    Console.WriteLine();

                    return listaFuncionarios;
                }
                else
                {
                    using (StreamReader streamReader = File.OpenText(Path))
                    {
                        StreamReader streamReaderLineCounter = new StreamReader(Path);

                        // Pegando a quantidade de linhas para iterar
                        string arquivo = streamReaderLineCounter.ReadToEnd();
                        string[] linhas = arquivo.Split('\n');
                        int quantidadeLinhas = linhas.Count();

                        streamReaderLineCounter.Close();

                        int i = 1;

                        // Iterando lendo cada linha e criando um objeto de cada tipo para adicionar na lista
                        while (i < quantidadeLinhas)
                        {
                            Funcionario funcionario = new Funcionario("", 0, 0, 0);

                            string leitura = streamReader.ReadLine();

                            string[] vetor = leitura.Split(',');

                            switch (vetor[8])
                            {
                                case "DEV":
                                    funcionario = new Desenvolvedor(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "QA":
                                    funcionario = new QA(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "ANALSIS":
                                    funcionario = new AnalistaSistemas(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "ANALINFRA":
                                    funcionario = new AnalistaInfra(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "DEVOPS":
                                    funcionario = new DevOps(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "SEGURANCA":
                                    funcionario = new Segurança(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "RECEPCAO":
                                    funcionario = new Recepcionista(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                case "ANALDHO":
                                    funcionario = new AnalistaDHO(vetor[0], Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[3]));
                                    break;

                                default:
                                    Console.WriteLine("Uma classe não foi implementada corretamente!");
                                    Console.WriteLine("Classe: " + vetor[8]);
                                    break;
                            }

                            funcionario.UsaVA = Convert.ToBoolean(vetor[4]);
                            funcionario.UsaVT = Convert.ToBoolean(vetor[5]);
                            funcionario.AdicionalNoturno = Convert.ToBoolean(vetor[6]);
                            funcionario.ContribuiSindicato = Convert.ToBoolean(vetor[7]);

                            listaFuncionarios.Add(funcionario);
                            i++;

                        }
                        streamReader.Close();
                    }
                    Console.Clear();
                    Console.WriteLine("O banco de dados foi carregado!");
                    Console.WriteLine();

                    return listaFuncionarios;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ocorreu um erro ao carregar o banco de dados");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                return listaFuncionarios;
            }
        }

        public void DeletarBancoDeDados()
        {
            try
            {

                if (!File.Exists(Path))
                {
                    Console.Clear();
                    Console.WriteLine("O banco ainda não foi criado!");
                    Console.WriteLine();
                }
                else
                {
                    File.Delete(Path);

                    Console.Clear();
                    Console.WriteLine("O banco foi deletado!");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ocorreu um erro ao deletar o banco de dados");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }
    }
}
