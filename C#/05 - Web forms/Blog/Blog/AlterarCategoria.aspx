<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarCategoria.aspx.cs" Inherits="Blog.AlterarCategoria" %>

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
    <title>Alterar Categoria</title>

     <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">


</head>
<body>
    <form id="form1" runat="server">
        
        <br />

        <asp:TextBox ID="NomeCategoria" runat="server" placeholder="Novo nome"></asp:TextBox>
        <asp:Button ID="Salvar" runat="server" Text="Salvar" Width="114px" CssClass="btn btn-primary" OnClick="Salvar_Click" />

        <br />

        <asp:Label ID="LabelErro" runat="server" Text=""></asp:Label>

        <br />
        <br />

        <asp:Button ID="Voltar" runat="server" Text="Voltar" CssClass="btn btn-danger" OnClick="Voltar_Click"/>
        
    </form>
</body>
</html>
