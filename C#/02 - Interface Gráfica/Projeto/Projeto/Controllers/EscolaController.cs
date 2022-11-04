using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Models;

namespace Projeto.Controllers
{
    public class EscolaController
    {

        private static List<Aluno> listaAlunos = new List<Aluno>();
        private static List<Turma> listaTurmas = new List<Turma>();

        public static List<Aluno> ListaAlunos { get => listaAlunos; set => listaAlunos = value; }
        public static List<Turma> ListaTurmas { get => listaTurmas; set => listaTurmas = value; }

    }
}
