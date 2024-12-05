<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 115px; top: 288px; position: absolute" Text="Edit" height="26px" width="55px" />
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 304px; top: 463px; position: absolute; width: 153px" Text="Return to Main Menu" />
            <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 22px; top: 45px; position: absolute; height: 231px; width: 288px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 29px; top: 288px; position: absolute" Text="Add" height="26px" width="55px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 202px; top: 288px; position: absolute" Text="Delete" height="26px" width="55px" />
            <asp:Label ID="lblFilterAddress" runat="server" style="z-index: 1; left: 20px; top: 335px; position: absolute" Text="Enter an Address"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 431px; position: absolute" ForeColor="#FF3300"></asp:Label>
            <asp:TextBox ID="txtFilterAddress" runat="server" style="z-index: 1; left: 141px; top: 328px; position: absolute; width: 157px; height: 26px;"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 51px; top: 380px; position: absolute; height: 32px;" Text="Apply Filter" width="100px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 173px; top: 380px; position: absolute" Text="Clear Filter" height="32px" width="100px" />
        </div>
    </form>
</body>
</html>
