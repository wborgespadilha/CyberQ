<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pão de batata</title>

    <!-- Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">

    <!-- CSS -->
    <style>
        form{
            width: 50%;
            margin :5% auto;
            text-align: center;
        }

        input{
            margin-bottom: 10px;
        }
    </style>

</head>
<body>


    <form id="FormularioCadastro" runat="server">
        <h1>Cadastrar Cidades</h1>
        <asp:TextBox ID="Cidade" runat="server" CssClass="form-control" placeholder="Nome da cidade"></asp:TextBox>
        <asp:Button ID="BotaoCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-primary" OnClick="BotaoCadastro_Click"/>
        <asp:Table ID="Tabela" runat="server" CssClass="table table-striped"></asp:Table>
    </form>


<%--    <form id="form1" runat="server">
    <h1>Hellor wORDLS</h1>
    <h2><% Response.Write(DateTime.Now); %></h2>

    <table border="1">
        <thead>
            <tr>
                <th>Número</th>
            </tr>
        </thead>

        <tbody>
            <% 
                for(int i = 1; i < 11; i++)
                {
                    Response.Write("<tr>");
                    Response.Write("<td>"+i+"<td>");
                    Response.Write("</tr>");
                }
            %>
        </tbody>
    </table>

        <asp:Button ID="Button1" runat="server" Height="20px" OnClick="Button1_Click" Text="Button" Width="125px" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>--%>

</body>
</html>
