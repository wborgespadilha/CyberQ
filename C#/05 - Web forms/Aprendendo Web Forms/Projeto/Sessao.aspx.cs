using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto
{
    public partial class Sessao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // Criar a sessão
            Session["nome"] = "Adolfo";

            // Atualizar a página
            Response.Redirect("Sessao.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            // Remover a sessão
            Session.Remove("nome");


        }
    }
}