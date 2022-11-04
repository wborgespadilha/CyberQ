using System;


namespace Exercício_01
{
    internal class Menu
    {

        private List<Produtos> listaProdutos = new List<Produtos>();

        public void Iniciar()
        {
            bool continuar = true;

            do
            {

                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Verificar Validade");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("5 - Remover");
                Console.WriteLine("6 - Finalizar");
                try
                {
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
                            VerificarValidade();
                            break;

                        case 4:
                            Alterar();
                            break;

                        case 5:
                            Remover();
                            break;

                        case 6:
                            continuar = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Insira números inteiros de 1 a 6!");
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

        private void Cadastrar()
        {
            Produtos produto = PedirParametros();

            if (produto != null)
            {

                listaProdutos.Add(produto);

                Console.Clear();
                Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso!");
                Console.WriteLine();
            }
        }

        private void Listar()
        {
            Console.Clear();
            Console.WriteLine("Lista de produtos:");

            foreach(Produtos obj in listaProdutos)
            {
                Console.WriteLine($"{obj.Nome} - {obj.Valor:C2} - Marca: {obj.Marca} - Validade: {obj.Validade}");
            }

            Console.WriteLine();
        }

        private void VerificarValidade()
        {
            Console.Clear();
            Console.WriteLine("Produtos vencendo dentro dos próximos 30 dias:");

            DateTime dataAtual = DateTime.Now;

            foreach(Produtos obj in listaProdutos)
            {
                int diferenca = DateTime.Compare(obj.Validade, dataAtual);
                if(diferenca <= 30)
                {
                    Console.WriteLine($"{obj.Nome} - {obj.Valor:C2} - Marca: {obj.Marca} - Validade: {obj.Validade}");
                }
            }

            Console.WriteLine();
        }

        private void Alterar()
        {
            Console.Clear();

            Console.WriteLine("Insira o nome do produto a ser alterado");
            string produto = Console.ReadLine();

            int idProduto = ProcurarProduto(produto);

            if (idProduto != -1)
            {
                Produtos novoProduto = PedirParametros();

                if (novoProduto != null)
                {
                    listaProdutos[idProduto] = novoProduto;

                    Console.Clear();
                    Console.WriteLine("Produto alterado com sucesso!");
                    Console.WriteLine();
                }

            }
        }

        private void Remover()
        {
            Console.Clear();

            Console.WriteLine("Insira o nome do produto a ser alterado");
            string produto = Console.ReadLine();

            int idProduto = ProcurarProduto(produto);

            if (idProduto != -1)
            {
                listaProdutos.RemoveAt(idProduto);
                Console.WriteLine("Produto removido com sucesso!");
                Console.WriteLine();
             }
        }

        private int ProcurarProduto(string produto)
        {
            int produtoId = -1;

            for (int i = 0; i < listaProdutos.Count; i++)
            {
                Produtos obj = listaProdutos[i];
                if (obj.Nome == produto)
                {
                    produtoId = i;
                    break;
                }
            }

            if (produtoId == -1)
            {
                Console.Clear();
                Console.WriteLine("Nenhum produto com esse nome foi encontrado!");
                Console.WriteLine();
                return -1;
            }
            else
            {
                return produtoId;
            }
        }

        private Produtos PedirParametros()
        {
            try
            {

                Console.WriteLine("Insira o nome do produto:");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira o valor do produto:");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira a marca:");
                string marca = Console.ReadLine();

                Console.WriteLine("Insira a data de validade (formato: dd/mm/aaaa):");
                string data = Console.ReadLine();

                string[] vetorData = data.Contains("/") ? data.Split("/") : data.Split("-");

                DateTime dataValidade = new DateTime(Convert.ToInt32(vetorData[2]), Convert.ToInt32(vetorData[1]), Convert.ToInt32(vetorData[0]));

                Produtos produto = new Produtos();

                produto.Nome = nome;
                produto.Valor = valor;
                produto.Marca = marca;
                produto.Validade = dataValidade;

                return produto;

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Tipo inválido inserido: " + ex.Message);
                Console.WriteLine();
                return null;
            }

}

    }
}
