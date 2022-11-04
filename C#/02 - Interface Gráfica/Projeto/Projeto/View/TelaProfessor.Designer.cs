namespace Projeto
{
    partial class TelaProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpAlunos = new System.Windows.Forms.TabPage();
            this.lblAL_OBS = new System.Windows.Forms.Label();
            this.btnAL_SalvarAlunos = new System.Windows.Forms.Button();
            this.btnAL_DesbloquearAluno = new System.Windows.Forms.Button();
            this.btnAL_RemoverAluno = new System.Windows.Forms.Button();
            this.btnAL_CadastrarAluno = new System.Windows.Forms.Button();
            this.lblAL_Senha = new System.Windows.Forms.Label();
            this.lblAL_Usuario = new System.Windows.Forms.Label();
            this.lblAL_Genero = new System.Windows.Forms.Label();
            this.cbxAL_Femea = new System.Windows.Forms.CheckBox();
            this.cbxAL_Macho = new System.Windows.Forms.CheckBox();
            this.txbAL_Senha = new System.Windows.Forms.TextBox();
            this.txbAL_Usuario = new System.Windows.Forms.TextBox();
            this.lblAL_NomeAluno = new System.Windows.Forms.Label();
            this.txbAL_Nome = new System.Windows.Forms.TextBox();
            this.lblAdicionarAluno = new System.Windows.Forms.Label();
            this.dgvAL_Alunos = new System.Windows.Forms.DataGridView();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LoginBloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpTurmas = new System.Windows.Forms.TabPage();
            this.btnTU_AlterarTurma = new System.Windows.Forms.Button();
            this.txbTU_AlterarTurma = new System.Windows.Forms.TextBox();
            this.lblTU_AlterarTurma = new System.Windows.Forms.Label();
            this.btnTU_DeletarTurma = new System.Windows.Forms.Button();
            this.btnTU_AdicionarTurma = new System.Windows.Forms.Button();
            this.txbTU_NovaTurma = new System.Windows.Forms.TextBox();
            this.lblTU_AdicionarTurma = new System.Windows.Forms.Label();
            this.btnTU_DeletarAluno = new System.Windows.Forms.Button();
            this.lblTU_AdicionarAluno = new System.Windows.Forms.Label();
            this.txbTU_AdicionarAluno = new System.Windows.Forms.TextBox();
            this.btnTU_AdicionarAluno = new System.Windows.Forms.Button();
            this.dgvTU_Alunos = new System.Windows.Forms.DataGridView();
            this.Alunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTU_Turmas = new System.Windows.Forms.DataGridView();
            this.Turmas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAvaliacoes = new System.Windows.Forms.TabPage();
            this.btnAV_SalvarNotas = new System.Windows.Forms.Button();
            this.txbAV_Renomear = new System.Windows.Forms.TextBox();
            this.btnAV_RenomearAvaliacao = new System.Windows.Forms.Button();
            this.dgvAV_Alunos = new System.Windows.Forms.DataGridView();
            this.AlunosAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAV_RemoverAvaliacao = new System.Windows.Forms.Button();
            this.btnAV_AdicionarAvaliacao = new System.Windows.Forms.Button();
            this.dgvAV_Avaliacoes = new System.Windows.Forms.DataGridView();
            this.Avaliacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAV_Turmas = new System.Windows.Forms.DataGridView();
            this.TurmasAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpEstatisticas = new System.Windows.Forms.TabPage();
            this.lblEST_MediasAvaliacoes = new System.Windows.Forms.Label();
            this.lbxEST_MediasAvaliacoes = new System.Windows.Forms.ListBox();
            this.dgvEST_Turmas = new System.Windows.Forms.DataGridView();
            this.Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprovados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reprovados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbEST_Femeas = new System.Windows.Forms.TextBox();
            this.lblEST_Femeas = new System.Windows.Forms.Label();
            this.txbEST_Machos = new System.Windows.Forms.TextBox();
            this.lblEST_Machos = new System.Windows.Forms.Label();
            this.lblEST_AprovadosReprovados = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAL_Alunos)).BeginInit();
            this.tbpTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU_Turmas)).BeginInit();
            this.tbpAvaliacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAV_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAV_Avaliacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAV_Turmas)).BeginInit();
            this.tbpEstatisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEST_Turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAlunos);
            this.tabControl1.Controls.Add(this.tbpTurmas);
            this.tabControl1.Controls.Add(this.tbpAvaliacoes);
            this.tabControl1.Controls.Add(this.tbpEstatisticas);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpAlunos
            // 
            this.tbpAlunos.BackColor = System.Drawing.Color.DarkCyan;
            this.tbpAlunos.Controls.Add(this.lblAL_OBS);
            this.tbpAlunos.Controls.Add(this.btnAL_SalvarAlunos);
            this.tbpAlunos.Controls.Add(this.btnAL_DesbloquearAluno);
            this.tbpAlunos.Controls.Add(this.btnAL_RemoverAluno);
            this.tbpAlunos.Controls.Add(this.btnAL_CadastrarAluno);
            this.tbpAlunos.Controls.Add(this.lblAL_Senha);
            this.tbpAlunos.Controls.Add(this.lblAL_Usuario);
            this.tbpAlunos.Controls.Add(this.lblAL_Genero);
            this.tbpAlunos.Controls.Add(this.cbxAL_Femea);
            this.tbpAlunos.Controls.Add(this.cbxAL_Macho);
            this.tbpAlunos.Controls.Add(this.txbAL_Senha);
            this.tbpAlunos.Controls.Add(this.txbAL_Usuario);
            this.tbpAlunos.Controls.Add(this.lblAL_NomeAluno);
            this.tbpAlunos.Controls.Add(this.txbAL_Nome);
            this.tbpAlunos.Controls.Add(this.lblAdicionarAluno);
            this.tbpAlunos.Controls.Add(this.dgvAL_Alunos);
            this.tbpAlunos.Location = new System.Drawing.Point(4, 24);
            this.tbpAlunos.Name = "tbpAlunos";
            this.tbpAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlunos.Size = new System.Drawing.Size(790, 422);
            this.tbpAlunos.TabIndex = 0;
            this.tbpAlunos.Text = "Alunos";
            // 
            // lblAL_OBS
            // 
            this.lblAL_OBS.AutoSize = true;
            this.lblAL_OBS.Location = new System.Drawing.Point(64, 257);
            this.lblAL_OBS.Name = "lblAL_OBS";
            this.lblAL_OBS.Size = new System.Drawing.Size(341, 15);
            this.lblAL_OBS.TabIndex = 15;
            this.lblAL_OBS.Text = "Observação: alterações são diretamente na tabela, depois salvar";
            // 
            // btnAL_SalvarAlunos
            // 
            this.btnAL_SalvarAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAL_SalvarAlunos.Location = new System.Drawing.Point(242, 280);
            this.btnAL_SalvarAlunos.Name = "btnAL_SalvarAlunos";
            this.btnAL_SalvarAlunos.Size = new System.Drawing.Size(194, 57);
            this.btnAL_SalvarAlunos.TabIndex = 14;
            this.btnAL_SalvarAlunos.Text = "Salvar Lista de alunos";
            this.btnAL_SalvarAlunos.UseVisualStyleBackColor = true;
            this.btnAL_SalvarAlunos.Click += new System.EventHandler(this.btnSalvarAlunos_Click);
            // 
            // btnAL_DesbloquearAluno
            // 
            this.btnAL_DesbloquearAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAL_DesbloquearAluno.Location = new System.Drawing.Point(84, 352);
            this.btnAL_DesbloquearAluno.Name = "btnAL_DesbloquearAluno";
            this.btnAL_DesbloquearAluno.Size = new System.Drawing.Size(304, 57);
            this.btnAL_DesbloquearAluno.TabIndex = 13;
            this.btnAL_DesbloquearAluno.Text = "Desbloquear aluno";
            this.btnAL_DesbloquearAluno.UseVisualStyleBackColor = true;
            this.btnAL_DesbloquearAluno.Click += new System.EventHandler(this.btnDesbloquearAluno_Click);
            // 
            // btnAL_RemoverAluno
            // 
            this.btnAL_RemoverAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAL_RemoverAluno.Location = new System.Drawing.Point(18, 280);
            this.btnAL_RemoverAluno.Name = "btnAL_RemoverAluno";
            this.btnAL_RemoverAluno.Size = new System.Drawing.Size(194, 57);
            this.btnAL_RemoverAluno.TabIndex = 12;
            this.btnAL_RemoverAluno.Text = "Remover aluno da lista";
            this.btnAL_RemoverAluno.UseVisualStyleBackColor = true;
            this.btnAL_RemoverAluno.Click += new System.EventHandler(this.btnRemoverAluno_Click);
            // 
            // btnAL_CadastrarAluno
            // 
            this.btnAL_CadastrarAluno.Location = new System.Drawing.Point(164, 200);
            this.btnAL_CadastrarAluno.Name = "btnAL_CadastrarAluno";
            this.btnAL_CadastrarAluno.Size = new System.Drawing.Size(134, 44);
            this.btnAL_CadastrarAluno.TabIndex = 11;
            this.btnAL_CadastrarAluno.Text = "Cadastrar";
            this.btnAL_CadastrarAluno.UseVisualStyleBackColor = true;
            this.btnAL_CadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lblAL_Senha
            // 
            this.lblAL_Senha.AutoSize = true;
            this.lblAL_Senha.Location = new System.Drawing.Point(18, 158);
            this.lblAL_Senha.Name = "lblAL_Senha";
            this.lblAL_Senha.Size = new System.Drawing.Size(42, 15);
            this.lblAL_Senha.TabIndex = 10;
            this.lblAL_Senha.Text = "Senha:";
            // 
            // lblAL_Usuario
            // 
            this.lblAL_Usuario.AutoSize = true;
            this.lblAL_Usuario.Location = new System.Drawing.Point(18, 111);
            this.lblAL_Usuario.Name = "lblAL_Usuario";
            this.lblAL_Usuario.Size = new System.Drawing.Size(50, 15);
            this.lblAL_Usuario.TabIndex = 9;
            this.lblAL_Usuario.Text = "Usuário:";
            // 
            // lblAL_Genero
            // 
            this.lblAL_Genero.AutoSize = true;
            this.lblAL_Genero.Location = new System.Drawing.Point(357, 60);
            this.lblAL_Genero.Name = "lblAL_Genero";
            this.lblAL_Genero.Size = new System.Drawing.Size(48, 15);
            this.lblAL_Genero.TabIndex = 8;
            this.lblAL_Genero.Text = "Gênero:";
            // 
            // cbxAL_Femea
            // 
            this.cbxAL_Femea.AutoSize = true;
            this.cbxAL_Femea.Location = new System.Drawing.Point(355, 141);
            this.cbxAL_Femea.Name = "cbxAL_Femea";
            this.cbxAL_Femea.Size = new System.Drawing.Size(61, 19);
            this.cbxAL_Femea.TabIndex = 7;
            this.cbxAL_Femea.Text = "Fêmea";
            this.cbxAL_Femea.UseVisualStyleBackColor = true;
            // 
            // cbxAL_Macho
            // 
            this.cbxAL_Macho.AutoSize = true;
            this.cbxAL_Macho.Location = new System.Drawing.Point(355, 95);
            this.cbxAL_Macho.Name = "cbxAL_Macho";
            this.cbxAL_Macho.Size = new System.Drawing.Size(63, 19);
            this.cbxAL_Macho.TabIndex = 6;
            this.cbxAL_Macho.Text = "Macho";
            this.cbxAL_Macho.UseVisualStyleBackColor = true;
            // 
            // txbAL_Senha
            // 
            this.txbAL_Senha.Location = new System.Drawing.Point(84, 154);
            this.txbAL_Senha.Name = "txbAL_Senha";
            this.txbAL_Senha.Size = new System.Drawing.Size(228, 23);
            this.txbAL_Senha.TabIndex = 5;
            // 
            // txbAL_Usuario
            // 
            this.txbAL_Usuario.Location = new System.Drawing.Point(84, 107);
            this.txbAL_Usuario.Name = "txbAL_Usuario";
            this.txbAL_Usuario.Size = new System.Drawing.Size(228, 23);
            this.txbAL_Usuario.TabIndex = 4;
            // 
            // lblAL_NomeAluno
            // 
            this.lblAL_NomeAluno.AutoSize = true;
            this.lblAL_NomeAluno.Location = new System.Drawing.Point(18, 63);
            this.lblAL_NomeAluno.Name = "lblAL_NomeAluno";
            this.lblAL_NomeAluno.Size = new System.Drawing.Size(43, 15);
            this.lblAL_NomeAluno.TabIndex = 3;
            this.lblAL_NomeAluno.Text = "Nome:";
            // 
            // txbAL_Nome
            // 
            this.txbAL_Nome.Location = new System.Drawing.Point(84, 60);
            this.txbAL_Nome.Name = "txbAL_Nome";
            this.txbAL_Nome.Size = new System.Drawing.Size(228, 23);
            this.txbAL_Nome.TabIndex = 2;
            // 
            // lblAdicionarAluno
            // 
            this.lblAdicionarAluno.AutoSize = true;
            this.lblAdicionarAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdicionarAluno.Location = new System.Drawing.Point(128, 19);
            this.lblAdicionarAluno.Name = "lblAdicionarAluno";
            this.lblAdicionarAluno.Size = new System.Drawing.Size(134, 21);
            this.lblAdicionarAluno.TabIndex = 1;
            this.lblAdicionarAluno.Text = "Adicionar Aluno";
            // 
            // dgvAL_Alunos
            // 
            this.dgvAL_Alunos.AllowUserToAddRows = false;
            this.dgvAL_Alunos.AllowUserToDeleteRows = false;
            this.dgvAL_Alunos.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvAL_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAL_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aluno,
            this.Genero,
            this.LoginBloqueado});
            this.dgvAL_Alunos.Location = new System.Drawing.Point(475, 6);
            this.dgvAL_Alunos.Name = "dgvAL_Alunos";
            this.dgvAL_Alunos.RowTemplate.Height = 25;
            this.dgvAL_Alunos.Size = new System.Drawing.Size(298, 407);
            this.dgvAL_Alunos.TabIndex = 0;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Gênero";
            this.Genero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Genero.Name = "Genero";
            this.Genero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LoginBloqueado
            // 
            this.LoginBloqueado.HeaderText = "Login";
            this.LoginBloqueado.Name = "LoginBloqueado";
            this.LoginBloqueado.ReadOnly = true;
            // 
            // tbpTurmas
            // 
            this.tbpTurmas.BackColor = System.Drawing.Color.DarkCyan;
            this.tbpTurmas.Controls.Add(this.btnTU_AlterarTurma);
            this.tbpTurmas.Controls.Add(this.txbTU_AlterarTurma);
            this.tbpTurmas.Controls.Add(this.lblTU_AlterarTurma);
            this.tbpTurmas.Controls.Add(this.btnTU_DeletarTurma);
            this.tbpTurmas.Controls.Add(this.btnTU_AdicionarTurma);
            this.tbpTurmas.Controls.Add(this.txbTU_NovaTurma);
            this.tbpTurmas.Controls.Add(this.lblTU_AdicionarTurma);
            this.tbpTurmas.Controls.Add(this.btnTU_DeletarAluno);
            this.tbpTurmas.Controls.Add(this.lblTU_AdicionarAluno);
            this.tbpTurmas.Controls.Add(this.txbTU_AdicionarAluno);
            this.tbpTurmas.Controls.Add(this.btnTU_AdicionarAluno);
            this.tbpTurmas.Controls.Add(this.dgvTU_Alunos);
            this.tbpTurmas.Controls.Add(this.dgvTU_Turmas);
            this.tbpTurmas.Location = new System.Drawing.Point(4, 24);
            this.tbpTurmas.Name = "tbpTurmas";
            this.tbpTurmas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTurmas.Size = new System.Drawing.Size(790, 422);
            this.tbpTurmas.TabIndex = 1;
            this.tbpTurmas.Text = "Turmas";
            // 
            // btnTU_AlterarTurma
            // 
            this.btnTU_AlterarTurma.Location = new System.Drawing.Point(588, 299);
            this.btnTU_AlterarTurma.Name = "btnTU_AlterarTurma";
            this.btnTU_AlterarTurma.Size = new System.Drawing.Size(113, 23);
            this.btnTU_AlterarTurma.TabIndex = 14;
            this.btnTU_AlterarTurma.Text = "Alterar";
            this.btnTU_AlterarTurma.UseVisualStyleBackColor = true;
            this.btnTU_AlterarTurma.Click += new System.EventHandler(this.btnTU_AlterarTurma_Click);
            // 
            // txbTU_AlterarTurma
            // 
            this.txbTU_AlterarTurma.Location = new System.Drawing.Point(570, 270);
            this.txbTU_AlterarTurma.Name = "txbTU_AlterarTurma";
            this.txbTU_AlterarTurma.Size = new System.Drawing.Size(143, 23);
            this.txbTU_AlterarTurma.TabIndex = 13;
            // 
            // lblTU_AlterarTurma
            // 
            this.lblTU_AlterarTurma.AutoSize = true;
            this.lblTU_AlterarTurma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTU_AlterarTurma.Location = new System.Drawing.Point(588, 246);
            this.lblTU_AlterarTurma.Name = "lblTU_AlterarTurma";
            this.lblTU_AlterarTurma.Size = new System.Drawing.Size(114, 21);
            this.lblTU_AlterarTurma.TabIndex = 12;
            this.lblTU_AlterarTurma.Text = "Alterar Turma";
            this.lblTU_AlterarTurma.UseMnemonic = false;
            // 
            // btnTU_DeletarTurma
            // 
            this.btnTU_DeletarTurma.Location = new System.Drawing.Point(664, 354);
            this.btnTU_DeletarTurma.Name = "btnTU_DeletarTurma";
            this.btnTU_DeletarTurma.Size = new System.Drawing.Size(113, 55);
            this.btnTU_DeletarTurma.TabIndex = 11;
            this.btnTU_DeletarTurma.Text = "Deletar Turma";
            this.btnTU_DeletarTurma.UseVisualStyleBackColor = true;
            this.btnTU_DeletarTurma.Click += new System.EventHandler(this.btnTU_DeletarTurma_Click);
            // 
            // btnTU_AdicionarTurma
            // 
            this.btnTU_AdicionarTurma.Location = new System.Drawing.Point(588, 190);
            this.btnTU_AdicionarTurma.Name = "btnTU_AdicionarTurma";
            this.btnTU_AdicionarTurma.Size = new System.Drawing.Size(113, 23);
            this.btnTU_AdicionarTurma.TabIndex = 10;
            this.btnTU_AdicionarTurma.Text = "Adicionar";
            this.btnTU_AdicionarTurma.UseVisualStyleBackColor = true;
            this.btnTU_AdicionarTurma.Click += new System.EventHandler(this.btnTU_AdicionarTurma_Click);
            // 
            // txbTU_NovaTurma
            // 
            this.txbTU_NovaTurma.Location = new System.Drawing.Point(570, 158);
            this.txbTU_NovaTurma.Name = "txbTU_NovaTurma";
            this.txbTU_NovaTurma.Size = new System.Drawing.Size(143, 23);
            this.txbTU_NovaTurma.TabIndex = 9;
            // 
            // lblTU_AdicionarTurma
            // 
            this.lblTU_AdicionarTurma.AutoSize = true;
            this.lblTU_AdicionarTurma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTU_AdicionarTurma.Location = new System.Drawing.Point(577, 131);
            this.lblTU_AdicionarTurma.Name = "lblTU_AdicionarTurma";
            this.lblTU_AdicionarTurma.Size = new System.Drawing.Size(136, 21);
            this.lblTU_AdicionarTurma.TabIndex = 8;
            this.lblTU_AdicionarTurma.Text = "Adicionar Turma";
            // 
            // btnTU_DeletarAluno
            // 
            this.btnTU_DeletarAluno.Location = new System.Drawing.Point(523, 354);
            this.btnTU_DeletarAluno.Name = "btnTU_DeletarAluno";
            this.btnTU_DeletarAluno.Size = new System.Drawing.Size(113, 55);
            this.btnTU_DeletarAluno.TabIndex = 6;
            this.btnTU_DeletarAluno.Text = "Remover Aluno";
            this.btnTU_DeletarAluno.UseVisualStyleBackColor = true;
            this.btnTU_DeletarAluno.Click += new System.EventHandler(this.btnTU_DeletarAluno_Click);
            // 
            // lblTU_AdicionarAluno
            // 
            this.lblTU_AdicionarAluno.AutoSize = true;
            this.lblTU_AdicionarAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTU_AdicionarAluno.Location = new System.Drawing.Point(579, 6);
            this.lblTU_AdicionarAluno.Name = "lblTU_AdicionarAluno";
            this.lblTU_AdicionarAluno.Size = new System.Drawing.Size(134, 21);
            this.lblTU_AdicionarAluno.TabIndex = 5;
            this.lblTU_AdicionarAluno.Text = "Adicionar Aluno";
            // 
            // txbTU_AdicionarAluno
            // 
            this.txbTU_AdicionarAluno.Location = new System.Drawing.Point(570, 37);
            this.txbTU_AdicionarAluno.Name = "txbTU_AdicionarAluno";
            this.txbTU_AdicionarAluno.Size = new System.Drawing.Size(141, 23);
            this.txbTU_AdicionarAluno.TabIndex = 4;
            // 
            // btnTU_AdicionarAluno
            // 
            this.btnTU_AdicionarAluno.Location = new System.Drawing.Point(588, 70);
            this.btnTU_AdicionarAluno.Name = "btnTU_AdicionarAluno";
            this.btnTU_AdicionarAluno.Size = new System.Drawing.Size(113, 25);
            this.btnTU_AdicionarAluno.TabIndex = 3;
            this.btnTU_AdicionarAluno.Text = "Adicionar";
            this.btnTU_AdicionarAluno.UseVisualStyleBackColor = true;
            this.btnTU_AdicionarAluno.Click += new System.EventHandler(this.btnTU_AdicionarAluno_Click);
            // 
            // dgvTU_Alunos
            // 
            this.dgvTU_Alunos.AllowUserToAddRows = false;
            this.dgvTU_Alunos.AllowUserToDeleteRows = false;
            this.dgvTU_Alunos.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvTU_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTU_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alunos});
            this.dgvTU_Alunos.Location = new System.Drawing.Point(260, 6);
            this.dgvTU_Alunos.Name = "dgvTU_Alunos";
            this.dgvTU_Alunos.ReadOnly = true;
            this.dgvTU_Alunos.RowTemplate.Height = 25;
            this.dgvTU_Alunos.Size = new System.Drawing.Size(230, 407);
            this.dgvTU_Alunos.TabIndex = 2;
            // 
            // Alunos
            // 
            this.Alunos.HeaderText = "Alunos";
            this.Alunos.Name = "Alunos";
            this.Alunos.ReadOnly = true;
            // 
            // dgvTU_Turmas
            // 
            this.dgvTU_Turmas.AllowUserToAddRows = false;
            this.dgvTU_Turmas.AllowUserToDeleteRows = false;
            this.dgvTU_Turmas.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvTU_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTU_Turmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turmas});
            this.dgvTU_Turmas.Location = new System.Drawing.Point(7, 6);
            this.dgvTU_Turmas.Name = "dgvTU_Turmas";
            this.dgvTU_Turmas.ReadOnly = true;
            this.dgvTU_Turmas.RowTemplate.Height = 25;
            this.dgvTU_Turmas.Size = new System.Drawing.Size(237, 407);
            this.dgvTU_Turmas.TabIndex = 1;
            this.dgvTU_Turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellContentClick);
            // 
            // Turmas
            // 
            this.Turmas.HeaderText = "Turmas";
            this.Turmas.Name = "Turmas";
            this.Turmas.ReadOnly = true;
            // 
            // tbpAvaliacoes
            // 
            this.tbpAvaliacoes.BackColor = System.Drawing.Color.DarkCyan;
            this.tbpAvaliacoes.Controls.Add(this.btnAV_SalvarNotas);
            this.tbpAvaliacoes.Controls.Add(this.txbAV_Renomear);
            this.tbpAvaliacoes.Controls.Add(this.btnAV_RenomearAvaliacao);
            this.tbpAvaliacoes.Controls.Add(this.dgvAV_Alunos);
            this.tbpAvaliacoes.Controls.Add(this.btnAV_RemoverAvaliacao);
            this.tbpAvaliacoes.Controls.Add(this.btnAV_AdicionarAvaliacao);
            this.tbpAvaliacoes.Controls.Add(this.dgvAV_Avaliacoes);
            this.tbpAvaliacoes.Controls.Add(this.dgvAV_Turmas);
            this.tbpAvaliacoes.Location = new System.Drawing.Point(4, 24);
            this.tbpAvaliacoes.Name = "tbpAvaliacoes";
            this.tbpAvaliacoes.Size = new System.Drawing.Size(790, 422);
            this.tbpAvaliacoes.TabIndex = 2;
            this.tbpAvaliacoes.Text = "Avaliações";
            // 
            // btnAV_SalvarNotas
            // 
            this.btnAV_SalvarNotas.Location = new System.Drawing.Point(242, 362);
            this.btnAV_SalvarNotas.Name = "btnAV_SalvarNotas";
            this.btnAV_SalvarNotas.Size = new System.Drawing.Size(104, 47);
            this.btnAV_SalvarNotas.TabIndex = 7;
            this.btnAV_SalvarNotas.Text = "Salvar Notas";
            this.btnAV_SalvarNotas.UseVisualStyleBackColor = true;
            this.btnAV_SalvarNotas.Click += new System.EventHandler(this.btnAV_SalvarNotas_Click);
            // 
            // txbAV_Renomear
            // 
            this.txbAV_Renomear.Location = new System.Drawing.Point(242, 299);
            this.txbAV_Renomear.Name = "txbAV_Renomear";
            this.txbAV_Renomear.Size = new System.Drawing.Size(104, 23);
            this.txbAV_Renomear.TabIndex = 6;
            // 
            // btnAV_RenomearAvaliacao
            // 
            this.btnAV_RenomearAvaliacao.Location = new System.Drawing.Point(242, 226);
            this.btnAV_RenomearAvaliacao.Name = "btnAV_RenomearAvaliacao";
            this.btnAV_RenomearAvaliacao.Size = new System.Drawing.Size(104, 51);
            this.btnAV_RenomearAvaliacao.TabIndex = 5;
            this.btnAV_RenomearAvaliacao.Text = "Renomear Avaliação";
            this.btnAV_RenomearAvaliacao.UseVisualStyleBackColor = true;
            this.btnAV_RenomearAvaliacao.Click += new System.EventHandler(this.btnAV_RenomearAvaliacao_Click);
            // 
            // dgvAV_Alunos
            // 
            this.dgvAV_Alunos.AllowUserToAddRows = false;
            this.dgvAV_Alunos.AllowUserToDeleteRows = false;
            this.dgvAV_Alunos.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvAV_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAV_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlunosAV,
            this.Nota});
            this.dgvAV_Alunos.Location = new System.Drawing.Point(581, 6);
            this.dgvAV_Alunos.Name = "dgvAV_Alunos";
            this.dgvAV_Alunos.RowTemplate.Height = 25;
            this.dgvAV_Alunos.Size = new System.Drawing.Size(202, 407);
            this.dgvAV_Alunos.TabIndex = 4;
            // 
            // AlunosAV
            // 
            this.AlunosAV.HeaderText = "Alunos";
            this.AlunosAV.Name = "AlunosAV";
            this.AlunosAV.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // btnAV_RemoverAvaliacao
            // 
            this.btnAV_RemoverAvaliacao.Location = new System.Drawing.Point(242, 131);
            this.btnAV_RemoverAvaliacao.Name = "btnAV_RemoverAvaliacao";
            this.btnAV_RemoverAvaliacao.Size = new System.Drawing.Size(104, 68);
            this.btnAV_RemoverAvaliacao.TabIndex = 3;
            this.btnAV_RemoverAvaliacao.Text = "Remover Avaliação";
            this.btnAV_RemoverAvaliacao.UseVisualStyleBackColor = true;
            this.btnAV_RemoverAvaliacao.Click += new System.EventHandler(this.btnAV_RemoverAvaliacao_Click);
            // 
            // btnAV_AdicionarAvaliacao
            // 
            this.btnAV_AdicionarAvaliacao.Location = new System.Drawing.Point(242, 33);
            this.btnAV_AdicionarAvaliacao.Name = "btnAV_AdicionarAvaliacao";
            this.btnAV_AdicionarAvaliacao.Size = new System.Drawing.Size(104, 68);
            this.btnAV_AdicionarAvaliacao.TabIndex = 2;
            this.btnAV_AdicionarAvaliacao.Text = "Adicionar Avaliação";
            this.btnAV_AdicionarAvaliacao.UseVisualStyleBackColor = true;
            this.btnAV_AdicionarAvaliacao.Click += new System.EventHandler(this.btnAV_AdicionarAvaliacao_Click);
            // 
            // dgvAV_Avaliacoes
            // 
            this.dgvAV_Avaliacoes.AllowUserToAddRows = false;
            this.dgvAV_Avaliacoes.AllowUserToDeleteRows = false;
            this.dgvAV_Avaliacoes.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvAV_Avaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAV_Avaliacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Avaliacoes});
            this.dgvAV_Avaliacoes.Location = new System.Drawing.Point(375, 6);
            this.dgvAV_Avaliacoes.Name = "dgvAV_Avaliacoes";
            this.dgvAV_Avaliacoes.ReadOnly = true;
            this.dgvAV_Avaliacoes.RowTemplate.Height = 25;
            this.dgvAV_Avaliacoes.Size = new System.Drawing.Size(202, 407);
            this.dgvAV_Avaliacoes.TabIndex = 1;
            this.dgvAV_Avaliacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvaliacoes_CellContentClick);
            // 
            // Avaliacoes
            // 
            this.Avaliacoes.HeaderText = "Avaliações";
            this.Avaliacoes.Name = "Avaliacoes";
            this.Avaliacoes.ReadOnly = true;
            // 
            // dgvAV_Turmas
            // 
            this.dgvAV_Turmas.AllowUserToAddRows = false;
            this.dgvAV_Turmas.AllowUserToDeleteRows = false;
            this.dgvAV_Turmas.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvAV_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAV_Turmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TurmasAV});
            this.dgvAV_Turmas.Location = new System.Drawing.Point(7, 6);
            this.dgvAV_Turmas.Name = "dgvAV_Turmas";
            this.dgvAV_Turmas.ReadOnly = true;
            this.dgvAV_Turmas.RowTemplate.Height = 25;
            this.dgvAV_Turmas.Size = new System.Drawing.Size(202, 407);
            this.dgvAV_Turmas.TabIndex = 0;
            this.dgvAV_Turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAV_Turmas_CellContentClick);
            // 
            // TurmasAV
            // 
            this.TurmasAV.HeaderText = "Turmas";
            this.TurmasAV.Name = "TurmasAV";
            this.TurmasAV.ReadOnly = true;
            // 
            // tbpEstatisticas
            // 
            this.tbpEstatisticas.BackColor = System.Drawing.Color.DarkCyan;
            this.tbpEstatisticas.Controls.Add(this.lblEST_AprovadosReprovados);
            this.tbpEstatisticas.Controls.Add(this.lblEST_MediasAvaliacoes);
            this.tbpEstatisticas.Controls.Add(this.lbxEST_MediasAvaliacoes);
            this.tbpEstatisticas.Controls.Add(this.dgvEST_Turmas);
            this.tbpEstatisticas.Controls.Add(this.txbEST_Femeas);
            this.tbpEstatisticas.Controls.Add(this.lblEST_Femeas);
            this.tbpEstatisticas.Controls.Add(this.txbEST_Machos);
            this.tbpEstatisticas.Controls.Add(this.lblEST_Machos);
            this.tbpEstatisticas.Location = new System.Drawing.Point(4, 24);
            this.tbpEstatisticas.Name = "tbpEstatisticas";
            this.tbpEstatisticas.Size = new System.Drawing.Size(790, 422);
            this.tbpEstatisticas.TabIndex = 3;
            this.tbpEstatisticas.Text = "Estatísticas";
            // 
            // lblEST_MediasAvaliacoes
            // 
            this.lblEST_MediasAvaliacoes.AutoSize = true;
            this.lblEST_MediasAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEST_MediasAvaliacoes.Location = new System.Drawing.Point(112, 122);
            this.lblEST_MediasAvaliacoes.Name = "lblEST_MediasAvaliacoes";
            this.lblEST_MediasAvaliacoes.Size = new System.Drawing.Size(183, 21);
            this.lblEST_MediasAvaliacoes.TabIndex = 8;
            this.lblEST_MediasAvaliacoes.Text = "Médias por avaliações:";
            // 
            // lbxEST_MediasAvaliacoes
            // 
            this.lbxEST_MediasAvaliacoes.FormattingEnabled = true;
            this.lbxEST_MediasAvaliacoes.ItemHeight = 15;
            this.lbxEST_MediasAvaliacoes.Location = new System.Drawing.Point(33, 169);
            this.lbxEST_MediasAvaliacoes.Name = "lbxEST_MediasAvaliacoes";
            this.lbxEST_MediasAvaliacoes.Size = new System.Drawing.Size(332, 229);
            this.lbxEST_MediasAvaliacoes.TabIndex = 7;
            // 
            // dgvEST_Turmas
            // 
            this.dgvEST_Turmas.AllowUserToAddRows = false;
            this.dgvEST_Turmas.AllowUserToDeleteRows = false;
            this.dgvEST_Turmas.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvEST_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEST_Turmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turma,
            this.Aprovados,
            this.Reprovados});
            this.dgvEST_Turmas.Location = new System.Drawing.Point(417, 71);
            this.dgvEST_Turmas.Name = "dgvEST_Turmas";
            this.dgvEST_Turmas.ReadOnly = true;
            this.dgvEST_Turmas.RowTemplate.Height = 25;
            this.dgvEST_Turmas.Size = new System.Drawing.Size(344, 327);
            this.dgvEST_Turmas.TabIndex = 6;
            // 
            // Turma
            // 
            this.Turma.HeaderText = "Turma";
            this.Turma.Name = "Turma";
            this.Turma.ReadOnly = true;
            // 
            // Aprovados
            // 
            this.Aprovados.HeaderText = "Nota >= 7";
            this.Aprovados.Name = "Aprovados";
            this.Aprovados.ReadOnly = true;
            // 
            // Reprovados
            // 
            this.Reprovados.HeaderText = "Nota < 7";
            this.Reprovados.Name = "Reprovados";
            this.Reprovados.ReadOnly = true;
            // 
            // txbEST_Femeas
            // 
            this.txbEST_Femeas.Enabled = false;
            this.txbEST_Femeas.Location = new System.Drawing.Point(135, 71);
            this.txbEST_Femeas.Name = "txbEST_Femeas";
            this.txbEST_Femeas.Size = new System.Drawing.Size(80, 23);
            this.txbEST_Femeas.TabIndex = 5;
            // 
            // lblEST_Femeas
            // 
            this.lblEST_Femeas.AutoSize = true;
            this.lblEST_Femeas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEST_Femeas.Location = new System.Drawing.Point(33, 71);
            this.lblEST_Femeas.Name = "lblEST_Femeas";
            this.lblEST_Femeas.Size = new System.Drawing.Size(71, 21);
            this.lblEST_Femeas.TabIndex = 4;
            this.lblEST_Femeas.Text = "Fêmeas:";
            // 
            // txbEST_Machos
            // 
            this.txbEST_Machos.Enabled = false;
            this.txbEST_Machos.Location = new System.Drawing.Point(135, 29);
            this.txbEST_Machos.Name = "txbEST_Machos";
            this.txbEST_Machos.Size = new System.Drawing.Size(80, 23);
            this.txbEST_Machos.TabIndex = 3;
            // 
            // lblEST_Machos
            // 
            this.lblEST_Machos.AutoSize = true;
            this.lblEST_Machos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEST_Machos.Location = new System.Drawing.Point(33, 27);
            this.lblEST_Machos.Name = "lblEST_Machos";
            this.lblEST_Machos.Size = new System.Drawing.Size(73, 21);
            this.lblEST_Machos.TabIndex = 2;
            this.lblEST_Machos.Text = "Machos:";
            // 
            // lblEST_AprovadosReprovados
            // 
            this.lblEST_AprovadosReprovados.AutoSize = true;
            this.lblEST_AprovadosReprovados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEST_AprovadosReprovados.Location = new System.Drawing.Point(493, 29);
            this.lblEST_AprovadosReprovados.Name = "lblEST_AprovadosReprovados";
            this.lblEST_AprovadosReprovados.Size = new System.Drawing.Size(193, 21);
            this.lblEST_AprovadosReprovados.TabIndex = 9;
            this.lblEST_AprovadosReprovados.Text = "Aprovados/Reprovados:";
            // 
            // TelaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(794, 446);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaProfessor";
            this.Load += new System.EventHandler(this.TelaProfessor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpAlunos.ResumeLayout(false);
            this.tbpAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAL_Alunos)).EndInit();
            this.tbpTurmas.ResumeLayout(false);
            this.tbpTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTU_Turmas)).EndInit();
            this.tbpAvaliacoes.ResumeLayout(false);
            this.tbpAvaliacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAV_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAV_Avaliacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAV_Turmas)).EndInit();
            this.tbpEstatisticas.ResumeLayout(false);
            this.tbpEstatisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEST_Turmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpAlunos;
        private TabPage tbpTurmas;
        private TabPage tbpAvaliacoes;
        private TabPage tbpEstatisticas;
        private TextBox txbAL_Nome;
        private Label lblAdicionarAluno;
        private DataGridView dgvAL_Alunos;
        private Button btnAL_RemoverAluno;
        private Button btnAL_CadastrarAluno;
        private Label lblAL_Senha;
        private Label lblAL_Usuario;
        private Label lblAL_Genero;
        private CheckBox cbxAL_Femea;
        private CheckBox cbxAL_Macho;
        private TextBox txbAL_Senha;
        private TextBox txbAL_Usuario;
        private Label lblAL_NomeAluno;
        private Button btnTU_DeletarAluno;
        private Label lblTU_AdicionarAluno;
        private TextBox txbTU_AdicionarAluno;
        private Button btnTU_AdicionarAluno;
        private DataGridView dgvTU_Alunos;
        private DataGridView dgvTU_Turmas;
        private Button btnAV_RemoverAvaliacao;
        private Button btnAV_AdicionarAvaliacao;
        private DataGridView dgvAV_Avaliacoes;
        private DataGridView dgvAV_Turmas;
        private DataGridViewTextBoxColumn Alunos;
        private DataGridViewTextBoxColumn Turmas;
        private DataGridView dgvAV_Alunos;
        private DataGridViewTextBoxColumn Avaliacoes;
        private DataGridViewTextBoxColumn TurmasAV;
        private Button btnAL_DesbloquearAluno;
        private Button btnAL_SalvarAlunos;
        private Label lblAL_OBS;
        private Button btnTU_AdicionarTurma;
        private TextBox txbTU_NovaTurma;
        private Label lblTU_AdicionarTurma;
        private Button btnTU_DeletarTurma;
        private Button btnTU_AlterarTurma;
        private TextBox txbTU_AlterarTurma;
        private Label lblTU_AlterarTurma;
        private DataGridViewTextBoxColumn Aluno;
        private DataGridViewComboBoxColumn Genero;
        private DataGridViewTextBoxColumn LoginBloqueado;
        private DataGridViewTextBoxColumn AlunosAV;
        private DataGridViewTextBoxColumn Nota;
        private Button btnAV_RenomearAvaliacao;
        private TextBox txbAV_Renomear;
        private Button btnAV_SalvarNotas;
        private DataGridView dgvEST_Turmas;
        private DataGridViewTextBoxColumn Turma;
        private DataGridViewTextBoxColumn Aprovados;
        private DataGridViewTextBoxColumn Reprovados;
        private TextBox txbEST_Femeas;
        private Label lblEST_Femeas;
        private TextBox txbEST_Machos;
        private Label lblEST_Machos;
        private Label lblEST_MediasAvaliacoes;
        private ListBox lbxEST_MediasAvaliacoes;
        private Label lblEST_AprovadosReprovados;
    }
}