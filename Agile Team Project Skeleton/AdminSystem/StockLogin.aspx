<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Stock Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 60px; top: 109px; position: absolute" Text="UserName:"></asp:Label>
        </p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 61px; top: 144px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 141px; top: 108px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 141px; top: 143px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 107px; top: 211px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 196px; top: 211px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" BorderColor="Black" ForeColor="#FF3300" style="z-index: 1; left: 300px; top: 191px; position: absolute"></asp:Label>
    </form>
</body>
</html>
