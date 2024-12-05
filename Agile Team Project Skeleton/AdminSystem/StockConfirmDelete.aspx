<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 254px">
    <form id="form1" runat="server">
        <div style="height: 412px">
            <asp:Label ID="tblAssure" runat="server" style="z-index: 1; left: 137px; top: 99px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 193px; top: 140px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 296px; top: 140px; position: absolute" Text="No" />
        </div>
    </form>
</body>
</html>
