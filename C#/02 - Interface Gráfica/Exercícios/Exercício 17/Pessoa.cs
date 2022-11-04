using System;

namespace Exercício_17
{
    public class Pessoa
    {

        private string nome = "";
        private int idade = 0;
        private string estado = "";
        private string genero = "";

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
