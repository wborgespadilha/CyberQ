using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    public class Extrato
    {

        private string tipo = "";
        private double valor = 0;
        private string conta = "";

        public string Tipo { get => tipo; set => tipo = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Conta { get => conta; set => conta = value; }

        public Extrato(string tipo, double valor, string conta)
        {
            Tipo = tipo;
            Valor = valor;
            Conta = conta;
        }
    }
}
