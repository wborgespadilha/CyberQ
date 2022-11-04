using System;


namespace Exemplo_08
{
    internal abstract class Padrao
    {

        public void Mensagem()
        {
            Console.WriteLine("Hello World");
        }

        public abstract void Apresentacao(string Nome);

    }
}
