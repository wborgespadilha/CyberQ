string[,] produtos = new string[50, 3];
//Nome, valor, marca

string[] marcas = new string[50];
//Apenas nome

bool continuar = true;

bool nomeRepetido = false;
bool marcaExiste = false;
bool produtosVinculados = false;

string nomeMarca;
string nomeProduto;

double valorProduto;


do
{
    try
    {
        Console.WriteLine("Selecione a opção:\n1 - Cadastrar Marca\n2 - Alterar marca\n3 - Excluir marca");
        Console.WriteLine("4 - Cadastrar produtos\n5 - Listar produtos\n6 - Estatísticas\n7 - Sair do sistema");
        Console.WriteLine();
        int selecao = Convert.ToInt32(Console.ReadLine());

        switch (selecao)
        {
            case 1:

                //Cadastro de marca
                Console.WriteLine("Insira o nome da marca:");
                nomeMarca = Console.ReadLine();

                for (int i = 0; i < marcas.GetLength(0); i++)
                {
                    if (marcas[i] != null)
                    {
                        if (nomeMarca == marcas[i])
                        {
                            Console.Clear();
                            Console.WriteLine("Não pode ser um nome repetido!");
                            Console.WriteLine();
                            nomeRepetido = true;
                        }
                    }
                }

                if (nomeRepetido == false)
                {
                    for (int i = 0; i < marcas.GetLength(0); i++)
                    {
                        if (marcas[i] == null)
                        {
                            marcas[i] = nomeMarca;
                            Console.Clear();
                            Console.WriteLine("Marca cadastrada com sucesso");
                            Console.WriteLine();
                            break;
                        }
                    }
                }

                nomeRepetido = false;

                break;
            case 2:

                //Alteração de nome de marca
                Console.WriteLine("Insira o nome da marca:");
                string antigoNome = Console.ReadLine();

                int idMarca = -1;
                marcaExiste = false;

                for (int i = 0; i < marcas.GetLength(0); i++)
                {
                    if (marcas[i] != null)
                    {
                        if (antigoNome == marcas[i])
                        {
                            idMarca = i;
                            marcaExiste = true;
                            break;
                        }
                    }
                }

                if (marcaExiste == false)
                {
                    Console.Clear();
                    Console.WriteLine("Essa marca não existe!");
                    Console.WriteLine();
                    continue;
                }

                produtosVinculados = false;
                for (int i = 0; i < produtos.GetLength(0); i++)
                {
                    if (produtos[i, 2] != null)
                    {
                        if (antigoNome == produtos[i, 2])
                        {
                            Console.Clear();
                            Console.WriteLine("Essa marca tem produtos vinculados e não pode ser alterada!");
                            Console.WriteLine();
                            produtosVinculados = true;
                        }
                    }
                }

                if (produtosVinculados == false)
                {
                    Console.WriteLine("Insira o novo nome da marca:");
                    string novoNome = Console.ReadLine();

                    marcas[idMarca] = novoNome;

                    Console.Clear();
                    Console.WriteLine("Nome alterado com sucesso!");
                    Console.WriteLine();
                }

                break;
            case 3:

                //Exclusão de marca
                Console.WriteLine("Insira o nome da marca:");
                nomeMarca = Console.ReadLine();

                int idMarcaExclusao = -1;
                marcaExiste = false;

                for (int i = 0; i < marcas.GetLength(0); i++)
                {
                    if (marcas[i] != null)
                    {
                        if (nomeMarca == marcas[i])
                        {
                            idMarcaExclusao = i;
                            marcaExiste = true;
                            break;
                        }
                    }
                }

                if (marcaExiste == false)
                {
                    Console.Clear();
                    Console.WriteLine("Essa marca não existe!");
                    Console.WriteLine();
                    continue;
                }

                produtosVinculados = false;
                for (int i = 0; i < produtos.GetLength(0); i++)
                {
                    if (produtos[i, 2] != null)
                    {
                        if (nomeMarca == produtos[i, 2])
                        {
                            Console.Clear();
                            Console.WriteLine("Essa marca tem produtos vinculados e não pode ser excluída!");
                            Console.WriteLine();
                            produtosVinculados = true;
                            continue;
                        }
                    }
                }
                if (produtosVinculados == false)
                {
                    marcas[idMarcaExclusao] = null;

                    Console.Clear();
                    Console.WriteLine("Marca excluída com sucesso");
                    Console.WriteLine();
                }

                break;
            case 4:

                //Cadastro de produto
                Console.WriteLine("Insira o nome da marca");
                nomeMarca = Console.ReadLine();

                marcaExiste = false;
                for (int i = 0; i < marcas.GetLength(0); i++)
                {
                    if (marcas[i] != null)
                    {
                        if (nomeMarca == marcas[i])
                        {
                            idMarca = i;
                            marcaExiste = true;
                            break;
                        }
                    }
                }

                if (marcaExiste == false)
                {
                    Console.Clear();
                    Console.WriteLine("Essa marca não existe!");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Insira o nome do produto");
                nomeProduto = Console.ReadLine();

                Console.WriteLine("Insira o valor do produto");
                valorProduto = Convert.ToDouble(Console.ReadLine());


                for (int i = 0; i < produtos.GetLength(0); i++)
                {
                    if (produtos[i, 0] == null)
                    {
                        produtos[i, 0] = nomeProduto;
                        produtos[i, 1] = "R$" + valorProduto.ToString();
                        produtos[i, 2] = nomeMarca;
                        Console.Clear();
                        Console.WriteLine("Produto cadastrado com sucesso");
                        Console.WriteLine();
                        break;
                    }
                }

                break;
            case 5:

                //Listagem de produtos
                Console.Clear();
                Console.WriteLine("Produtos cadastrados:");
                for (int i = 0; i < produtos.GetLength(0); i++)
                {
                    if (produtos[i, 0] != null)
                    {
                        Console.WriteLine($"Produto: {produtos[i, 0]}, valor: {produtos[i, 1]}, marca: {produtos[i, 2]}");
                    }
                }
                Console.WriteLine();
                break;
            case 6:
                for (int i = 0; i < marcas.GetLength(0); i++)
                {
                    if (marcas[i] != null)
                    {
                        Console.Clear();
                        Console.Write(" ---> Marca: " + marcas[i] + ", quantidade: ");

                        int contador = 0;

                        for (int j = 0; j < produtos.GetLength(0); j++)
                        {
                            if (produtos[j, 2] != null)
                            {
                                if (marcas[i] == produtos[j, 2])
                                {
                                    //Console.WriteLine($"Produto: {produtos[j, 0]}, valor: {produtos[j, 1]}, marca: {produtos[j, 2]}");
                                    contador++;
                                    continue;
                                }
                            }
                        }
                        Console.Write(contador);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                break;
            case 7:
                continuar = false;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Insira um número de 1 a 7");
                Console.WriteLine();
                break;
        }
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Insira apenas números!");
        Console.WriteLine();
    }

}
while (continuar);