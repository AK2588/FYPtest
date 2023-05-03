<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="data-col">
        Are you sure you want to delete this record?<br />
        <br />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="data-button"/>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="data-button"/>
        <br />
        <br />
        </div>
    </form>
</body>
</html>
