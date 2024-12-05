<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 395px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 246px; top: 365px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 94px; top: 404px; position: absolute; width: 211px;" Text="Return to Main Menu" />
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 176px; top: 15px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPaid" runat="server" style="z-index: 1; left: 216px; top: 63px; position: absolute" Text="Paid" />
        <asp:Label ID="lblDatePlaced" runat="server" style="z-index: 1; left: 78px; top: 117px; position: absolute" Text="Date Placed"></asp:Label>
        <asp:Label ID="lblDeliveryType" runat="server" style="z-index: 1; left: 72px; top: 171px; position: absolute" Text="Delivery Type"></asp:Label>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 86px; top: 18px; position: absolute; bottom: 639px;" Text="Order ID"></asp:Label>
        <asp:Label ID="lblStaffNote" runat="server" style="z-index: 1; left: 83px; top: 220px; position: absolute" Text="Staff Note"></asp:Label>
        <asp:Label ID="lblCustomerNote" runat="server" style="z-index: 1; left: 68px; top: 269px; position: absolute" Text="Customer Note"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 99px; top: 313px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtDatePlaced" runat="server" style="z-index: 1; left: 176px; top: 118px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryType" runat="server" style="z-index: 1; left: 176px; top: 171px; position: absolute"></asp:TextBox>
        <asp:TextBox runat="server" style="z-index: 1; left: 176px; top: 222px; position: absolute" ID="txtStaffNote"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNote" runat="server" style="z-index: 1; left: 176px; top: 270px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 176px; top: 313px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 465px; position: absolute"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 91px; top: 364px; position: absolute; width: 98px" Text="Submit" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 365px; top: 13px; position: absolute" Text="Find" />
    </form>
</body>
</html>
