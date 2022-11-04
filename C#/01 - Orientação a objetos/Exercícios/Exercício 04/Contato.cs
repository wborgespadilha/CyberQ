using System;

namespace Exercício_04
{
    internal class Contato
    {

        private string _Nome = "";
        private string _Email = "";
        private string _Telefone = "";
        private string _Cidade = "";

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
    }
}
