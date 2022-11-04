using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DB
{
    internal class Acoes
    {

        public static List<Pessoa> pessoas = new List<Pessoa>();

        private string StringDeConexao = "Data Source=(DESCRIPTION ="
           + "(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.15.18)(PORT = 1521))"
           + "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
           + "(SERVICE_NAME = treinamento))));"
           + "User Id= aluno18;Password=aluno18;";

        public void TestarConexao()
        {
            try
            {
                OracleConnection conexao = new OracleConnection(StringDeConexao);

                conexao.Open();

                MessageBox.Show("Conexão efetuada com sucesso!");

            }
            catch(Exception erro)
            {
                MessageBox.Show("Falha ao conectar: " + erro.Message);
            }
        }

        public void CadastrarPessoa(string nome, int idade)
        {
            try
            {
                OracleConnection conexao = new OracleConnection(StringDeConexao);

                conexao.Open();

                OracleCommand sql = new OracleCommand("INSERT INTO pessoas VALUES (:nome, :idade)", conexao);

                sql.Parameters.Add(new OracleParameter("nome", nome));
                sql.Parameters.Add(new OracleParameter("idade", idade));

                if(sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Pessoa cadastrada!");
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar");
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao conectar: " + erro.Message);
            }
        }

        public void ListarPessoas()
        {
            try
            {
                OracleConnection conexao = new OracleConnection(StringDeConexao);

                conexao.Open();

                OracleCommand sql = new OracleCommand("SELECT * FROM pessoas", conexao);

                OracleDataReader registros = sql.ExecuteReader();

                pessoas.Clear();

                while(registros.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Nome = registros.GetString(0);
                    p.Idade = registros.GetInt32(1);

                    pessoas.Add(p);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao conectar: " + erro.Message);
            }
        }

    }
}
