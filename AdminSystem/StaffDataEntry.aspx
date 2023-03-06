<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 395px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 25px; top: 130px; position: absolute; width: 111px" Text="Password"></asp:Label>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 25px; top: 54px; position: absolute; height: 24px; width: 111px; bottom: 499px;" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 199px; top: 52px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 25px; top: 94px; position: absolute; right: 1376px; bottom: 461px;" Text="Username" width="111px"></asp:Label>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 28px; top: 167px; position: absolute; width: 111px" Text="Role"></asp:Label>
        <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 28px; top: 206px; position: absolute; width: 111px" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 199px; top: 91px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 199px; top: 128px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 199px; top: 167px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 199px; top: 215px; position: absolute" width="168px"></asp:TextBox>
        <asp:CheckBox ID="chkAdmin" runat="server" style="z-index: 1; left: 147px; top: 293px; position: absolute" Text="Admin?" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 150px; top: 360px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 413px; top: 291px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 468px; top: 290px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 475px; top: 125px; position: absolute" Text="Find" />
    </form>
</body>
</html>
