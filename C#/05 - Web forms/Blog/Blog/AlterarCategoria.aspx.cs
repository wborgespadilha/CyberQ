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
    public partial class AlterarCategoria : System.Web.UI.Page
    {

        int codigo;

        protected void Page_Load(object sender, EventArgs e)
        {

            codigo = Convert.ToInt32(Request.QueryString["codigo"]);

            var error = Request.QueryString["error"];

            if (error != null)
            {
                LabelErro.Text = "Aconteceu um erro: " + error;
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(NomeCategoria.Text))
            {
                Response.Redirect("AlterarCategoria.aspx?codigo=" + "&error=Nome vazio!", false);
            }


            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();


                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE categorias SET nome = '{NomeCategoria.Text}' WHERE id_categoria = {codigo}";
                cmd.Connection = con;

                int linhas = cmd.ExecuteNonQuery();


                Response.Redirect("Admin.aspx?success=" + linhas, false);
            }
            catch (Exception ex)
            {
                Response.Redirect("AlterarCategoria.aspx?codigo=" + codigo + "&error=" + ex.Message, false);
            }

        }

        protected void Voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx", false);
        }
    }
}