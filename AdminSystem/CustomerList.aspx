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
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 35px; position: absolute; height: 261px; width: 347px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 310px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 67px; top: 310px; position: absolute; height: 26px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 465px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 118px; top: 310px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 15px; top: 420px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 80px; top: 422px; position: absolute" Text="Clear" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 18px; top: 374px; position: absolute" Text="Enter a Username"></asp:Label>
        <asp:TextBox ID="tbxInput" runat="server" style="z-index: 1; left: 138px; top: 373px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
