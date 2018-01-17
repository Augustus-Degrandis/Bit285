<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .div {
            margin: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <div>Last Name:<asp:TextBox ID="lastName" runat="server"></asp:TextBox></div>
            <div>Birth Year:<asp:TextBox ID="birthYear" runat="server"></asp:TextBox></div>
            <div>Favorite Color:<asp:TextBox ID="favColor" runat="server"></asp:TextBox></div>
            <asp:Button ID="submitbutton" runat="server" Text="Suggest Passwords >>>" OnClick="submitbutton_Click" />
            <asp:ListBox ID="ListBox" runat="server"></asp:ListBox>
    </form>
</body>
</html>