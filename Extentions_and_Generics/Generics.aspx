<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generics.aspx.cs" Inherits="Extentions_and_Generics.Generics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generic method example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="txtInt">Write a number:</label>
        <br />
        <asp:TextBox ID="txtInt" runat="server" AutoPostBack="true" OnTextChanged="txtInt_TextChanged"></asp:TextBox>
        <br />
        <asp:Literal ID="litInt" runat="server"></asp:Literal>
        <br />
        <br />
        <label for="txtDecimal">Write a decimal:</label>
        <br />
        <asp:TextBox ID="txtDecimal" runat="server" AutoPostBack="true" OnTextChanged="txtDecimal_TextChanged"></asp:TextBox>
        <br />
        <asp:Literal ID="litDecimal" runat="server"></asp:Literal>
        <br />
        <hr />
        <br />
        <a href="Extention.aspx">Extention method example</a>
    </div>
    </form>
</body>
</html>
