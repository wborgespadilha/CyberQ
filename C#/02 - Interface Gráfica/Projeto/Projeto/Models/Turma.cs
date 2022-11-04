using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Models;

namespace Projeto.Models
{
    public class Turma
    {
        private string nome = "";
        private List<Aluno> alunos = new List<Aluno>();
        private List<Avaliacao> avaliacoes = new List<Avaliacao>();

        public Turma(string nome, List<Aluno> alunos)
        {
            Nome = nome;
            Alunos = alunos;
        }

        public List<Aluno> Alunos { get => alunos; set => alunos = value; }
        public List<Avaliacao> Avaliacoes { get => avaliacoes; set => avaliacoes = value; }
        public string Nome { get => nome; set => nome = value; }

    }
}
