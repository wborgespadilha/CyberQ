using Oracle.ManagedDataAccess.Client;

namespace Projeto_Dapper_SqlBuilder.Config
{
    public class Conexao
    {
        public OracleConnection RealizarConexao()
        {
            // String de conexão
            string stringconexao = "DATA SOURCE = (DESCRIPTION ="
                + "(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.15.18)(PORT=1521))"
                + "(CONNECT_DATA =(SERVER = DEDICATED)"
                + "(SERVICE_NAME = TREINAMENTO))));"
                + "User Id=aluno14;Password=aluno14";

            return new OracleConnection(stringconexao);
        }
    }
}
