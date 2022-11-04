<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Blog.Admin" %>

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
    <title>Blog admin</title>

    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">


</head>
<body>
    <form id="form1" runat="server">

        <br />

        <asp:Button ID="Sair" runat="server" Text="Sair" Cssclass="btn btn-danger" OnClick="Sair_Click1" />

        <br />
        <br />

        <div>
            <asp:TextBox ID="NomeCategoria" runat="server" placeholder="Nova Categoria"></asp:TextBox>

            <br />

            <asp:Button ID="CadastrarCategoria" runat="server" Cssclass="btn btn-primary" OnClick="CadastrarCategoria_Click" Text="Cadastrar" />

            <br />

            <asp:Label ID="LabelRetorno" runat="server" Text=""></asp:Label>
        </div>

        <br />

        <div>
            <asp:Table ID="TabelaCategorias" runat="server" CssClass="table table-striped"></asp:Table>
        </div>

        <br />

        <div>
            <asp:Label ID="LabelLst" runat="server" Text="Categoria:"></asp:Label>
            <asp:DropDownList ID="ListaCategorias" CssClass="btn btn-success dropdown-toggle" runat="server"></asp:DropDownList>

            <br />

            <asp:TextBox ID="TituloPostagem" runat="server" placeholder="Título nova postagem"></asp:TextBox>

            <br />

            <textarea id="TextoPostagem" name="TextoPostagem" cols="20" rows="2" placeholder="Texto nova postagem"></textarea>

            <br />

            <asp:Button ID="CadastrarPostagem" runat="server" Text="Cadastrar Postagem" Cssclass="btn btn-primary" OnClick="CadastrarPostagem_Click"/>
        </div>

        <br />

        <div>
            <asp:Table ID="TabelaPostagens" runat="server" CssClass="table table-striped"></asp:Table>
        </div>

    </form>
</body>
</html>
