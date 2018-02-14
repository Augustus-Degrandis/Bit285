<% @Page Language="C#" AutoEventWireup="true" CodeFile="NewAccount.aspx.cs" Inherits="NewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>New Account Information</h1>
    <form id="form1" runat="server">
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="fName" runat="server" ErrorMessage="*Required Field"></asp:RequiredFieldValidator>
            <div>First Name<asp:TextBox ID="fName" runat="server"></asp:TextBox></div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="lName" runat="server" ErrorMessage="*Required Field"></asp:RequiredFieldValidator>
            <div>Last Name<asp:TextBox ID="lName" runat="server"></asp:TextBox></div>

            <asp:RequiredFieldValidator ID="emailValidation" ControlToValidate="email" runat="server" ErrorMessage="*Required Field" Enabled="False"></asp:RequiredFieldValidator>
            <div>Email Adress<asp:TextBox ID="email" runat="server"></asp:TextBox></div>
            
            <div>Program Options<asp:DropDownList ID="dropdownlist" runat="server"></asp:DropDownList></div>
            <div><asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" /> email me program updates</div>
            <asp:Button ID="createAccount" runat="server" Text="Create Account" OnClick="createAccount_Click" />
            <asp:Button ID="reset" runat="server" CausesValidation="false" Text="Reset" OnClick="reset_Click" />
        </div>
    </form>
</body>
</html>
