using System;

namespace Exemplo_04
{
    internal class Pessoa
    {

        // Atributos
        private string _Nome = "";
        private int _Idade = 0;

        // Get e Set
        public string Nome { get => _Nome; set => _Nome = value; }
        public int Idade { get => _Idade; set => _Idade = value; }

    }
}
