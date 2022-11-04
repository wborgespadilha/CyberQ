<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarPostagem.aspx.cs" Inherits="Blog.AlterarPostagem" %>

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
    <title>Alterar Postagem</title>

    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">


</head>
<body>
    <form id="form1" runat="server">

        <br />

        <div>

            <asp:Label ID="LabelLst" runat="server" Text="Categoria:"></asp:Label>
            <asp:DropDownList ID="ListaCategorias" CssClass="btn btn-success dropdown-toggle" runat="server"></asp:DropDownList>

            <br />

            <asp:TextBox ID="TituloPostagem" runat="server" placeholder="Título nova postagem"></asp:TextBox>

            <br />

            <textarea id="TextoPostagem" name="TextoPostagem" cols="20" rows="2" placeholder="Texto nova postagem"></textarea>

        </div>

        <asp:Button ID="Salvar" runat="server" Text="Salvar" Width="114px" CssClass="btn btn-primary" OnClick="Salvar_Click" />

        <br />

        <asp:Label ID="LabelErro" runat="server" Text=""></asp:Label>

        <br />
        <br />

        <asp:Button ID="Voltar" runat="server" Text="Voltar" CssClass="btn btn-danger" OnClick="Voltar_Click"/>
        
    </form>
</body>
</html>
