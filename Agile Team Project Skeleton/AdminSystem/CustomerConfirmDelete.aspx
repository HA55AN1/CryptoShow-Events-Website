<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 340px; top: 259px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 355px; top: 318px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 561px; top: 317px; position: absolute" Text="No" />
    </form>
</body>
</html>
