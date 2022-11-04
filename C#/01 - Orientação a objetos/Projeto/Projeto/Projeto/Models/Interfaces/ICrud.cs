using System;

namespace Projeto.Interfaces
{
    internal interface ICrud
    {

        void Cadastrar(string NomeEmpresa);

        void Listar();

        void Alterar(string NomeEmpresa);

        void Deletar(string NomeEmpresa);

    }
}
