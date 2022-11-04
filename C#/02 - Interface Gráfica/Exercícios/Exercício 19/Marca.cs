using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_19
{
    internal class Marca
    {

        private string nome = "";
        private int quantidade = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Marca(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }   
    }
}
