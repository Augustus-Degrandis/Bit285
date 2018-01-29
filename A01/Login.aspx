<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Please Login</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Error" runat="server" Text="Label" ForeColor="Red" Visible="False">Login ERROR!</asp:Label>
            <div>User Name:<asp:TextBox ID="userName" runat="server"></asp:TextBox></div>
            <div>Password:<asp:TextBox ID="pass" runat="server"></asp:TextBox></div>
            <asp:HyperLink ID="passWordGen" runat="server" NavigateUrl="~/NewAccount.aspx">need a new account?</asp:HyperLink>
            <asp:Button ID="loginSubmit" runat="server" Text="Login" onclick="loginSubmit_Click"/>
        </div>
    </form>
</body>
</html>
