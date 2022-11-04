using System;

namespace Exemplo_02
{
    internal class Pessoa
    {

        private string nome = "";
        private int idade = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public override string ToString()
        {
            return nome;
        }

    }
}
