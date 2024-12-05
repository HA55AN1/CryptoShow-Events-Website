<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 524px;
            margin-bottom: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 357px">
            <asp:ListBox ID="lstStockList" runat="server"  style="z-index: 1; left: 14px; top: 49px; position: absolute; height: 335px; width: 356px; margin-bottom: 11px;" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-top: 22px; margin-left: 38px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 24px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 29px" Text="Delete" />
        <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 47px; top: 460px; position: absolute" Text="Enter a Car Brand"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 181px; top: 459px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 49px; top: 494px; position: absolute; right: 1465px; width: 94px;" Text="Apply Filter" height="26px" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 187px; top: 494px; position: absolute; margin-left: 0px; margin-right: 15px;" Text="Clear Filter" height="26px" width="94px" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 338px; top: 494px; position: absolute; width: 137px; margin-left: 25px; margin-right: 0px;" Text="Return to Main Menu" height="26px" />
        <p style="height: 28px; margin-top: 135px">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
