using System;

namespace Exemplo_07
{
    internal class Padrao
    {

        public void ValeTransporte(double Salario)
        {
            Console.WriteLine("Vale transporte padrão: " + (Salario * 0.06));
        }

        public virtual void ImpostoRenda(double Salario)
        {
            Console.WriteLine("Imposto de renda Padrão: " + (Salario * 0.05));
        }

    }
}
