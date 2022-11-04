using Projeto_Dapper_SqlBuilder.Config;
using Projeto_Dapper_SqlBuilder.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Projeto_Dapper_SqlBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ColaboradorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Object> ListarCargos()
        {
            Conexao c = new();

            using var connection = c.RealizarConexao();


            var builder = new SqlBuilder();
            builder.Select("nome_colaborador");
            builder.Select("nome_Cargo");
            builder.InnerJoin("cargos ON cargos.codigo_cargo = colaboradores.codigo_cargo");

            var builderTemplate = builder.AddTemplate("SELECT /**select**/ FROM colaboradores /**innerjoin**/");

            var cargos = connection.Query<Object>(builderTemplate.RawSql).ToList();

            return cargos;

        }
    }
}
