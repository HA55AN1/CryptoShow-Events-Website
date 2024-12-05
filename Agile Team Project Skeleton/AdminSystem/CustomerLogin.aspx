<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 40px; position: absolute" Text="Customer Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 15px; top: 78px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 14px; top: 118px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 99px; top: 76px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 100px; top: 119px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 39px; top: 185px; position: absolute; right: 1426px;" Text="Login" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 146px; top: 185px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 292px; top: 96px; position: absolute"></asp:Label>
    </form>
</body>
</html>
