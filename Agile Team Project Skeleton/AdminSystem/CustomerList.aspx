<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 88px; position: absolute; height: 393px; width: 446px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 34px; top: 497px; position: absolute" Text="Add" height="26px" width="55px" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 189px; top: 499px; position: absolute" Text="Edit" height="26px" width="55px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 340px; top: 499px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 618px; position: absolute" Text="Apply Filter" width="95px" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 147px; top: 618px; position: absolute; height: 25px;" Text="Clear Filter" width="95px" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 162px; top: 555px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 18px; top: 556px; position: absolute" Text="Enter a Full Name"></asp:Label>
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; top: 618px; position: absolute; bottom: 230px; left: 295px" Text="Return to Main Menu" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 675px; position: absolute" ForeColor="#FF3300"></asp:Label>
        </p>
    </form>
</body>
</html>
