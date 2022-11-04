using Projeto.Controllers;
using Projeto.Models;

namespace Projeto
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            // Logando caso seja professor

            if(txbUsuario.Text == "professor" && txbSenha.Text == "1234")
            {
                TelaProfessor tela = new TelaProfessor();
                tela.Show();

                LimparCampos();
                MostrarBloqueio(false);
                MostrarErro(false);

                return;
            }

            foreach(Aluno aluno in EscolaController.ListaAlunos)
            {
                // Logando caso seja aluno
                if (txbUsuario.Text == aluno.Usuario && txbSenha.Text == aluno.Senha)
                {
                    if(aluno.LoginBloqueado)
                    {
                        MostrarBloqueio(true);
                    }
                    else
                    {
                        TelaAluno tela = new TelaAluno(aluno);
                        tela.Show();

                        LimparCampos();
                        MostrarBloqueio(false);
                        MostrarErro(false);
                        return;
                    }
                }
                // Retornando erro com login inválido
                else if (txbUsuario.Text == aluno.Usuario && txbSenha.Text != aluno.Senha)
                {
                    if(aluno.TentativasLogin >= 2)
                    {
                        MostrarBloqueio(true);
                        aluno.LoginBloqueado = true;
                    }
                    else
                    {
                        aluno.TentativasLogin += 1;
                    }
                }
            }

            LimparCampos();
            MostrarErro(true);

        }

        private void LimparCampos()
        {
            txbUsuario.Text = "";
            txbSenha.Text = "";
        }

        private void MostrarErro(bool boolean)
        {
            lblErro.Visible = boolean;
        }

        private void MostrarBloqueio(bool boolean)
        {
            lblBloqueio.Visible = boolean;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PreSetValoresTeste();
        }

        private void PreSetValoresTeste()
        {

            // Criando Alunos

            Aluno a1 = new Aluno("João", "joao", "123", "M");
            Aluno a2 = new Aluno("Tiago", "tiago", "123", "M");
            Aluno a3 = new Aluno("Joana", "joana", "123", "F");
            Aluno a4 = new Aluno("Guilherme", "guilherme", "123", "M");
            Aluno a5 = new Aluno("Micaela", "micaela", "123", "F");

            EscolaController.ListaAlunos.Add(a1);
            EscolaController.ListaAlunos.Add(a2);
            EscolaController.ListaAlunos.Add(a3);
            EscolaController.ListaAlunos.Add(a4);
            EscolaController.ListaAlunos.Add(a5);

            // Adicionando turmas

            List<Aluno> listaAlunos1 = new List<Aluno>();
            listaAlunos1.Add(a1);
            listaAlunos1.Add(a2);
            listaAlunos1.Add(a3);
            listaAlunos1.Add(a4);

            List<Aluno> listaAlunos2 = new List<Aluno>();
            listaAlunos2.Add(a1);
            listaAlunos2.Add(a2);
            listaAlunos2.Add(a3);

            List<Aluno> listaAlunos3 = new List<Aluno>();
            listaAlunos3.Add(a1);
            listaAlunos3.Add(a2);

            List<Aluno> listaAlunos4 = new List<Aluno>();
            listaAlunos4.Add(a1);


            EscolaController.ListaTurmas.Add(new Models.Turma("Biologia", listaAlunos1));
            EscolaController.ListaTurmas.Add(new Models.Turma("Matemática", listaAlunos2));
            EscolaController.ListaTurmas.Add(new Models.Turma("Português", listaAlunos3));
            EscolaController.ListaTurmas.Add(new Models.Turma("Física", listaAlunos4));

            // Adicionando avaliações

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == "Biologia")
                {
                    turma.Avaliacoes.Add(new Avaliacao("Experimento", turma.Alunos));
                    turma.Avaliacoes.Add(new Avaliacao("Prova Prática", turma.Alunos));
                }
                if (turma.Nome == "Matemática")
                {
                    turma.Avaliacoes.Add(new Avaliacao("Prova 1", turma.Alunos));
                    turma.Avaliacoes.Add(new Avaliacao("Prova 2", turma.Alunos));
                }
                if (turma.Nome == "Português")
                {
                    turma.Avaliacoes.Add(new Avaliacao("Redação", turma.Alunos));
                    turma.Avaliacoes.Add(new Avaliacao("Prova", turma.Alunos));
                }
                if (turma.Nome == "Física")
                {
                    turma.Avaliacoes.Add(new Avaliacao("Prova", turma.Alunos));
                    turma.Avaliacoes.Add(new Avaliacao("Experimento", turma.Alunos));
                }
            }

            // Adicionando notas

            foreach (Turma turma in EscolaController.ListaTurmas)
            {

                foreach (Avaliacao av in turma.Avaliacoes)
                {

                    for (int i = 0; i < turma.Alunos.Count; i++)
                    {

                        Random random = new Random();

                        av.MatrizAlunoNota[i, 0] = turma.Alunos[i].Nome;
                        av.MatrizAlunoNota[i, 1] = Convert.ToString(random.Next(0, 10));
                    }
                }
            }

        }
    }
}