<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Extention.aspx.cs" Inherits="Extentions_and_Generics.Extention" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Extention method example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList ID="cblTest" runat="server" AutoPostBack="true">
            <asp:ListItem Value="1" Text="Primeiro"></asp:ListItem>
            <asp:ListItem Value="B" Text="Segundo"></asp:ListItem>
            <asp:ListItem Value="3.4" Text="Terceiro"></asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Literal ID="litReturn" runat="server"></asp:Literal>
        <br />
        <hr />
        <br />
        <a href="Generics.aspx">Generic method example</a>
    </div>
    </form>
</body>
</html>
