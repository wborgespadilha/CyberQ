using Dapper;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using DapperCrud.Config;
using DapperCrud.Models;

namespace DapperCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        // Rota de teste da conexão com banco de dados
        [HttpGet("Conexao")]
        public string TestarConexao()
        {

            //Instanciar objeto da classe conexão
            Conexao c = new Conexao();

            // Realizar a conexão e armazenar em um objeto
            OracleConnection obj = c.RealizarConexao();

            obj.Open();

            string Mensagem;

            if(obj.State.ToString() == "Open")
            {
                Mensagem = "Conexão efetuada";
            }
            else
            {
                Mensagem = "Falha ao conectar";
            }

            return Mensagem;
        }

        [HttpGet]

        public IEnumerable<Pessoa> ListarPessoas()
        {
            // Instanciar objeto da classe Conexão
            Conexao c = new Conexao();

            // Obter acesso ao banco de dados - DAPPER
            using var connection = c.RealizarConexao();

            // Realizar instrução sql e retornar os registros - Dapper
            return connection.Query<Pessoa>("SELECT * FROM pessoas");
        }

        [HttpPost]
        public string CadastrarPessoas([FromBody] Pessoa p)
        {
            Conexao c = new Conexao();

            using var connection = c.RealizarConexao();

            connection.Execute(@"INSERT INTO pessoas (nome, idade) VALUES (:Nome, :Idade)", p);

            return "Cadastro efetuado com sucesso!";
        }

        [HttpPut]
        public string AlterarPessoas([FromBody] Pessoa p)
        {
            Conexao c = new Conexao();

            using var connection = c.RealizarConexao();

            connection.Execute(@"UPDATE pessoas SET nome = :Nome, idade = :Idade WHERE codigo = :Codigo", p);

            return "Pessoa alterada com sucesso!";
        }

        [HttpDelete("{codigo}")]

        public string RemoverPessoas(int codigo)
        {
            Conexao c = new Conexao();

            using var connection = c.RealizarConexao();

            connection.Execute(@"DELETE FROM pessoas WHERE codigo = " + codigo);

            return "Pessoa removida com sucesso!";
        }

    }
}
