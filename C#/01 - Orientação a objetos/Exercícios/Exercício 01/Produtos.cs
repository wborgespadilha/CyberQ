using System;


namespace Exercício_01
{
    internal class Produtos
    {

        private string _Nome = "";
        private string _Marca = "";
        private double _Valor = 0;
        private DateTime _Validade = new DateTime();

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public double Valor { get => _Valor; set => _Valor = value; }
        public DateTime Validade { get => _Validade; set => _Validade = value; }
    }
}
