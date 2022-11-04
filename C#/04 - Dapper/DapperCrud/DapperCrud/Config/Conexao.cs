using Oracle.ManagedDataAccess.Client;

namespace DapperCrud.Config
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
                + "User Id=aluno18;Password=aluno18";

            return new OracleConnection(stringconexao);
        }
    }
}
