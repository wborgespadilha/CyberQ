<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="Blog.Pesquisa" %>

<!DOCTYPE html>

<style>
    form{
        text-align: center;
        width: 10px auto;
    }

</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Blog genérico</title>

    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">


</head>
<body>
    <form id="Form" runat="server" >
        
        <div>
            <asp:TextBox ID="TextoPesquisa" runat="server" placeholder="Pesquisar no título ou texto"></asp:TextBox>
            <asp:Button ID="Pesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-primary" OnClick="Pesquisar_Click"/>     
        </div>

        <br />

        <div>
            <asp:TextBox ID="Usuario" runat="server" placeholder="Usuário"></asp:TextBox>
            <asp:TextBox ID="Senha" runat="server" placeholder="Senha"></asp:TextBox>
            <asp:Button ID="Logar" runat="server" Text="Logar" CssClass="btn btn-warning" Width="93px" OnClick="Logar_Click" />
        </div>

        <br />

        <div>
            <asp:Table ID="Tabela" runat="server" CssClass="table table-striped"></asp:Table>
        </div>

    </form>
</body>
</html>
