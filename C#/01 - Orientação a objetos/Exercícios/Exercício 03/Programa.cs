using System;

namespace Exercício_03
{
    internal class Programa
    {

        List<Aluno> listaAlunos = new List<Aluno>();

        public void Iniciar()
        {
            bool continuar = true;

            do
            {
                try
                {

                    Console.WriteLine("1 - Cadastrar\n2 - Terminar os cadastros");
                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:
                            Cadastrar();
                            break;

                        case 2:
                            continuar = false;
                            MostrarEstatisticas();
                            break;

                        default:
                            Console.WriteLine("Insira números inteiros de 1 a 2!");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira números inteiros de 1 a 2!");
                    Console.WriteLine();
                }

            }
            while (continuar);

        }

        private void Cadastrar()
        {
            try
            {
                Aluno aluno = new Aluno();

                Console.Clear();
                Console.WriteLine("Insira o nome do aluno");
                string nome = Console.ReadLine();

                aluno.Nome = nome;

                Console.WriteLine("Insira a primeira nota");
                double primeiraNota = Convert.ToDouble(Console.ReadLine());

                if(primeiraNota < 0 || primeiraNota > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Nota inválida");
                    Console.WriteLine();
                    return;
                }

                aluno.Nota1 = primeiraNota;

                Console.WriteLine("Insira a segunda nota");
                double segundaNota = Convert.ToDouble(Console.ReadLine());

                if(segundaNota < 0 || segundaNota > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Nota inválida");
                    Console.WriteLine();
                    return;
                }

                aluno.Nota2 = segundaNota;

                double media = (primeiraNota + segundaNota) / 2;

                aluno.Media = media;

                if (media >= 7)
                {
                    Console.Clear();
                    Console.WriteLine("Aprovado");
                    aluno.Situacao = "Aprovado";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Reprovado");
                    aluno.Situacao = "Reprovado";
                }

                listaAlunos.Add(aluno);

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Digite apenas números nas notas");
                Console.WriteLine();
            }
        }

        private void MostrarEstatisticas()
        {
            int aprovados = 0;
            int reprovados = 0;

            double somaMedias = 0;
            double maiorMedia = 0;

            Console.Clear();
            Console.WriteLine("Alunos cadastrados: " + listaAlunos.Count);

            foreach(Aluno aluno in listaAlunos)
            {
                if(aluno.Situacao == "Aprovado")
                {
                    aprovados++;
                }
                else
                {
                    reprovados++;
                }

                somaMedias += aluno.Media;

                if(aluno.Media > maiorMedia)
                {
                    maiorMedia = aluno.Media;
                }
            }

            Console.WriteLine("Alunos aprovados: " + aprovados);
            Console.WriteLine("Alunos reprovados: " + reprovados);

            double mediaGeral = somaMedias / listaAlunos.Count;

            Console.WriteLine("Média geral: " + mediaGeral);

            Console.WriteLine("Alunos com a maiores médias:");

            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Media >= maiorMedia)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}, Nota 1: {aluno.Nota1}, Nota 2: {aluno.Nota2}, Média: {aluno.Media}, Situação: {aluno.Situacao}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Lista de alunos:");

            List<Aluno> listaAlunosOrdenada = listaAlunos.OrderByDescending(x => x.Media).ToList();

            foreach (Aluno aluno in listaAlunosOrdenada)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Nota 1: {aluno.Nota1}, Nota 2: {aluno.Nota2}, Média: {aluno.Media}, Situação: {aluno.Situacao}");
            }

        }

    }
}
