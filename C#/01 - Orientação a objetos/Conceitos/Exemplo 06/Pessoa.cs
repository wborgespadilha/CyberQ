using System;

namespace Exemplo_06
{
    internal class Pessoa
    {
        protected string Nome = "";
        protected int Idade = 0;

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        protected void Apresentacao()
        {
            Console.WriteLine("Nome: " + Nome + ", Idade: " + Idade);
        }

    }
}
