using Projeto.Models;
using System;

namespace Projeto.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string Nome, double ValorHora, int HorasExtras50, int HorasExtras100) : base(Nome, ValorHora, HorasExtras50, HorasExtras100)
        {
            this.Nome = Nome;
            this.ValorHora = ValorHora;
            this.HorasExtras50 = HorasExtras50;
            this.HorasExtras100 = HorasExtras100;
        }

        protected override double DescontoValeAlimentacao(double Salario)
        {
            return Salario * 0.04;
        }

        protected override double DescontoValeTransporte(double Salario)
        {
            return Salario * 0.06;
        }

    }
}
