<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css"/>
    <title>Customer</title>

</head>
<body>

    <header>
        <img class="logo" src="images/StarlightLogo.png" alt="logo" />
        <nav>
          <ul class="nav__links">
            <li><a href="MainHome.aspx" id="homebtn">Home</a></li>
            <li><a href="Practice1.aspx" id="orderbtn">Order</a></li>
            <li><a href="StockList.aspx" id="stockbtn">Stock</a></li>
            <li><a href="StaffList.aspx" id="staffbtn">Staff</a></li>
            <li><a href="CustomerList.aspx" id="customerbtn">Customer</a></li>
        </ul>
      </nav>
    </header>



    <form id="form1" runat="server">

        <div class="data-row">
        <asp:ListBox ID="lstCustomerList" runat="server" CssClass="data-list" Height="472px" Width="440px" ></asp:ListBox>
        </div>


        <br />

        <div class="data-row">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="data-button" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="data-button" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" CssClass="data-button" Text="Delete" />
        </div>

        <br />

        <div class="data-row">
        <asp:Label ID="Label1" runat="server" Text="Search a Username"></asp:Label>
        <asp:TextBox ID="tbxInput" runat="server" CssClass="data-textbox"></asp:TextBox>
        
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" CssClass="data-button" Text="Search" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" CssClass="data-button" Text="Clear" />
        </div>

        <br />

        <div class="data-row">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>     

</form>
</body>
</html>
