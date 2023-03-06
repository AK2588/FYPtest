<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 136px; top: 33px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 10px; top: 35px; position: absolute; bottom: 623px" Text="Customer Number"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 11px; top: 64px; position: absolute" Text="Username" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerUsername" runat="server" style="z-index: 1; left: 136px; top: 62px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 91px; position: absolute" Text="Password" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerPassword" runat="server" style="z-index: 1; left: 136px; top: 88px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 11px; top: 125px; position: absolute" Text="Address" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 136px; top: 122px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 157px; position: absolute" Text="Date Added" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerDateAdded" runat="server" style="z-index: 1; left: 135px; top: 155px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="cbxCustomerActive" runat="server" style="z-index: 1; left: 7px; top: 185px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 225px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 266px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 56px; top: 266px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 288px; top: 32px; position: absolute" Text="Find" />
    </form>
</body>
</html>
