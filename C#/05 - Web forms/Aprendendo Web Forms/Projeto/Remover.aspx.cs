using Oracle.ManagedDataAccess.Client;
using Projeto.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class Remover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Obter o código via URL
            var codigo = Request.QueryString["codigo"];

            //Response.Write(codigo);

            try
            {

                // Conexão
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                //Oracle Command (Executar comandos SQL)
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add(":codigo_cidade", codigo);

                // Especificar cláusula SQL (INSERT, UPDATE, SELECT ou DELETE)
                cmd.CommandText = "DELETE FROM cidades WHERE codigo_cidade = :codigo_cidade";

                // Informar o acesso ao bd para o cmd
                cmd.Connection = con;

                // Retornar a quantidade de linhas que foram inseridas/modificadas/removidas
                int linhas = cmd.ExecuteNonQuery();

                // Condicional
                if (linhas == 0)
                {
                    Response.Write("Falha ao Deletar");
                }
                else
                {
                    Response.Redirect("Default.aspx");
                    //Response.Write("Cidade cadastrada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                Response.Write("Falha ao Deletar " + ex.Message);
            }


        }
    }
}