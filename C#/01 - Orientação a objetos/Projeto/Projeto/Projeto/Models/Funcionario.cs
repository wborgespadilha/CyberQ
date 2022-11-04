using System;

namespace Projeto.Models
{
    internal class Funcionario
    {

        private string nome = "";

        private double valorHora = 0;
        private double salarioBruto = 0;
        private double salarioLiquido = 0;

        private double _IRRF = 0;
        private double _INSS = 0;

        private bool usaVT = false;
        private bool usaVA = false;

        private int horasExtras50 = 0;
        private int horasExtras100 = 0;

        private double valorHorasExtras50 = 0;
        private double valorHorasExtras100 = 0;

        private double valorVT = 0;
        private double valorVA = 0;

        private bool adicionalNoturno = false;
        private bool contribuiSindicato = false;

        public string Nome { get => nome; set => nome = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
        public double SalarioBruto { get => salarioBruto; set => salarioBruto = value; }
        public double SalarioLiquido { get => salarioLiquido; set => salarioLiquido = value; }
        public double IRRF { get => _IRRF; set => _IRRF = value; }
        public double INSS { get => _INSS; set => _INSS = value; }
        public bool UsaVT { get => usaVT; set => usaVT = value; }
        public bool UsaVA { get => usaVA; set => usaVA = value; }
        public double ValorVT { get => valorVT; set => valorVT = value; }
        public double ValorVA { get => valorVA; set => valorVA = value; }
        public int HorasExtras50 { get => horasExtras50; set => horasExtras50 = value; }
        public int HorasExtras100 { get => horasExtras100; set => horasExtras100 = value; }
        public bool AdicionalNoturno { get => adicionalNoturno; set => adicionalNoturno = value; }
        public bool ContribuiSindicato { get => contribuiSindicato; set => contribuiSindicato = value; }
        public double ValorHorasExtras50 { get => valorHorasExtras50; set => valorHorasExtras50 = value; }
        public double ValorHorasExtras100 { get => valorHorasExtras100; set => valorHorasExtras100 = value; }

        public Funcionario(string Nome, double ValorHora, int HorasExtras50, int HorasExtras100)
        {

            this.Nome = Nome;
            this.ValorHora = ValorHora;
            this.HorasExtras50 = HorasExtras50;
            this.HorasExtras100 = HorasExtras100;
        }

        public void CalcularSalarioLiquido()
        {
            SalarioBruto = ValorHora * 8 * 22;

            double Descontos = 0;

            Descontos += CalcularDescontoINSS(SalarioBruto);
            Descontos += CalcularDescontoIRRF(SalarioBruto);

            ValorVT = UsaVT == true ? DescontoValeTransporte(SalarioBruto) : 0;
            Descontos += ValorVT;

            ValorVA = UsaVA == true ? DescontoValeAlimentacao(SalarioBruto) : 0;
            Descontos += ValorVA;

            Descontos += ContribuiSindicato == true ? DescontoSindicato() : 0;

            SalarioLiquido = SalarioBruto;
            SalarioLiquido = AdicionalNoturno == true ? SalarioLiquido * 1.2 : SalarioLiquido;

            ValorHorasExtras50 = HorasExtras50 * (ValorHora * 1.5);
            SalarioLiquido += ValorHorasExtras50;

            ValorHorasExtras100 = HorasExtras100 * (ValorHora * 2.0);
            SalarioLiquido += ValorHorasExtras100;

            SalarioLiquido -= Descontos;

        }

        protected double CalcularDescontoINSS(double Salario)
        {
            double Desconto = 0;

            if (Salario <= 1751.81)
            {
                Desconto = Salario * 0.08;
            }
            else if (Salario <= 2919.72)
            {
                Desconto = Salario * 0.09;
            }
            else if (Salario <= 5839.45)
            {
                Desconto = Salario * 0.11;
            }
            else
            {
                Desconto = 642.34;
            }

            INSS = Desconto;
            return Desconto;

        }

        protected double CalcularDescontoIRRF(double Salario)
        {
            double Desconto = 0;

            if (Salario <= 1903.98)
            {
                Desconto = 0;
            }
            else if (Salario <= 2826.65)
            {
                Desconto = Salario * 0.075;
            }
            else if (Salario <= 3751.05)
            {
                Desconto = Salario * 0.12;
            }
            else if (Salario <= 4664.68)
            {
                Desconto = Salario * 0.225;
            }
            else
            {
                Desconto = Salario * 0.275;
            }

            IRRF = Desconto;
            return Desconto;
        }


        protected double DescontoSindicato()
        {
            return 50;
        }

        protected virtual double DescontoValeAlimentacao(double Salario)
        {
            return Salario * 0.10;
        }

        protected virtual double DescontoValeTransporte(double Salario)
        {
            return Salario * 0.04;
        }

    }
}
