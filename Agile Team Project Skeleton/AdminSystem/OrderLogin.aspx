<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 75px; top: 148px; position: absolute" Text="Login" />
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 116px; top: 111px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 117px; top: 72px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 33px; top: 73px; position: absolute" Text="User Name:"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 36px; top: 112px; position: absolute" Text="Password:"></asp:Label>
        </p>
        <asp:Label ID="lbOrderLogin" runat="server" style="z-index: 1; left: 12px; top: 16px; position: absolute" Text="Order Login Page"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 159px; top: 148px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 116px; top: 201px; position: absolute"></asp:Label>
    </form>
</body>
</html>
