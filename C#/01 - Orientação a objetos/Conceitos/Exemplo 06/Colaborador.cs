using System;

namespace Exemplo_06
{
    internal class Colaborador : Pessoa
    {

        public string Cargo = "";
        public double Salario = 0;

        public Colaborador(string Nome, int Idade, string Cargo, double Salario) : base(Nome,Idade)
        {
            
            this.Cargo = Cargo;
            this.Salario = Salario;

            Apresentacao();
            DadosColaborador();

        }

        public void DadosColaborador()
        {
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Salário: " + Salario);
        }

    }
}
