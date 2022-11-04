using Projeto.Models;

using System;

namespace Projeto.Util
{
    internal class GerenciadorUtil
    {
        private bool usaVT = false;
        private bool usaVA = false;
        private string nome = "";

        private double valorHora = 0;
        private int horasExtras50 = 0;
        private int horasExtras100 = 0;

        private bool adicionalNoturno = false;
        private bool contribuiSindicato = false;

        public string Nome { get => nome; set => nome = value; }
        public bool UsaVT { get => usaVT; set => usaVT = value; }
        public bool UsaVA { get => usaVA; set => usaVA = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
        public int HorasExtras50 { get => horasExtras50; set => horasExtras50 = value; }
        public int HorasExtras100 { get => horasExtras100; set => horasExtras100 = value; }
        public bool AdicionalNoturno { get => adicionalNoturno; set => adicionalNoturno = value; }
        public bool ContribuiSindicato { get => contribuiSindicato; set => contribuiSindicato = value; }

        public void RequisitarInformacoes()
        {

            Console.Clear();
            Console.WriteLine("Insira o nome do funcionário:");
            Nome = Console.ReadLine();

            Console.Clear();

            bool tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Insira o salário por hora");
                    ValorHora = Convert.ToDouble(Console.ReadLine());
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números!");
                }
            }

            Console.Clear();
            tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Insira as horas extras deste mês (dias da semana)");
                    HorasExtras50 = Convert.ToInt32(Console.ReadLine());
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                }
            }

            Console.Clear();
            tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Insira as horas extras deste mês (fins de semana e feriados)");
                    HorasExtras100 = Convert.ToInt32(Console.ReadLine());
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                }
            }

            Console.Clear();
            tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Usa Vale Transporte? 1 - Sim, Outro número - Não");
                    UsaVT = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                }
            }

            Console.Clear();
            tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Usa Vale Alimentação? 1 - Sim, Outro número - Não");
                    UsaVA = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                }
            }

            Console.Clear();
            tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Recebe adicional noturno? 1 - Sim, Outro número - Não");
                    AdicionalNoturno = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                }
            }

            Console.Clear();
            tentar = true;
            while (tentar)
            {
                try
                {
                    Console.WriteLine("Contribui ao sindicato? 1 - Sim, Outro número - Não");
                    ContribuiSindicato = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
                    tentar = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números inteiros!");
                }
            }
        }

        public int ProcurarFuncionario(string nome, List<Funcionario> listaFuncionarios)
        {
            for (int i = 0; i < listaFuncionarios.Count; i++)
            {
                Funcionario funcionario = listaFuncionarios[i];
                if (funcionario.Nome == nome)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
