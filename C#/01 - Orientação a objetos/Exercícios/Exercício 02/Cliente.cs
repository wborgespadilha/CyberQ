using System;

namespace Exercício_02
{
    internal class Cliente
    {

        private string _Nome = "";
        private int _Agencia = 0;
        private int _Conta = 0;
        private int _Senha = 0;

        private double _SaldoContaCorrente = 0;
        private double _SaldoContaPoupanca = 0;

        public string Nome { get => _Nome; set => _Nome = value; }
        public int Agencia { get => _Agencia; set => _Agencia = value; }
        public int Conta { get => _Conta; set => _Conta = value; }
        public int Senha { get => _Senha; set => _Senha = value; }
        public double SaldoContaCorrente { get => _SaldoContaCorrente; set => _SaldoContaCorrente = value; }
        public double SaldoContaPoupanca { get => _SaldoContaPoupanca; set => _SaldoContaPoupanca = value; }
    }
}
