string[,] contato = new string[50, 4];
//Nome, e-mail, telefone, cidade

string[] cidades = new string[50];

bool continuar = true;
bool temContato = false;
bool existeCidade = false;

string nomeContato;
string emailContato;
string telefoneContato;
string cidadeContato;

int idContato = -1;
int indiceNovaCidade = 0;


do
{
    try
    {

        Console.WriteLine("Selecione as opções:\n1 - Cadastrar\n2 - Listar\n3 - Pesquisar");
        Console.WriteLine("4 - Alterar\n5 - Remover\n6 - Estatísticas\n7 - Finalizar sistema");
        int selecao = Convert.ToInt32(Console.ReadLine());

        switch(selecao)
        {
            case 1:

                //Cadastro de contatos
                Console.WriteLine("Insira o nome");
                nomeContato = Console.ReadLine();

                Console.WriteLine("Insira o e-mail:");
                emailContato = Console.ReadLine();

                Console.WriteLine("Insira o telefone:");
                telefoneContato = Console.ReadLine();

                Console.WriteLine("Insira a cidade:");
                cidadeContato = Console.ReadLine();

                for(int i = 0; i < contato.GetLength(0); i++)
                {
                    if(contato[i,0] == null)
                    {
                        contato[i, 0] = nomeContato;
                        contato[i, 1] = emailContato;
                        contato[i, 2] = telefoneContato;
                        contato[i, 3] = cidadeContato;
                        break;
                    }
                }

                Console.Clear();
                Console.WriteLine("Cadastrado com sucesso!");
                Console.WriteLine();

                break;

            case 2:

                //Listagem de contatos
                Console.Clear();
                Console.WriteLine(" ----> Contatos cadastrados:");
                Console.WriteLine();
                for(int i = 0; i < contato.GetLength(0); i++)
                {
                    if (contato[i, 0] != null)
                    {
                        Console.WriteLine($"Nome: {contato[i, 0]}, E-Mail: {contato[i, 1]}, Telefone: {contato[i, 2]}, Cidade:{contato[i, 3]}");
                        temContato = true;
                    }
                }
                if (temContato == false)
                {
                    Console.WriteLine("Nenhum contato foi encontrado.");
                }
                Console.WriteLine();

                break;

            case 3:

                //Pesquisa de contato pelo nome
                Console.WriteLine("Insira o nome a ser pesquisado:");
                nomeContato = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Resultados:");

                temContato = false;

                for (int i = 0; i < contato.GetLength(0); i++)
                {
                    if (contato[i, 0] == nomeContato)
                    {
                        Console.WriteLine($"Nome: {contato[i, 0]}, E-Mail: {contato[i, 1]}, Telefone: {contato[i, 2]}, Cidade:{contato[i, 3]}");
                        temContato = true;
                    }
                }

                if (temContato == false)
                {
                    Console.WriteLine("Nenhum contato foi encontrado.");
                }

                Console.WriteLine();

                break;

            case 4:

                //Alterar um contato
                Console.WriteLine("Insira o nome do contato a ser alterado:");
                nomeContato = Console.ReadLine();

                temContato = false;
                idContato = -1;

                for(int i = 0; i < contato.GetLength(0); i++)
                {
                    if (contato[i, 0] == nomeContato)
                    {
                        temContato = true;
                        idContato = i;
                        break;
                    }
                }
                
                if(temContato == false)
                {
                    Console.Clear();
                    Console.WriteLine("O contato não existe!");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Insira o e-mail:");
                emailContato = Console.ReadLine();

                Console.WriteLine("Insira o telefone:");
                telefoneContato = Console.ReadLine();

                Console.WriteLine("Insira a cidade:");
                cidadeContato = Console.ReadLine();

                contato[idContato, 0] = nomeContato;
                contato[idContato, 1] = emailContato;
                contato[idContato, 2] = telefoneContato;
                contato[idContato, 3] = cidadeContato;

                Console.Clear();
                Console.WriteLine("Contato alterado com sucesso!");
                Console.WriteLine();

                break;

            case 5:

                //Excluir um contato
                Console.WriteLine("Insira o nome do contato a ser excluído:");
                nomeContato = Console.ReadLine();

                temContato = false;
                idContato = -1;

                for (int i = 0; i < contato.GetLength(0); i++)
                {
                    if (contato[i, 0] == nomeContato)
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
                    continue;
                }


                contato[idContato, 0] = null;
                contato[idContato, 1] = null;
                contato[idContato, 2] = null;
                contato[idContato, 3] = null;


                Console.Clear();
                Console.WriteLine("Contato excluído com sucesso!");
                Console.WriteLine();

                break;

            case 6:

                //Exibir o nome dos contatos por cidades

                //Pega a lista de cidades existentes
                for (int i = 0; i < contato.GetLength(0); i++)
                {
                    if (contato[i, 0] != null)
                    {
                        existeCidade = false;

                        for (int j = 0; j < cidades.GetLength(0); j++)
                        {
                        
                            if (contato[i, 3] == cidades[j])
                            {
                                existeCidade = true;
                            }

                        }
                        if (existeCidade == false)
                        {
                            cidades[indiceNovaCidade] = contato[i, 3];
                            indiceNovaCidade++;
                        }
                    }
                }


                Console.Clear();

                bool temDados = false;
                //Mostra os contatos de acordo com a cidade
                for (int i = 0; i < cidades.GetLength(0); i++)
                {
                    if (cidades[i] != null)
                    {
                        Console.WriteLine(" ----> Cidade: " + cidades[i]);

                        int contador = 0;

                        for (int j = 0; j < contato.GetLength(0); j++)
                        {
                            if (contato[j, 3] == cidades[i])
                            {
                                //Console.WriteLine($"Nome: {contato[j, 0]}, E-Mail: {contato[j, 1]}, Telefone: {contato[j, 2]}, Cidade:{contato[j, 3]}");
                                contador++;
                                temDados = true;
                            }
                        }
                        Console.WriteLine("Quantidade: " + contador);
                        Console.WriteLine();
                    }
                }

                if(temDados == false)
                {
                    Console.WriteLine("Nenhum dado foi encontrado!");
                    Console.WriteLine();
                }

                break;

            case 7:

                continuar = false;

                break;

            default:

                Console.WriteLine("Insira um número de 1 a 7");

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
while (continuar);