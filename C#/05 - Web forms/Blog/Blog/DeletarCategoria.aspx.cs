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
    public partial class DeletarCategoria : System.Web.UI.Page
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
                cmd.CommandText = $"SELECT * FROM postagens WHERE fk_categoria = {codigo}";
                cmd.Connection = con;

                OracleDataReader odr = cmd.ExecuteReader();

                int posts = 0;

                while (odr.Read())
                {
                    posts++;
                }

                if(posts != 0)
                {
                    Response.Redirect("Admin.aspx?error=Há posts cadastrados com essa categoria!", false);
                    return;
                }

                OracleCommand cmd2 = new OracleCommand();
                cmd2.CommandText = $"DELETE FROM categorias WHERE id_categoria = {codigo}";
                cmd2.Connection = con;

                int linhas = cmd2.ExecuteNonQuery();


                Response.Redirect("Admin.aspx?success=" + linhas, false);
            }
            catch (Exception ex)
            {
                Response.Redirect("Admin.aspx?error=" + ex.Message , false);
            }
        }
    }
}