using System;

namespace Exemplo_05
{
    internal class Pessoa
    {

        //Atributos
        private string Nome = "";
        private int Idade = 0;

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public Pessoa()
        {
            Console.WriteLine("Bom dia");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Bom dia " + nome);
        }

    }
}
