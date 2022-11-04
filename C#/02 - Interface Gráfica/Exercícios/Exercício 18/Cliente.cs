using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    public class Cliente
    {

        private string nome = "";
        private int agencia = 0;
        private int contaCorrente = 0;
        private int senha = 0;
        private double saldoCC = 0;
        private double saldoCP = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Agencia { get => agencia; set => agencia = value; }
        public int ContaCorrente { get => contaCorrente; set => contaCorrente = value; }
        public int Senha { get => senha; set => senha = value; }
        public double SaldoCC { get => saldoCC; set => saldoCC = value; }
        public double SaldoCP { get => saldoCP; set => saldoCP = value; }
    }
}
