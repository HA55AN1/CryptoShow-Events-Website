<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffLoginPage" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Staff Login Page"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 188px; top: 126px; position: absolute; height: 16px; width: 121px;"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 62px; top: 179px; position: absolute" Text="Password:" width="83px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 188px; top: 179px; position: absolute; height: 16px; width: 121px;" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 115px; top: 237px; position: absolute; right: 1308px" Text="Login" width="62px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 240px; top: 237px; position: absolute; width: 62px;" Text="Cancel" OnClick="btnCancel_Click" height="26px" />        
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 62px; top: 122px; position: absolute; right: 1052px;" Text="UserName:"></asp:Label>        
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 413px; top: 172px; position: absolute"></asp:Label>
    </form>
</body>
</html>
