using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Web;

namespace Blog.Config
{
    public class Conexao
    {
        public OracleConnection RealizarConexao()
        {
            string StringConexao = "DATA SOURCE = (DESCRIPTION ="
                + "(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.15.18)(PORT=1521))"
                + "(CONNECT_DATA =(SERVER = DEDICATED)"
                + "(SERVICE_NAME = TREINAMENTO))));"
                + "User Id=aluno14;Password=aluno14";

            // Retorno contendo o acesso ao banco de dados
            return new OracleConnection(StringConexao);
        }
    }
}