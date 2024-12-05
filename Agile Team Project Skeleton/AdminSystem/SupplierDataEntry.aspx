<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 421px; margin-left: 4440px;">
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 13px; top: 28px; position: absolute" Text="Supplier ID" width="115px"></asp:Label>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 13px; top: 108px; position: absolute" Text="Email" width="115px"></asp:Label>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 13px; top: 69px; position: absolute" Text="Name" width="115px"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 148px; position: absolute" Text="Phone Number" width="115px"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 13px; top: 191px; position: absolute" Text="Address" width="115px"></asp:Label>
            <asp:Label ID="lblLastOrderDate" runat="server" style="z-index: 1; left: 13px; top: 232px; position: absolute" Text="Last Ordered Date"></asp:Label>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 163px; top: 273px; position: absolute" Text="Is Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 306px; position: absolute"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 187px; top: 333px; position: absolute" Text="Cancel" height="26px" width="60px" OnClick="btnCancel_Click" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 106px; top: 333px; position: absolute; right: 1304px;" Text="Ok" height="26px" width="60px" />
            <asp:Button ID="btnFind" runat="server" height="26px" OnClick="btnFind_Click" style="z-index: 1; left: 344px; top: 24px; position: absolute" Text="Find" width="60px" />
            <asp:TextBox ID="txtSupplierId" runat="server" height="22px" style="z-index: 1; left: 149px; top: 23px; position: absolute" width="160px"></asp:TextBox>
            <asp:TextBox ID="txtSupplierName" runat="server" height="22px" style="z-index: 1; left: 149px; top: 66px; position: absolute" width="160px"></asp:TextBox>
            <asp:TextBox ID="txtSupplierEmail" runat="server" height="22px" style="z-index: 1; left: 149px; top: 108px; position: absolute" width="160px"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 149px; top: 147px; position: absolute" width="160px"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 149px; top: 193px; position: absolute; width: 160px;"></asp:TextBox>
            <asp:TextBox ID="txtLastOrderDate" runat="server" height="22px" style="z-index: 1; left: 149px; top: 232px; position: absolute" width="160px"></asp:TextBox>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 299px; top: 376px; position: absolute; width: 146px" Text="Return to Main Menu" />
        </div>
    </form>
</body>
</html>
