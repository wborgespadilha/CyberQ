using System;

namespace Exercício_04
{
    internal class Gerenciador
    {

        private List<Contato> listaContatos = new List<Contato>();

        public void Iniciar()
        {
            bool continuar = true;

            do
            {
                try
                {
                    Console.WriteLine("Selecione as opções:\n1 - Cadastrar\n2 - Listar\n3 - Pesquisar");
                    Console.WriteLine("4 - Alterar\n5 - Remover\n6 - Estatísticas\n7 - Finalizar sistema");
                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:
                            Cadastrar();
                            break;

                        case 2:
                            Listar();
                            break;

                        case 3:
                            Pesquisar();
                            break;

                        case 4:
                            Alterar();
                            break;

                        case 5:
                            Remover();
                            break;

                        case 6:
                            Estatisticas();
                            break;

                        case 7:
                            continuar = false;
                            break;

                       default:
                            Console.WriteLine("Insira um número de 1 a 7");
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
            while (continuar);
        }


        private void Cadastrar()
        {

            //Cadastro de contatos
            Console.WriteLine("Insira o nome");
            string nomeContato = Console.ReadLine();

            Console.WriteLine("Insira o e-mail:");
            string emailContato = Console.ReadLine();

            if (EmailValido(emailContato) == false)
            {
                Console.Clear();
                Console.WriteLine("Email inváldo!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Insira o telefone (ex: 4712345678:");
            string telefoneContato = Console.ReadLine();

            if (TelefoneValido(telefoneContato) == false)
            {
                Console.Clear();
                Console.WriteLine("Telefone inváldo!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Insira a cidade:");
            string cidadeContato = Console.ReadLine();

            Contato contato = new Contato();

            contato.Nome = nomeContato;
            contato.Email = emailContato;
            contato.Telefone = telefoneContato;
            contato.Cidade = cidadeContato;

            listaContatos.Add(contato);

            Console.Clear();
            Console.WriteLine("Cadastrado com sucesso!");
            Console.WriteLine();

        }

        private bool EmailValido(string email)
        {
            char[] caracteresProibidos = { '!', '#', '$', '%', '¨', '&', '*', '(', ')', '=', '´', '[', ']', '{', '}', '~', '^', ';', ':', ',', '/', '|', '*', '-', '+', 'ç', '"' };

            bool emailValido = true;

            int quantidadeArrobas = 0;

            for (int i = 0; i < email.Length; i++)
            {
                for (int j = 0; j < caracteresProibidos.Length; j++)
                {
                    //Verifica se o email contêm caracteres especiais proibidos
                    if (email[i] == caracteresProibidos[j])
                    {
                        emailValido = false;
                    }
                }

                //Contabiliza a quantidade de arrobas no email
                if (email[i] == '@')
                {
                    quantidadeArrobas++;
                }

            }

            if (quantidadeArrobas != 1)
            {
                emailValido = false;
            }
            else
            {
                string[] vetor = email.Split('@');
                //Depois de quebrar o email em 2 faz a verificação de . após o @
                if (!vetor[1].Contains('.'))
                {
                    emailValido = false;
                }
                //E a quantidade de caracteres após o @
                if (vetor[1].Length < 5)
                {
                    emailValido = false;
                }
            }

            return emailValido;
        }

        private bool TelefoneValido(string telefone)
        {
            if(telefone.Length == 0)
            {
                return false;
            }
            else
            {
                //Verifica se está na faixa de 47123456789 = (ddd) + numero
                if(Convert.ToInt64(telefone) < 1000000000 || Convert.ToInt64(telefone) > 9999999999)
                {
                    return false;
                }
            }
            return true;
        }

        private void Listar()
        {
            //Listagem de contatos
            Console.Clear();
            Console.WriteLine(" ----> Contatos cadastrados:");
            Console.WriteLine();

            bool temContato = false;

            foreach(Contato contato in listaContatos)
            {
                Console.WriteLine($"Nome: {contato.Nome}, E-Mail: {contato.Email}, Telefone: {contato.Telefone}, Cidade:{contato.Cidade}");
                temContato = true;
            }

            if (temContato == false)
            {
                Console.WriteLine("Nenhum contato foi encontrado.");
            }
            Console.WriteLine();
        }

        private void Pesquisar()
        {
            // Pesquisa de contato pelo nome
            Console.WriteLine("Insira o nome a ser pesquisado:");
            string nomeContato = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Resultados:");

            bool temContato = false;

            foreach(Contato contato in listaContatos)
            {
                if (contato.Nome == nomeContato)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, E-Mail: {contato.Email}, Telefone: {contato.Telefone}, Cidade:{contato.Cidade}");
                    temContato = true;
                }
            }

            if (temContato == false)
            {
                Console.WriteLine("Nenhum contato foi encontrado.");
            }

            Console.WriteLine();
        }

        private void Alterar()
        {
            //Alterar um contato

            Console.WriteLine("Insira o nome do contato a ser alterado:");
            string nomeContato = Console.ReadLine();

            bool temContato = false;
            int idContato = -1;

            for (int i = 0; i < listaContatos.Count; i++)
            {
                Contato contato = listaContatos[i];
                if (contato.Nome == nomeContato)
                {
                    temContato = true;
                    idContato = i;
                    break;
                }
            }

            if (temContato == false)
            {
                Console.Clear();
                Console.WriteLine("O contato não existe!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Insira o e-mail:");
            string emailContato = Console.ReadLine();

            if (EmailValido(emailContato) == false)
            {
                Console.Clear();
                Console.WriteLine("Email inváldo!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Insira o telefone:");
            string telefoneContato = Console.ReadLine();

            if (TelefoneValido(telefoneContato) == false)
            {
                Console.Clear();
                Console.WriteLine("Telefone inváldo!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Insira a cidade:");
            string cidadeContato = Console.ReadLine();

            Contato newContato = new Contato();

            newContato.Nome = nomeContato;
            newContato.Email = emailContato;
            newContato.Telefone = telefoneContato;
            newContato.Cidade = cidadeContato;

            listaContatos[idContato] = newContato;

            Console.Clear();
            Console.WriteLine("Contato alterado com sucesso!");
            Console.WriteLine();
        }

        private void Remover()
        {
            //Excluir um contato
            Console.WriteLine("Insira o nome do contato a ser excluído:");
            string nomeContato = Console.ReadLine();

            bool temContato = false;
            int idContato = -1;

            for (int i = 0; i < listaContatos.Count; i++)
            {
                Contato contato = listaContatos[i];
                if (contato.Nome == nomeContato)
                {
                    temContato = true;
                    idContato = i;
                    break;
                }
            }

            if (temContato == false)
            {
                Console.Clear();
                Console.WriteLine("O contato não existe!");
                Console.WriteLine();
                return;
            }

            listaContatos.RemoveAt(idContato);

            Console.Clear();
            Console.WriteLine("Contato excluído com sucesso!");
            Console.WriteLine();
        }

        private void Estatisticas()
        {
            //Exibir o nome dos contatos por cidades

            List<string> cidades = new List<string>();

            bool existeCidade = false;

            //Pega a lista de contatos existentes
            foreach(Contato contato in listaContatos)
            {
                for (int j = 0; j < cidades.Count; j++)
                {
                    //Verifica se a cidade do contato já foi registrada
                    if (contato.Cidade == cidades[j])
                    {
                        existeCidade = true;
                    }

                }
                //Cria não tenha sido registrada adiciona ela
                if (existeCidade == false)
                {
                    cidades.Add(contato.Cidade);
                }
            }


            Console.Clear();

            //Mostra os contatos de acordo com a cidade
            bool temDados = false;

            //Percorre a lista de cidades
            for (int i = 0; i < cidades.Count; i++)
            {
                Console.WriteLine(" ----> Cidade: " + cidades[i]);

                int contador = 0;

                //Em seguida percorre a lista de contatos procurando correspondências
                for (int j = 0; j < listaContatos.Count; j++)
                {
                    Contato contato = listaContatos[j];
                    if (contato.Cidade == cidades[i])
                    {
                        //Adiciona quantidade de correspondências e mostra depois
                        contador++;
                        temDados = true;
                    }
                }
                Console.WriteLine("Quantidade: " + contador);
                Console.WriteLine();

            }

            if (temDados == false)
            {
                Console.WriteLine("Nenhum dado foi encontrado!");
                Console.WriteLine();
            }
        }

    }
}
