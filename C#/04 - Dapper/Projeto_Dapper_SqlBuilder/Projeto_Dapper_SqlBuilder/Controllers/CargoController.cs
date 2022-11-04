using Projeto_Dapper_SqlBuilder.Config;
using Projeto_Dapper_SqlBuilder.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Projeto_Dapper_SqlBuilder.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class CargoController : ControllerBase
    {

        [HttpGet]

        public IEnumerable<Cargo> ListarCargos()
        {
            Conexao c = new();

            using var connection = c.RealizarConexao();

            DynamicParameters parametro = new DynamicParameters();
            parametro.Add(":Comparativo", 3);

            var builder = new SqlBuilder();
            builder.Where("codigo_Cargo >= :Comparativo",parametro);
            builder.OrderBy("nome_Cargo");

            var builderTemplate = builder.AddTemplate("SELECT * FROM cargos /**where**/ /**orderby**/");

            var cargos = connection.Query<Cargo>(builderTemplate.RawSql, builderTemplate.Parameters).ToList();

            return cargos;

        }


    }
}
