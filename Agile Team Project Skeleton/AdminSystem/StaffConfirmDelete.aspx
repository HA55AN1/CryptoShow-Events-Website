<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 191px; width: 713px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 181px; top: 60px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 223px; top: 103px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 328px; top: 103px; position: absolute" Text="No" />
        </p>
    </form>
</body>
</html>
