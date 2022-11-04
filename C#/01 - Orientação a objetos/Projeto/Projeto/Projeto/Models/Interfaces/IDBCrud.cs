using Projeto.Models;
using System;

namespace Projeto.Interfaces
{
    internal interface IDBCrud
    {
        void GravarBancoDeDados(List<Funcionario> listaFuncionarios);
        List<Funcionario> CarregarBancoDeDados(List<Funcionario> listaFuncionarios);
        void DeletarBancoDeDados();

    }
}
