using System;

namespace Exemplo_07
{
    internal class Desenvolvedor : Padrao
    {

        public override void ImpostoRenda(double Salario)
        {
            Console.WriteLine("Imposto de renda Desenvolvedor: " + (Salario * 0.1));
        }

    }
}
