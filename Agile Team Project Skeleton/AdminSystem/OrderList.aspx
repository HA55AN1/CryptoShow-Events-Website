<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 159px; top: 554px; position: absolute" Text="Return to Main Menu" />
            <asp:Label ID="lblStaffNote" runat="server" style="z-index: 1; left: 115px; top: 488px; position: absolute" Text="Staff Note:"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 224px; top: 487px; position: absolute; width: 166px;"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 130px; top: 519px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 265px; top: 519px; position: absolute" Text="Clear Filter" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 86px; top: 48px; position: absolute; height: 399px; width: 330px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 145px; top: 453px; position: absolute" Text="Add" width="55px" OnClick="btnAdd_Click" />
        </div>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 223px; top: 453px; position: absolute" Text="Edit" width="55px" OnClick="btnEdit_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 450px; top: 54px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 303px; top: 453px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
