<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css"/>
    <title>Stock</title>
</head>
<body>


    <header>
        <img class="logo" src="images/StarlightLogo.png" alt="logo" />
        <nav>
          <ul class="nav__links">
            <li><a href="MainHome.aspx" id="homebtn">Home</a></li>
            <li><a href="Practice1.aspx" id="orderbtn">Order</a></li>
            <li><a href="StockList.aspx" id="stockbtn">Stock</a></li>
            <li><a href="CustomerList.aspx" id="customerbtn">Customer</a></li>
        </ul>
      </nav>
    </header>


    <form id="form1" runat="server">

            <div class="data-row">
            <br />
            <br />
            <br />
            <asp:ListBox ID="lstStockList" runat="server" Height="472px" Width="440px" CssClass="data-list"></asp:ListBox>
            </div>

            <br />

            <div class="data-row">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="data-button" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="data-button" />
            </div>

            <br />
            <br />

            <div class="data-row">
            Search a Game Name&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFilter" runat="server" CssClass="data-textbox"></asp:TextBox>
        
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Search" CssClass="data-button" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" CssClass="data-button" />
            </div>

            <br />
            <br />

            <div class="data-row">
            <asp:Label ID="lblError" runat="server" Text="" CssClass="data-button"></asp:Label>
            </div>
            <br />
            <br />
      
    </form>
</body>
</html>
