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
    public partial class AlterarPostagem : System.Web.UI.Page
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

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM categorias ";
                cmd.Connection = con;

                OracleDataReader odr = cmd.ExecuteReader();

                while (odr.Read())
                {
                    ListItem lst = new ListItem(odr.GetString(1), odr.GetString(0));
                    ListaCategorias.Items.Insert(ListaCategorias.Items.Count == 0 ? 0 : ListaCategorias.Items.Count - 1, lst);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Falha ao realizar a conexão:" + ex.Message);
            }

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            string titulo = TituloPostagem.Text;
            string texto = Request.Form["TextoPostagem"];

            ListItem lst = ListaCategorias.Items[ListaCategorias.SelectedIndex];

            int categoria = Convert.ToInt32(lst.Value);

            if (String.IsNullOrEmpty(titulo) == true)
            {
                Response.Redirect("AlterarCategoria.aspx?codigo=" + codigo + "&error=Nome Vazio!", false);
                return;
            }

            if (String.IsNullOrEmpty(texto) == true)
            {
                Response.Redirect("AlterarCategoria.aspx?codigo=" + codigo + "&error=Nome Vazio!", false);
                return;
            }

            if (categoria == 0)
            {
                Response.Redirect("AlterarCategoria.aspx?codigo=" + codigo + "&error=Categoria inválida!", false); 
                return;
            }

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();


                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE postagens SET titulo = '{titulo}', fk_categoria = {categoria}, texto = '{texto}'  WHERE id_post = {codigo}";
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