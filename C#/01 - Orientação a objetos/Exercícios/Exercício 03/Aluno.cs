using System;

namespace Exercício_03
{
    internal class Aluno
    {

        private string _Nome = "";
        private double _Nota1 = 0;
        private double _Nota2 = 0;
        private double _Media = 0;
        private string _Situacao = "";

        public string Nome { get => _Nome; set => _Nome = value; }
        public double Nota1 { get => _Nota1; set => _Nota1 = value; }
        public double Nota2 { get => _Nota2; set => _Nota2 = value; }
        public string Situacao { get => _Situacao; set => _Situacao = value; }
        public double Media { get => _Media; set => _Media = value; }
    }
}
