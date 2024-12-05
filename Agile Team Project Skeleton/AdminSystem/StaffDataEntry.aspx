<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 241px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 18px; position: absolute" Text="Staff Id" width="83px"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 120px; top: 18px; position: absolute;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 305px; top: 18px; position: absolute" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 9px; top: 51px; position: absolute" Text="Staff Name" width="83px"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 120px; top: 51px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblJobTitle" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Job Title" width="83px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtJobTitle" runat="server" style="z-index: 1; left: 120px; top: 91px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Staff Email" width="83px"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 120px; top: 129px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Staff Address"></asp:Label>
            <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 120px; top: 167px; position: absolute"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Date Joined" width="83px"></asp:Label>
            <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 120px; top: 205px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkIsAdmin" runat="server" style="z-index: 1; left: 82px; top: 237px; position: absolute" Text="Is Admin" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 273px; position: absolute" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 46px; top: 308px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 104px; top: 308px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
