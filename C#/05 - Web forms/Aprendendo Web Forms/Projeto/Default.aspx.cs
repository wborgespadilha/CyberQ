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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Conexão
                Conexao c = new Conexao();
                OracleConnection con = c.RealizarConexao();
                con.Open();

                // SQL
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM cidades ORDER BY codigo_cidade";
                cmd.Connection = con;

                // Colunas da tabela
                TableHeaderCell coluna1 = new TableHeaderCell();
                coluna1.Text = "Código";

                TableHeaderCell coluna2 = new TableHeaderCell();
                coluna2.Text = "Cidade";

                TableHeaderCell coluna3 = new TableHeaderCell();
                coluna3.Text = "Remover";

                // Linha da tabela
                TableHeaderRow linha = new TableHeaderRow();

                // Adicionar colunas na linha
                linha.Cells.Add(coluna1);
                linha.Cells.Add(coluna2);
                linha.Cells.Add(coluna3);

                //Adicionar linha e as colunas
                Tabela.Rows.AddAt(0, linha);

                // Executar comando SQL
                OracleDataReader odr = cmd.ExecuteReader();

                // Laço de repetição
                while(odr.Read())
                {
                    // Linha de tabela
                    TableRow tr = new TableRow();

                    //Colunas 
                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();

                    // Hyperlink
                    HyperLink hl = new HyperLink();
                    hl.Text = "Remover";
                    hl.CssClass = "btn btn-danger";
                    hl.NavigateUrl = "Remover.aspx?codigo=" + odr.GetString(0);

                    //Adicionar valores nas colunas
                    tc1.Controls.Add(new LiteralControl(odr.GetString(0)));
                    tc2.Controls.Add(new LiteralControl(odr.GetString(1)));
                    tc3.Controls.Add(hl);

                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    tr.Cells.Add(tc3);

                    Tabela.Rows.Add(tr);
                }

            }
            catch (Exception ex)
            {
                Response.Write("Falha ao realizar a conexão:" + ex.Message);
            }
        }

        protected void BotaoCadastro_Click(object sender, EventArgs e)
        {
            try
            {

                //Instanciar um objeto da classe conexão
                Conexao c = new Conexao();

                // Oracle Connection
                OracleConnection con = c.RealizarConexao();

                // Abrir conexão
                con.Open();

                //Oracle Command (Executar comandos SQL)
                OracleCommand cmd = new OracleCommand();

                // Informar os parâmetros para o comando SQL
                cmd.Parameters.Add(":cidade", Cidade.Text);

                // Especificar cláusula SQL (INSERT, UPDATE, SELECT ou DELETE)
                cmd.CommandText = "INSERT INTO cidades (nome_cidade) VALUES (:nome)";

                // Informar o acesso ao bd para o cmd
                cmd.Connection = con;

                // Retornar a quantidade de linhas que foram inseridas/modificadas/removidas
                int linhas = cmd.ExecuteNonQuery();

                // Condicional
                if(linhas == 0)
                {
                    Response.Write("Falha ao cadastrar");
                }
                else
                {
                    Response.Redirect("Default.aspx");
                    //Response.Write("Cidade cadastrada com sucesso!");
                }

            }
            catch(Exception ex)
            {
                Response.Write("Falha ao cadastrar " + ex.Message);
            }
        }
    }
}