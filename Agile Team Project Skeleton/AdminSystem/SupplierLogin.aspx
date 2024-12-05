<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 18px; top: 50px; position: absolute" Text="Supplier Login Page"></asp:Label>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 40px; top: 128px; position: absolute" Text="UserName:"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" height="19px" style="z-index: 1; left: 40px; top: 168px; position: absolute" Text="Password:" width="69px"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" height="22px" style="z-index: 1; left: 135px; top: 129px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 135px; top: 169px; position: absolute" TextMode="Password" width="128px"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 313px; top: 153px; position: absolute"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 208px; top: 220px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" height="31px" width="60px" />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; top: 220px; position: absolute; left: 133px; height: 31px;" Text="Login" width="60px" />
        </div>
    </form>
</body>
</html>
