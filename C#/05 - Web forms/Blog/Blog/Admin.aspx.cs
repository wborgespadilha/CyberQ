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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idLogado = Session["id"];

            var success = Request.QueryString["success"];

            if (success != null)
            {
                LabelRetorno.Text = "Operação realizada com sucesso!";
            }

            var error = Request.QueryString["error"];

            if (error != null)
            {
                LabelRetorno.Text = "Um erro ocorreu durante a operação: " + error;
            }

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"SELECT * FROM admins WHERE id_admin = {idLogado}";
                cmd.Connection = con;

                int contador = 0;

                OracleDataReader odr = cmd.ExecuteReader();

                while (odr.Read())
                {
                    contador++;
                }

                if(contador != 1)
                {
                    Response.Redirect("Default.aspx?failed=1", false);
                }

            }
            catch(Exception ex)
            {
                Response.Redirect("Default.aspx?error=" + ex.Message, false);
            }

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM categorias ";
                cmd.Connection = con;

                TableHeaderCell coluna1 = new TableHeaderCell();
                coluna1.Text = "Categoria ID";

                TableHeaderCell coluna2 = new TableHeaderCell();
                coluna2.Text = "Categoria Nome";

                TableHeaderCell coluna3 = new TableHeaderCell();
                coluna3.Text = "Alterar";

                TableHeaderCell coluna4 = new TableHeaderCell();
                coluna4.Text = "Remover";

                TableHeaderRow linha = new TableHeaderRow();

                linha.Cells.Add(coluna1);
                linha.Cells.Add(coluna2);
                linha.Cells.Add(coluna3);
                linha.Cells.Add(coluna4);

                TabelaCategorias.Rows.AddAt(0, linha);

                OracleDataReader odr = cmd.ExecuteReader();

                ListaCategorias.Items.Clear();

                while (odr.Read())
                {
                    ListItem lst = new ListItem(odr.GetString(1), odr.GetString(0));
                    ListaCategorias.Items.Insert(ListaCategorias.Items.Count ==0 ? 0 : ListaCategorias.Items.Count - 1, lst);

                    TableRow tr = new TableRow();

                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();
                    TableCell tc4 = new TableCell();


                    HyperLink hl = new HyperLink();
                    hl.Text = "Alterar";
                    hl.CssClass = "btn btn-warning";
                    hl.NavigateUrl = "AlterarCategoria.aspx?codigo=" + odr.GetString(0);

                    HyperLink hl1 = new HyperLink();
                    hl1.Text = "Remover";
                    hl1.CssClass = "btn btn-danger";
                    hl1.NavigateUrl = "DeletarCategoria.aspx?codigo=" + odr.GetString(0);

                    tc1.Controls.Add(new LiteralControl(odr.GetString(0)));
                    tc2.Controls.Add(new LiteralControl(odr.GetString(1)));
                    tc3.Controls.Add(hl);
                    tc4.Controls.Add(hl1);

                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    tr.Cells.Add(tc3);
                    tr.Cells.Add(tc4);

                    TabelaCategorias.Rows.Add(tr);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Falha ao realizar a conexão:" + ex.Message);
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

                TableHeaderCell coluna5 = new TableHeaderCell();
                coluna5.Text = "Alterar";

                TableHeaderCell coluna6 = new TableHeaderCell();
                coluna6.Text = "Deletar";

                TableHeaderRow linha = new TableHeaderRow();

                linha.Cells.Add(coluna1);
                linha.Cells.Add(coluna2);
                linha.Cells.Add(coluna3);
                linha.Cells.Add(coluna4);
                linha.Cells.Add(coluna5);
                linha.Cells.Add(coluna6);

                TabelaPostagens.Rows.AddAt(0, linha);

                OracleDataReader odr = cmd.ExecuteReader();

                while (odr.Read())
                {
                    TableRow tr = new TableRow();

                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();
                    TableCell tc4 = new TableCell();
                    TableCell tc5 = new TableCell();
                    TableCell tc6 = new TableCell();

                    HyperLink hl = new HyperLink();
                    hl.Text = "Alterar";
                    hl.CssClass = "btn btn-warning";
                    hl.NavigateUrl = "AlterarPostagem.aspx?codigo=" + odr.GetString(0);

                    HyperLink hl1 = new HyperLink();
                    hl1.Text = "Remover";
                    hl1.CssClass = "btn btn-danger";
                    hl1.NavigateUrl = "DeletarPostagem.aspx?codigo=" + odr.GetString(0);

                    tc1.Controls.Add(new LiteralControl(odr.GetString(0)));
                    tc2.Controls.Add(new LiteralControl(odr.GetString(1)));
                    tc3.Controls.Add(new LiteralControl(odr.GetString(2)));
                    tc4.Controls.Add(new LiteralControl(odr.GetString(3)));
                    tc5.Controls.Add(hl);
                    tc6.Controls.Add(hl1);

                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    tr.Cells.Add(tc3);
                    tr.Cells.Add(tc4);
                    tr.Cells.Add(tc5);
                    tr.Cells.Add(tc6);

                    TabelaPostagens.Rows.Add(tr);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Falha ao realizar a conexão:" + ex.Message);
            }

        }

        protected void Sair_Click1(object sender, EventArgs e)
        {
            Session.Remove("id");
            Response.Redirect("Default.aspx", false);
        }

        protected void CadastrarCategoria_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(NomeCategoria.Text) == true)
            {
                Response.Redirect("Admin.aspx?error=Nome Vazio!", false);
                return;
            }

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"INSERT INTO categorias (nome) VALUES ('{NomeCategoria.Text}')";
                cmd.Connection = con;

                int linhas = cmd.ExecuteNonQuery();


                Response.Redirect("Admin.aspx?success=" + linhas, false);
            }
            catch (Exception ex)
            {
                Response.Redirect("Admin.aspx?error=" + ex.Message, false);
            }
        }

        protected void CadastrarPostagem_Click(object sender, EventArgs e)
        {

            string titulo = TituloPostagem.Text;
            string texto = Request.Form["TextoPostagem"];

            ListItem lst = ListaCategorias.Items[ListaCategorias.SelectedIndex];

            int categoria = Convert.ToInt32(lst.Value);

            if (String.IsNullOrEmpty(titulo) == true)
            {
                Response.Redirect("Admin.aspx?error=Nome Vazio!", false);
                return;
            }

            if (String.IsNullOrEmpty(texto) == true)
            {
                Response.Redirect("Admin.aspx?error=Nome Vazio!", false);
                return;
            }

            if(categoria == 0)
            {
                Response.Redirect("Admin.aspx?error=Categoria inválida!", false);
                return;
            }

            try
            {
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = $"INSERT INTO postagens (titulo,fk_categoria,texto) VALUES ('{titulo}',{categoria},'{texto}')";
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