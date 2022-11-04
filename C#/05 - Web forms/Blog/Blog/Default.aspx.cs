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
    public partial class Defaukt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var failed = Request.QueryString["failed"];

            if(failed != null)
            {
                Erro.Text = "Login ou senha incorretos.";
            }

            var error = Request.QueryString["error"];

            if(error != null)
            {
                Erro.Text = "Um erro ocorreu durante a autenticação: " + error;
            }

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT postagens.id_post, postagens.titulo, categorias.nome, postagens.texto FROM postagens INNER JOIN categorias ON categorias.id_categoria = postagens.fk_categoria ORDER BY postagens.id_post DESC FETCH NEXT 10 ROWS ONLY";
                cmd.Connection = con;

                TableHeaderCell coluna1 = new TableHeaderCell();
                coluna1.Text = "ID";

                TableHeaderCell coluna2 = new TableHeaderCell();
                coluna2.Text = "Título";

                TableHeaderCell coluna3 = new TableHeaderCell();
                coluna3.Text = "Categoria";

                TableHeaderCell coluna4 = new TableHeaderCell();
                coluna4.Text = "Texto";

                TableHeaderRow linha = new TableHeaderRow();

                linha.Cells.Add(coluna1);
                linha.Cells.Add(coluna2);
                linha.Cells.Add(coluna3);
                linha.Cells.Add(coluna4);

                Tabela.Rows.AddAt(0, linha);

                OracleDataReader odr = cmd.ExecuteReader();

                while (odr.Read())
                {
                    TableRow tr = new TableRow();

                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();
                    TableCell tc4 = new TableCell();

                    tc1.Controls.Add(new LiteralControl(odr.GetString(0)));
                    tc2.Controls.Add(new LiteralControl(odr.GetString(1)));
                    tc3.Controls.Add(new LiteralControl(odr.GetString(2)));
                    tc4.Controls.Add(new LiteralControl(odr.GetString(3)));

                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    tr.Cells.Add(tc3);
                    tr.Cells.Add(tc4);

                    Tabela.Rows.Add(tr);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Falha ao realizar a conexão:" + ex.Message);
            }
        }

        protected void Logar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sessao.aspx?usuario=" + Usuario.Text + "&senha=" + Senha.Text,false);
        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Pesquisa.aspx?termo=" + TextoPesquisa.Text);

        }
    }
}