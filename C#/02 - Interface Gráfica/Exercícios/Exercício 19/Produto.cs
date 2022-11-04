using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_19
{
    internal class Produto
    {

        private string nome = "";
        private double valor = 0;
        private string marca = "";

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Marca { get => marca; set => marca = value; }

        public Produto(string nome, double valor, string marca)
        {
            Nome = nome;
            Valor = valor;
            Marca = marca;
        }
    }
}
