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
    public partial class Sessao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuario = Request.QueryString["usuario"];
            var senha = Request.QueryString["senha"];

            try
            {

                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"SELECT * FROM admins WHERE usuario = '{usuario}' AND senha = '{senha}'";
                cmd.Connection = con;

                OracleDataReader odr = cmd.ExecuteReader();

                int contador = 0;

                while (odr.Read())
                {
                    contador++;
                    Session["id"] = odr.GetString(0);
                    Session["usuario"] = odr.GetString(1);
                    Session["senha"] = odr.GetString(2);
                }

                if (contador == 1)
                {
                    Response.Write("OK!");
                   Response.Redirect("Admin.aspx",false);
                }
                else
                {
                    Response.Write("Falha");
                    Response.Redirect("Default.aspx?failed=1", false);
                }

            
            }
            catch (Exception ex)
            {
                Response.Redirect("Default.aspx?error=" + ex.Message, false);
            }

        }
    }
}