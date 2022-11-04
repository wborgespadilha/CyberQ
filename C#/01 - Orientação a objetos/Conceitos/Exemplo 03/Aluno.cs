using System;

namespace Exemplo_03
{
    internal class Aluno
    {

        // Atributos
        public string Nome = "";
        public double Nota1 = 0;
        public double Nota2 = 0;

        // Método de mensagem
        public void Mensagem()
        {
            Console.WriteLine($"{Nome} está {Situacao()} com média {Media()}");
        }

        // Método para retornar a média
        private double Media()
        {
            return (Nota1 + Nota2)/2;
        }

        // Método para retornar a situação
        private string Situacao()
        {
            return Media() >= 7 ? "Aprovado(a)" : "Reprovado(a)";
        }

    }
}
