using System;

namespace Exercício_02
{
    internal class Extrato
    {

        private int _Id = -1;
        private string _Tipo = "";
        private double _Valor = 0;
        private bool _ContaCorrente = false;

        public int Id { get => _Id; set => _Id = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public double Valor { get => _Valor; set => _Valor = value; }
        public bool ContaCorrente { get => _ContaCorrente; set => _ContaCorrente = value; }
    }
}
