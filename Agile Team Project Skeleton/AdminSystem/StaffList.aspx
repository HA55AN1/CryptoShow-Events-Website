<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title></head><body><form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStafflist" runat="server" style="z-index: 1; left: 22px; top: 37px; position: absolute; height: 285px; width: 460px"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" style="z-index: 1; left: 52px; top: 331px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 146px; top: 331px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 242px; top: 331px; position: absolute" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 52px; top: 571px; position: absolute" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 52px; top: 408px; position: absolute" Text="Enter a Job Title:"></asp:Label>
        <asp:TextBox ID="textboxFilter" runat="server" style="z-index: 1; left: 229px; top: 408px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 52px; top: 478px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 228px; top: 478px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 429px; top: 478px; position: absolute" Text="Return To Main Menu" />
    </form>
</body>
</html>
