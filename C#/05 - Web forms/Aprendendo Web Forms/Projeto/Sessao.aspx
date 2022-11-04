<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessao.aspx.cs" Inherits="Projeto.Sessao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <h1>Nome: <%Response.Write(Session["nome"]); %></h1>
        <asp:Button ID="Button1" runat="server" Text="Criar Sessão" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Remover Sessão" OnClick="Button2_Click" />
    </form>
</body>
</html>
