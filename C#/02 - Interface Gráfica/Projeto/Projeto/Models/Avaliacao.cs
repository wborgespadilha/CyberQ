using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Avaliacao
    {

        private string nome = "";
        private string[,] matrizAlunoNota = new string[50, 2];

        public Avaliacao(string nome, List<Aluno> alunos)
        {
            Nome = nome;
            MatrizAlunoNota = matrizAlunoNota;

            for (int i = 0; i < alunos.Count; i++)
            {
                matrizAlunoNota[i, 0] = alunos[i].Nome;
                matrizAlunoNota[i, 1] = "0";
            }
        }

        public string Nome { get => nome; set => nome = value; }
        public string[,] MatrizAlunoNota { get => matrizAlunoNota; set => matrizAlunoNota = value; }

        public string PegarNotaPorNome(string nome)
        {

            for(int i = 0; i < matrizAlunoNota.GetLength(0); i++)
            {
                if(matrizAlunoNota[i, 0] == nome)
                {
                    return matrizAlunoNota[i, 1];
                }
            }
            return "N/A";
        }

    }
}
