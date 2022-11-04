using Blog.Config;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class DeletarPostagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var codigo = Request.QueryString["codigo"];

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();


                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"DELETE FROM postagens WHERE id_post = {codigo}";
                cmd.Connection = con;

                int linhas = cmd.ExecuteNonQuery();


                Response.Redirect("Admin.aspx?success=" + linhas, false);
            }
            catch (Exception ex)
            {
                Response.Redirect("Admin.aspx?error=" + ex.Message, false);
            }
        }
    }
}