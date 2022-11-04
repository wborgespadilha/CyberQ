using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Aluno
    {

        private string nome = "";
        private string usuario = "";
        private string senha = "";
        private string genero = "";
        private int tentativasLogin = 0;
        private bool loginBloqueado = false;
        public Aluno(string nome, string usuario, string senha, string genero)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            Genero = genero;
        }

        public Aluno()
        {
            Nome = "";
            Usuario = "";
            Senha = "";
            Genero = "";
        }

        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Genero { get => genero; set => genero = value; }
        public int TentativasLogin { get => tentativasLogin; set => tentativasLogin = value; }
        public bool LoginBloqueado { get => loginBloqueado; set => loginBloqueado = value; }
    }
}
