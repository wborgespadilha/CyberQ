using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto.Controllers;
using Projeto.Models;

namespace Projeto
{
    public partial class TelaProfessor : Form
    {

        List<Aluno> listaAntigosValores = new List<Aluno>();

        // Métodos gerais

        public TelaProfessor()
        {
            InitializeComponent();
        }

        private void TelaProfessor_Load(object sender, EventArgs e)
        {
            FormatarColunas();
            CarregarListaAlunos();
            CarregarListasTurmas();
            AtualizarEstatisticas();
        }

        private void FormatarColunas()
        {

            // Ajeita as colunas de todos os dataGridView, resize

            for (int i = 0; i < dgvAL_Alunos.ColumnCount; i++)
            {
                dgvAL_Alunos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvAV_Alunos.ColumnCount; i++)
            {
                dgvAV_Alunos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvTU_Alunos.ColumnCount; i++)
            {
                dgvTU_Alunos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvAV_Avaliacoes.ColumnCount; i++)
            {
                dgvAV_Avaliacoes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvTU_Turmas.ColumnCount; i++)
            {
                dgvTU_Turmas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvAV_Turmas.ColumnCount; i++)
            {
                dgvAV_Turmas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvEST_Turmas.ColumnCount; i++)
            {
                dgvEST_Turmas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void CarregarListaAlunos()
        {
            AtualizarAL_Alunos();
            AtualizarTU_Alunos();
        }

        private void CarregarListasTurmas()
        {
            CarregarAV_Turmas();
            CarregarTU_Turmas();
        }

        //Métodos aba ALUNOS

        private void AtualizarAL_Alunos()
        {
            dgvAL_Alunos.Rows.Clear();
            listaAntigosValores.Clear();

            foreach (Aluno aluno in EscolaController.ListaAlunos)
            {
                listaAntigosValores.Add(aluno);

                dgvAL_Alunos.Rows.Add(new object[]
                {
                    aluno.Nome,
                    aluno.Genero,
                    aluno.LoginBloqueado == true ? "Bloqueado":"Desbloqueado",
                });

            }
        }

        // Métodos aba TURMAS

        private void AtualizarTU_Alunos()
        {

            //Se não há turma selecionada apenas limpa

            if (dgvTU_Turmas.CurrentCell == null)
            {
                dgvTU_Alunos.Rows.Clear();
            }
            else
            {

                // Senão, pega o nome da turma selecionada

                int indiceLinha = dgvTU_Turmas.CurrentCell.RowIndex;
                DataGridViewRow linhaSelecionada = dgvTU_Turmas.Rows[indiceLinha];

                string nome = Convert.ToString(linhaSelecionada.Cells["Turmas"].Value);

                // Limpa a tabela de alunos

                dgvTU_Alunos.Rows.Clear();

                // Adiciona alunos de acordo com a turma selecionada

                foreach (Turma turma in EscolaController.ListaTurmas)
                {
                    if (turma.Nome == nome)
                    {
                        foreach (Aluno aluno in turma.Alunos)
                        {
                            dgvTU_Alunos.Rows.Add(aluno.Nome);
                        }
                    }
                }
            }
        }

        private void CarregarTU_Turmas()
        {

            // Apenas limpa a tabela e adiciona de acordo com a lista geral

            dgvTU_Turmas.Rows.Clear();

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                dgvTU_Turmas.Rows.Add(turma.Nome);
            }
        }

        private void AtualizarTU_Turmas()
        {

            // Se não há turma selecionada apenas limpa

            if (dgvTU_Turmas.CurrentCell == null)
            {
                dgvTU_Turmas.Rows.Clear();
            }
            else
            {

                // Senão apenas limpa a tabela e adiciona de acordo com a lista geral

                dgvTU_Turmas.Rows.Clear();

                foreach (Turma turma in EscolaController.ListaTurmas)
                {
                    dgvTU_Turmas.Rows.Add(turma.Nome);
                }
            }
        }

        // Métodos aba AVALIAÇÕES

        private void CarregarAV_Turmas()
        {

            // Apenas limpa a tabela de turmas e adiciona de acordo com a lista geral

            dgvAV_Turmas.Rows.Clear();

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                dgvAV_Turmas.Rows.Add(turma.Nome);
            }
        }

        private void CarregarAV_Alunos()
        {

            // Se não há turma selecionada apenas limpa

            if (dgvAV_Turmas.CurrentCell == null)
            {
                dgvAV_Turmas.Rows.Clear();
            }
            else
            {

                // Senão pega o nome da turma selecionada

                int indiceLinha = dgvAV_Turmas.CurrentCell.RowIndex;
                DataGridViewRow linhaSelecionada = dgvAV_Turmas.Rows[indiceLinha];

                string nome = Convert.ToString(linhaSelecionada.Cells["TurmasAV"].Value);

                bool semAlunos = false;
                string nomeAV = "";

                // Pega a avaliação selecionada ou põe flag que não foi selecionada

                if (dgvAV_Avaliacoes.CurrentCell != null)
                {
                    int indiceLinhaAV = dgvAV_Avaliacoes.CurrentCell.RowIndex;
                    DataGridViewRow linhaSelecionadaAV = dgvAV_Avaliacoes.Rows[indiceLinhaAV];
                    nomeAV = Convert.ToString(linhaSelecionadaAV.Cells["Avaliacoes"].Value);
                }
                else
                {
                    semAlunos = true;
                }


                dgvAV_Alunos.Rows.Clear();

                // Pega a avaliação de acordo com a turma selecionada

                foreach (Turma turma in EscolaController.ListaTurmas)
                {
                    if (turma.Nome == nome)
                    {
                        
                        Avaliacao av = new Avaliacao("", new List<Aluno>());

                        foreach (Avaliacao avaliacao in turma.Avaliacoes)
                        {
                            if (avaliacao.Nome == nomeAV)
                            {
                                av = avaliacao;
                                break;
                            }
                        }

                        // Adiciona o aluno e a nota se uma avaliação foi selecionada

                        if (semAlunos == false)
                        {
                            foreach (Aluno aluno in turma.Alunos)
                            {
                                dgvAV_Alunos.Rows.Add(aluno.Nome, av.PegarNotaPorNome(aluno.Nome));
                            }
                        }
                    }
                }
            }
        }

        private void CarregarAV_Avaliacoes()
        {

            // Se não há turma selecionada apenas limpa

            if (dgvAV_Turmas.CurrentCell == null)
            {
                dgvAV_Avaliacoes.Rows.Clear();
            }
            else
            {
                // Senão apenas pega a turma selecionada

                int indiceLinha = dgvAV_Turmas.CurrentCell.RowIndex;
                DataGridViewRow linhaSelecionada = dgvAV_Turmas.Rows[indiceLinha];

                string nome = Convert.ToString(linhaSelecionada.Cells["TurmasAV"].Value);

                // Limpa a tabela

                dgvAV_Avaliacoes.Rows.Clear();

                // E adiciona as avaliações de acordo com a turma selecionada

                for (int i = 0; i < EscolaController.ListaTurmas.Count; i++)
                {
                    Turma turma = EscolaController.ListaTurmas[i];

                    if (turma.Nome == nome)
                    {
                        foreach (Avaliacao av in turma.Avaliacoes)
                        {
                            dgvAV_Avaliacoes.Rows.Add(av.Nome);
                        }
                    }
                }
            }
        }

        // Método estatística

        private void AtualizarEstatisticas()
        {

            // Pegando e atualizando o número de homens e mulheres

            int machos = 0;
            int femeas = 0;

            foreach (Aluno aluno in EscolaController.ListaAlunos)
            {
                if (aluno.Genero == "M")
                {
                    machos++;
                }
                else
                {
                    femeas++;
                }
            }

            txbEST_Machos.Text = machos.ToString();
            txbEST_Femeas.Text = femeas.ToString();

            lbxEST_MediasAvaliacoes.Items.Clear();

            // Pegando e adicionando a média de cada avaliação de cada matéria

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                lbxEST_MediasAvaliacoes.Items.Add($"Turma: {turma.Nome}");

                foreach (Avaliacao av in turma.Avaliacoes)
                {
                    double qntdNotas = 0;
                    double media = 0;

                    for (int i = 0; i < av.MatrizAlunoNota.GetLength(0); i++)
                    {
                        if (av.MatrizAlunoNota[i, 0] != "" && av.MatrizAlunoNota[i, 0] != "N/A" && av.MatrizAlunoNota[i, 0] != null)
                        {
                            media += Convert.ToDouble(av.MatrizAlunoNota[i, 1]);
                            qntdNotas++;
                        }
                    }
                    media = media / qntdNotas;

                    lbxEST_MediasAvaliacoes.Items.Add($"Avaliação: {av.Nome} - Média: {media:F2}");
                }
                lbxEST_MediasAvaliacoes.Items.Add("");
            }

            // Pegando e colocando a quantidade e porcentagem de aprovados por turma

            dgvEST_Turmas.Rows.Clear();

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                string[,] medias = new string[50,2];

                foreach (Avaliacao av in turma.Avaliacoes)
                {
                    for (int i = 0; i < av.MatrizAlunoNota.GetLength(0); i++)
                    {

                        if (av.MatrizAlunoNota[i,0] != "" && av.MatrizAlunoNota[i, 0] != null)
                        {

                            bool alunoEncontrado = false;

                            for (int j = 0; j < medias.GetLength(0); j++)
                            {
                                if (medias[j, 0] == av.MatrizAlunoNota[i, 0])
                                {
                                    medias[j, 1] = Convert.ToString(Convert.ToDouble(medias[j,1]) + Convert.ToDouble(av.MatrizAlunoNota[i, 1]));
                                    alunoEncontrado = true;
                                    break;
                                }
                            }

                            if(alunoEncontrado == false)
                            {
                                for(int j = 0; j < medias.GetLength(0); j++)
                                {
                                    if (medias[j, 0] == "" || medias[j, 0] == null)
                                    {
                                        medias[j, 0] = av.MatrizAlunoNota[i, 0];
                                        medias[j, 1] = Convert.ToString(Convert.ToDouble(medias[j, 1]) + Convert.ToDouble(av.MatrizAlunoNota[i, 1]));
                                        break;
                                    }
                                }
                            }

                        } 
                    }
                }

                double aprovados = 0;
                double reprovados = 0;
                double totalAlunos = turma.Alunos.Count;

                for (int i = 0; i < medias.GetLength(0); i++)
                {
                    if(medias[i,0] != "" && medias[i,0] != null)
                    {

                        double tempMedia = Convert.ToDouble(medias[i, 1]) / turma.Avaliacoes.Count;

                        medias[i,1] = Convert.ToString(tempMedia);

                        if (Convert.ToDouble(medias[i,1]) >= 7)
                        {
                            aprovados++;
                        }
                        else
                        {
                            reprovados++;
                        }
                    }
                }

                double porcentagemAprovados = aprovados / totalAlunos;
                double porcentagemReprovados = reprovados / totalAlunos;

                dgvEST_Turmas.Rows.Add(turma.Nome, $"{aprovados} - {porcentagemAprovados:P2}", $"{reprovados} - {porcentagemReprovados:P2}");

            }
        }

        //Aba ALUNOS

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {

            // Validações

            if (txbAL_Nome.Text == "")
            {
                MessageBox.Show("Você deve inserir o nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbAL_Usuario.Text == "")
            {
                MessageBox.Show("Você deve inserir o usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbAL_Senha.Text == "")
            {
                MessageBox.Show("Você deve inserir a senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((cbxAL_Macho.Checked == true && cbxAL_Femea.Checked == true) || (cbxAL_Macho.Checked == false && cbxAL_Femea.Checked == false))
            {
                MessageBox.Show("Selecione corretamente o gênero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criação de aluno conforme inserções

            string nome = txbAL_Nome.Text;
            string usuario = txbAL_Usuario.Text;
            string senha = txbAL_Senha.Text;
            string genero = cbxAL_Femea.Checked == true ? "F" : "M";

            Aluno novoAluno = new Aluno(nome, usuario, senha, genero);

            // Validação de aluno já cadastrado

            foreach (Aluno aluno in EscolaController.ListaAlunos)
            {
                if (aluno.Nome == nome || aluno.Usuario == usuario)
                {
                    MessageBox.Show("Esse ou usuário já foi cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            EscolaController.ListaAlunos.Add(novoAluno);

            CarregarListaAlunos();
            AtualizarEstatisticas();
        }

        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {
            // Pega o aluno selecionado

            int indiceLinha = dgvAL_Alunos.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvAL_Alunos.Rows[indiceLinha];

            string nome = Convert.ToString(linhaSelecionada.Cells["Aluno"].Value);
            string genero = Convert.ToString(linhaSelecionada.Cells["Genero"].Value);

            // Remove aluno da lista geral de alunos

            foreach (Aluno aluno in EscolaController.ListaAlunos)
            {
                if (aluno.Nome == nome && aluno.Genero == genero)
                {
                    EscolaController.ListaAlunos.Remove(aluno);
                    break;
                }
            }

            CarregarListaAlunos();

            // Remove aluno das turmas

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                foreach(Aluno aluno in turma.Alunos)
                {
                    if(aluno.Nome == nome)
                    {
                        turma.Alunos.Remove(aluno);
                        break;
                    }
                }
            }

            AtualizarTU_Alunos();
            AtualizarEstatisticas();
        }

        private void btnDesbloquearAluno_Click(object sender, EventArgs e)
        {

            // Pega o aluno selecionado

            int indiceLinha = dgvAL_Alunos.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvAL_Alunos.Rows[indiceLinha];

            string nome = Convert.ToString(linhaSelecionada.Cells["Aluno"].Value);
            string genero = Convert.ToString(linhaSelecionada.Cells["Genero"].Value);

            // Percorre a lista geral de alunos e desbloqueia o aluno selecionado

            for(int i = 0; i < EscolaController.ListaAlunos.Count; i++)
            {
                Aluno aluno = EscolaController.ListaAlunos[i];
                if (aluno.Nome == nome && aluno.Genero == genero)
                {
                    EscolaController.ListaAlunos[i].LoginBloqueado = false;
                    break;
                }
            }

            CarregarListaAlunos();

        }

        private void btnSalvarAlunos_Click(object sender, EventArgs e)
        {

            // Salva os valores numa lista temporária

            for (int i = 0; i < listaAntigosValores.Count; i++)
            {
                DataGridViewRow linhaSelecionada = dgvAL_Alunos.Rows[i];

                string nome = Convert.ToString(linhaSelecionada.Cells["Aluno"].Value);
                string genero = Convert.ToString(linhaSelecionada.Cells["Genero"].Value);
                
                listaAntigosValores[i].Nome = nome;
                listaAntigosValores[i].Genero = genero;
            }

            // Limpa a lista geral de alunos

            EscolaController.ListaAlunos.Clear();

            // Refaz a lista geral de alunos a partir da lista temporária

            foreach(Aluno aluno in listaAntigosValores)
            {
                EscolaController.ListaAlunos.Add(aluno);
            }

            // Altera o nome dos alunos em cada avaliação

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                foreach (Avaliacao av in turma.Avaliacoes)
                {
                    for (int i = 0; i < turma.Alunos.Count; i++)
                    {
                        av.MatrizAlunoNota[i, 0] = turma.Alunos[i].Nome;

                    }
                }
            }

            CarregarListaAlunos();
            AtualizarTU_Alunos();
            AtualizarEstatisticas();
        }

        private void dgvAvaliacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarAV_Alunos();
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarTU_Alunos();
        }

        //Aba TURMAS

        private void btnTU_DeletarTurma_Click(object sender, EventArgs e)
        {
            // Pega a turma selecionada

            int indiceLinha = dgvTU_Turmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvTU_Turmas.Rows[indiceLinha];

            string turmaSelecionada = Convert.ToString(linhaSelecionada.Cells["Turmas"].Value);

            // Remove a turma da lista geral de turmas

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if(turma.Nome == turmaSelecionada)
                {
                    EscolaController.ListaTurmas.Remove(turma);
                    break;
                }
            }
            AtualizarTU_Alunos();
            AtualizarTU_Turmas();
            AtualizarEstatisticas();

        }

        private void btnTU_DeletarAluno_Click(object sender, EventArgs e)
        {

            // Pega a turma e o aluno selecionado
            
            int indiceLinhaTU = dgvTU_Turmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaTU = dgvTU_Turmas.Rows[indiceLinhaTU];

            string turmaSelecionada = Convert.ToString(linhaSelecionadaTU.Cells["Turmas"].Value);

            int indiceLinha = dgvTU_Alunos.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvTU_Alunos.Rows[indiceLinha];

            string alunoSelecionado = Convert.ToString(linhaSelecionada.Cells["Alunos"].Value);

            // Remove o aluno da turma selecionada

            foreach(Turma turma in EscolaController.ListaTurmas)
            {
                if(turma.Nome == turmaSelecionada)
                {
                    foreach(Aluno aluno in turma.Alunos)
                    {
                        if(aluno.Nome == alunoSelecionado)
                        {
                            turma.Alunos.Remove(aluno);
                            break;
                        }
                    }
                    break;
                }
            }

            AtualizarTU_Alunos();
            CarregarListaAlunos();
            AtualizarEstatisticas();
        }

        private void btnTU_AdicionarAluno_Click(object sender, EventArgs e)
        {

            Aluno alunoASerAdicionado = new Aluno();

            // Pega a turma selecionada

            int indiceLinhaTU = dgvTU_Turmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaTU = dgvTU_Turmas.Rows[indiceLinhaTU];

            string turmaSelecionada = Convert.ToString(linhaSelecionadaTU.Cells["Turmas"].Value);

            // Verifica se o aluno existe, caso exista faz a cópia para adicionar na turma

            bool alunoEncontrado = false;

            foreach(Aluno aluno in EscolaController.ListaAlunos)
            {
                if(aluno.Nome == txbTU_AdicionarAluno.Text)
                {
                    alunoASerAdicionado = aluno;
                    alunoEncontrado = true;
                }
            }

            if(alunoEncontrado == false)
            {
                MessageBox.Show("Esse aluno não existe!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // Verifica se o aluno já está na turma. Senão, adiciona na turma.

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == turmaSelecionada)
                {

                    foreach(Aluno aluno in turma.Alunos)
                    {
                        if(aluno == alunoASerAdicionado)
                        {
                            MessageBox.Show("Esse aluno já está na turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    turma.Alunos.Add(alunoASerAdicionado);
                }
            }
            AtualizarTU_Alunos();
            AtualizarEstatisticas();
        }

        private void btnTU_AdicionarTurma_Click(object sender, EventArgs e)
        {

            // Validações

            string turmaASerInserida = txbTU_NovaTurma.Text;

            if(turmaASerInserida == "")
            {
                MessageBox.Show("Você deve inserir o nome da turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == txbTU_NovaTurma.Text)
                {
                    MessageBox.Show("Essa turma já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Cria nova turma e adiciona

            Turma novaTurma = new Turma(turmaASerInserida, new List<Aluno>());

            EscolaController.ListaTurmas.Add(novaTurma);

            AtualizarTU_Turmas();
            AtualizarTU_Alunos();
            CarregarAV_Turmas();

            // Colocando a seleção da tabela de turma para o último elemento 
            int indiceLinha = dgvTU_Turmas.Rows.Count - 1;
            dgvTU_Turmas.CurrentCell = dgvTU_Turmas.Rows[indiceLinha].Cells[0];
            // Recarregando a tabela de alunos
            AtualizarTU_Alunos();

            AtualizarEstatisticas();
        }

        private void btnTU_AlterarTurma_Click(object sender, EventArgs e)
        {

            // Pegando a turma selecionada

            int indiceLinhaTU = dgvTU_Turmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaTU = dgvTU_Turmas.Rows[indiceLinhaTU];

            string turmaSelecionada = Convert.ToString(linhaSelecionadaTU.Cells["Turmas"].Value);

            // Validando a entrada

            if(txbTU_AlterarTurma.Text == "")
            {
                MessageBox.Show("Você deve inserir o novo nome!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // Alterando a turma na lista geral

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == turmaSelecionada)
                {
                    turma.Nome = txbTU_AlterarTurma.Text;
                }
            }
            AtualizarTU_Turmas();
            AtualizarTU_Alunos();
            CarregarAV_Turmas();
            AtualizarEstatisticas();
        }

        //Aba AVALIAÇÕES

        private void dgvAV_Turmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarAV_Avaliacoes();
            CarregarAV_Alunos();
        }

        private void btnAV_AdicionarAvaliacao_Click(object sender, EventArgs e)
        {

            // Valida seleção de turma

            if (dgvAV_Turmas.CurrentCell == null)
            {
                MessageBox.Show("Você deve selecionar uma turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                // Pega a turma selecionada

                int indiceLinha = dgvAV_Turmas.CurrentCell.RowIndex;
                DataGridViewRow linhaSelecionada = dgvAV_Turmas.Rows[indiceLinha];

                string turmaSelecionada = Convert.ToString(linhaSelecionada.Cells["TurmasAV"].Value);

                // Cria uma avaliação na turma selecionada com nome random

                foreach (Turma turma in EscolaController.ListaTurmas)
                {
                    if (turma.Nome == turmaSelecionada)
                    {
                        Random random = new Random();
                        int num = random.Next(0, 90000);
                        turma.Avaliacoes.Add(new Avaliacao("AV" + num, turma.Alunos));
                    }
                }

                CarregarAV_Avaliacoes();
                AtualizarEstatisticas();
            }
        }

        private void btnAV_RemoverAvaliacao_Click(object sender, EventArgs e)
        {

            // Validações de seleção

            if (dgvAV_Turmas.CurrentCell == null)
            {
                MessageBox.Show("Você deve selecionar uma turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvAV_Avaliacoes.CurrentCell == null)
            {
                MessageBox.Show("Você deve selecionar uma avaliação!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Pega a turma e a avaliação selecionada

                int indiceLinha = dgvAV_Turmas.CurrentCell.RowIndex;
                DataGridViewRow linhaSelecionada = dgvAV_Turmas.Rows[indiceLinha];

                string turmaSelecionada = Convert.ToString(linhaSelecionada.Cells["TurmasAV"].Value);

                int indiceLinhaAV = dgvAV_Avaliacoes.CurrentCell.RowIndex;
                DataGridViewRow linhaSelecionadaAV = dgvAV_Avaliacoes.Rows[indiceLinhaAV];

                string avaliacaoSelecionada = Convert.ToString(linhaSelecionadaAV.Cells["Avaliacoes"].Value);

                // Limpa a lista de avaliações

                dgvAV_Avaliacoes.Rows.Clear();

                // Remove a avaliação de acordo com a turma selecionada

                foreach (Turma turma in EscolaController.ListaTurmas)
                {
                    if (turma.Nome == turmaSelecionada)
                    {
                        foreach (Avaliacao av in turma.Avaliacoes)
                        {
                            if(av.Nome == avaliacaoSelecionada)
                            {
                                turma.Avaliacoes.Remove(av);
                                break;
                            }
                        }
                    }
                }

                CarregarAV_Avaliacoes();
                CarregarAV_Alunos();
                AtualizarEstatisticas();

            }
        }

        private void btnAV_RenomearAvaliacao_Click(object sender, EventArgs e)
        {

            // Validação de seleção

            if (dgvAV_Avaliacoes.CurrentCell == null)
            {
                MessageBox.Show("Você deve selecionar uma avaliação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbAV_Renomear.Text == "")
            {
                MessageBox.Show("Você deve inserir um novo nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pega o a turma e a avaliação selecionada

            int indiceLinha = dgvAV_Turmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvAV_Turmas.Rows[indiceLinha];

            string nome = Convert.ToString(linhaSelecionada.Cells["TurmasAV"].Value);

            int indiceLinhaAV = dgvAV_Avaliacoes.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaAV = dgvAV_Avaliacoes.Rows[indiceLinhaAV];

            string nomeAV = Convert.ToString(linhaSelecionadaAV.Cells["Avaliacoes"].Value);

            // Renomeia a avaliação de acordo com a turma selecionada

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == nome)
                {

                    // Verifica se já existe avaliação com mesmo nome

                    int ocorrencias = 0;

                    foreach (Avaliacao av in turma.Avaliacoes)
                    {
                        if (av.Nome == txbAV_Renomear.Text)
                        {
                            ocorrencias++;
                        }
                    }

                    if(ocorrencias > 0)
                    {
                        MessageBox.Show("Já existe uma avaliação com esse nome!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (Avaliacao av in turma.Avaliacoes)
                    {
                        if (av.Nome == nomeAV)
                        {
                            av.Nome = txbAV_Renomear.Text;
                            break;
                        }
                    }
                }
            }

            CarregarAV_Avaliacoes();
            CarregarAV_Alunos();
            AtualizarEstatisticas();
        }

        private void btnAV_SalvarNotas_Click(object sender, EventArgs e)
        {

            // Validação de seleção

            if (dgvAV_Turmas.CurrentCell == null)
            {
                MessageBox.Show("Você deve selecionar uma turma!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvAV_Avaliacoes.CurrentCell == null)
            {
                MessageBox.Show("Você deve selecionar uma avaliação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pega a turma e a avaliação selecionada

            int indiceLinha = dgvAV_Turmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvAV_Turmas.Rows[indiceLinha];

            string turmaSelecionada = Convert.ToString(linhaSelecionada.Cells["TurmasAV"].Value);

            int indiceLinhaAV = dgvAV_Avaliacoes.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaAV = dgvAV_Avaliacoes.Rows[indiceLinhaAV];

            string avaliacaoSelecionada = Convert.ToString(linhaSelecionadaAV.Cells["Avaliacoes"].Value);

            // Reescreve a matriz de notas de acordo com os valores inseridos

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == turmaSelecionada)
                {
                    foreach (Avaliacao av in turma.Avaliacoes)
                    {
                        if (av.Nome == avaliacaoSelecionada)
                        {
                            for (int i = 0; i < dgvAV_Alunos.Rows.Count; i++)
                            {
                                DataGridViewRow linhaSelecionadaAluno = dgvAV_Alunos.Rows[i];
                                int nota = Convert.ToInt32(linhaSelecionadaAluno.Cells["Nota"].Value);

                                string aluno = Convert.ToString(linhaSelecionadaAluno.Cells["AlunosAV"].Value);

                                av.MatrizAlunoNota[i, 0] = aluno;
                                av.MatrizAlunoNota[i, 1] = nota.ToString();
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Notas salvas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarAV_Avaliacoes();
            CarregarAV_Alunos();
            AtualizarEstatisticas();
        }
    }
}
