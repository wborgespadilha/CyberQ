using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto.Models;
using Projeto.Controllers;

namespace Projeto
{
    public partial class TelaAluno : Form
    {

        Aluno aluno;

        public TelaAluno(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            FormatarColunas();
            CarregarTurmas();

            // Colocando o nome do aluno nas boas vindas
            lblAluno.Text += this.aluno.Nome;

        }

        private void FormatarColunas()
        {
            for (int i = 0; i < dgvAvaliacoes.ColumnCount; i++)
            {
                dgvAvaliacoes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < dgvTurmas.ColumnCount; i++)
            {
                dgvTurmas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarListaAvaliacoes();
        }

        private void dgvAvaliacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarNota();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CarregarTurmas()
        {
            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                foreach (Aluno aluno in turma.Alunos)
                {
                    if (aluno == this.aluno)
                    {
                        dgvTurmas.Rows.Add(turma.Nome);
                    }
                }
            }
        }

        private void AtualizarListaAvaliacoes()
        {
            int indiceLinha = dgvTurmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionada = dgvTurmas.Rows[indiceLinha];

            string turmaSelecionada = Convert.ToString(linhaSelecionada.Cells["Turma"].Value);

            dgvAvaliacoes.Rows.Clear();

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == turmaSelecionada)
                {
                    foreach (Avaliacao avaliacao in turma.Avaliacoes)
                    {
                        dgvAvaliacoes.Rows.Add(avaliacao.Nome);
                    }
                }
            }
        }

        private void MostrarNota()
        {
            int indiceLinha = dgvTurmas.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaTurma = dgvTurmas.Rows[indiceLinha];

            int indiceLinhaAV = dgvAvaliacoes.CurrentCell.RowIndex;
            DataGridViewRow linhaSelecionadaAvaliacao = dgvAvaliacoes.Rows[indiceLinhaAV];

            string turmaSelecionada = Convert.ToString(linhaSelecionadaTurma.Cells["Turma"].Value);
            string avaliacaoSelecionada = Convert.ToString(linhaSelecionadaAvaliacao.Cells["Avaliacao"].Value);

            foreach (Turma turma in EscolaController.ListaTurmas)
            {
                if (turma.Nome == turmaSelecionada)
                {
                    foreach (Avaliacao avaliacao in turma.Avaliacoes)
                    {
                        if (avaliacao.Nome == avaliacaoSelecionada)
                        {
                            txbNota.Text = avaliacao.PegarNotaPorNome(this.aluno.Nome);
                        }
                    }
                }
            }
        }

    }
}
