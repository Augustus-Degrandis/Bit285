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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lastName" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            
            <div>Birth Year:<asp:TextBox ID="birthYear" runat="server"></asp:TextBox></div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ControlToValidate="birthYear" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="birthYear" Type="Integer" MinimumValue="1900" MaximumValue="2018" ErrorMessage="Enter a valid birth year"></asp:RangeValidator>
            
            <div>Favorite Color:<asp:TextBox ID="favColor" runat="server"></asp:TextBox></div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="favColor" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            
        
            <asp:Button ID="submitbutton" runat="server" Text="Suggest Passwords >>>" OnClick="submitbutton_Click" />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </form>
</body>
</html>