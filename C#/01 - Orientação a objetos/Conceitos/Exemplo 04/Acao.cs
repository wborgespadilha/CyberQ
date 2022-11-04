using System;

namespace Exemplo_04
{
    internal class Acao
    {
        // Lista contendo as pessoas cadastradas
        private List<Pessoa> lista = new List<Pessoa>();

        // Método de inicialização
        public void Iniciar()
        {

            // Validar laço
            bool continuar = true;

            //Laço de repetição
            do
            {

                // Menu
                Console.Clear();
                Console.WriteLine("***MENU***");
                Console.WriteLine("1) Cadastrar");
                Console.WriteLine("2) Listar");
                Console.WriteLine("3) Remover");
                Console.WriteLine("4) Finalizar");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Cadastrar();
                        break;

                    case 2:
                        Listar();
                        break;

                    case 3:
                        Remover();
                        break;

                    case 4:
                        continuar = false;
                        break;
                }

            } while (continuar);

        }

        // Método de cadastro
        private void Cadastrar()
        {
            // Instancias objeto da classe Pessoa
            Pessoa p = new Pessoa();

            Console.WriteLine("Informe seu nome");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            p.Idade = Convert.ToInt32(Console.ReadLine());

            //Adicionar na lista
            lista.Add(p);

            // Retorno
            Console.WriteLine("Cadastro realizado com sucesso!");

            // Timer
            Thread.Sleep(3000);

        }

        // Método para listar as pessoas
        private void Listar()
        {
            Console.Clear();

            foreach(Pessoa obj in lista)
            {
                Console.WriteLine($"Nome: {obj.Nome}");
                Console.WriteLine($"Idade: {obj.Idade}");
                Console.WriteLine("---------------------");
            }

            Thread.Sleep(3000);
        }

        // Método para remover uma pessoa da lista
        private void Remover()
        {
            Console.Clear();
            
            Console.WriteLine("Informe o índice que deseja remover a pessoa");
            int indice = Convert.ToInt32(Console.ReadLine());

            lista.RemoveAt(indice);

            Console.WriteLine("Pessoa removida com sucesso!");

            Thread.Sleep(2000);

        }
    }
}
