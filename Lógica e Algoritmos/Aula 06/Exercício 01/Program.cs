using System.Collections;

bool continuar = true;

var nomes = new ArrayList();
var marcas = new ArrayList();
var valores = new ArrayList();

while (continuar)
{
    try
    {
        Console.WriteLine();
        Console.WriteLine("Selecione a opção\n1 - Cadastrar\n2 - Listar\n3 - Pesquisar\n4 - Alterar\n5 - Remover\n6 - Sair");

        int selecao = Convert.ToInt32(Console.ReadLine());

        switch(selecao)
        {
            case 1:

                Console.WriteLine("Insira o nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira a marca");
                string marca = Console.ReadLine();

                Console.WriteLine("Insira o valor");
                double valor = Convert.ToDouble(Console.ReadLine());

                nomes.Add(nome);
                marcas.Add(marca);
                valores.Add(valor);

                Console.Clear();
                Console.WriteLine("Produto cadastrado com sucesso");

                break;

            case 2:

                Console.Clear();

                bool encontrado = false;

                for (int i = 0; i < nomes.Count; i++)
                {
                    Console.Write(nomes[i]);
                    Console.Write(" - ");
                    Console.Write(marcas[i]);
                    Console.Write(" - ");
                    Console.Write(Convert.ToDouble(valores[i]).ToString("C2"));
                    Console.WriteLine();

                    encontrado = true;
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Nenhum produto foi encontrado");
                }

                break;

            case 3:

                Console.WriteLine("1 - Pesquisar por nome\n2 - Pesquisar por marca\n3 - Pesquisar por valor");
                int pesquisa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o termo");
                string termo = Console.ReadLine();

                Console.Clear();

                encontrado = false;

                switch(pesquisa)
                {
                    case 1:

                        for(int i = 0; i < nomes.Count; i++)
                        {
                            if (nomes[i].ToString() == termo)
                            {
                                Console.Write(nomes[i]);
                                Console.Write(" - ");
                                Console.Write(marcas[i]);
                                Console.Write(" - ");
                                Console.Write(Convert.ToDouble(valores[i]).ToString("C2"));
                                Console.WriteLine();

                                encontrado = true;
                            }
                        }

                        break;

                    case 2:

                        for (int i = 0; i < marcas.Count; i++)
                        {
                            if (marcas[i].ToString() == termo)
                            {
                                Console.Write(nomes[i]);
                                Console.Write(" - ");
                                Console.Write(marcas[i]);
                                Console.Write(" - ");
                                Console.Write(Convert.ToDouble(valores[i]).ToString("C2"));
                                Console.WriteLine();

                                encontrado = true;
                            }
                        }

                        encontrado = true;

                        break;

                    case 3:

                        for (int i = 0; i < valores.Count; i++)
                        {
                            if (valores[i].ToString() == termo)
                            {
                                Console.Write(nomes[i]);
                                Console.Write(" - ");
                                Console.Write(marcas[i]);
                                Console.Write(" - ");
                                Console.Write(Convert.ToDouble(valores[i]).ToString("C2"));
                                Console.WriteLine();

                                encontrado = true;
                            }
                        }

                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Entrada inválida!");

                        break;
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Nenhum produto com este termo foi encontrado");
                }


                break;

            case 4:

                Console.WriteLine("Insira o nome do produto a ser alterado");
                string produto = Console.ReadLine();

                int idEncontrado = -1;

                for (int i = 0; i < nomes.Count; i++)
                {
                    if (nomes[i].ToString() == produto)
                    {
                        idEncontrado = i;
                        break;
                    }
                }

                if(idEncontrado == -1)
                {
                    Console.Clear();
                    Console.WriteLine("O produto não foi encontrado!");
                    continue;
                }

                Console.WriteLine("Insira o nome");
                nome = Console.ReadLine();

                Console.WriteLine("Insira a marca");
                marca = Console.ReadLine();

                Console.WriteLine("Insira o valor");
                valor = Convert.ToDouble(Console.ReadLine());

                nomes[idEncontrado] = nome;
                marcas[idEncontrado] = marca;
                valores[idEncontrado] = valor;

                Console.Clear();
                Console.WriteLine("Produto alterado com sucesso");

                break;

            case 5:

                Console.WriteLine("Insira o nome do produto a ser removido");
                produto = Console.ReadLine();

                idEncontrado = -1;

                for (int i = 0; i < nomes.Count; i++)
                {
                    if (nomes[i].ToString() == produto)
                    {
                        idEncontrado = i;
                        break;
                    }
                }

                if (idEncontrado == -1)
                {
                    Console.Clear();
                    Console.WriteLine("O produto não foi encontrado!");
                    continue;
                }

                nomes.RemoveAt(idEncontrado);
                marcas.RemoveAt(idEncontrado);
                valores.RemoveAt(idEncontrado);

                Console.Clear();
                Console.WriteLine("Produto removido com sucesso!");

                break;

            case 6:

                continuar = false;

                break;

            default:

                Console.Clear();
                Console.WriteLine("Insira apenas números de 1 a 6");

                break;

        }

    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Use somente números");
    }
}