<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainHome.aspx.cs" Inherits="MainHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css"/>

    <title>Home</title>
    
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
<form runat="server">
    

    <div class="main-home">
    <div class="main-home-col">
        <h2>Order</h2>
        <asp:ImageButton ID="ImageButtonOrder" runat="server" CssClass="img-btn" ImageUrl="~/images/home-main.jpg" OnClick="btnOrderPage_Click" />
    </div>

    <div class="main-home-col">
        <h2>Stock</h2>
        <asp:ImageButton ID="ImageButton4" runat="server" CssClass="img-btn" ImageUrl="~/images/stock-main.jpg" OnClick="btnStockPage_Click" />
    </div>

    <div class="main-home-col">
        <h2>Customer</h2>
        <asp:ImageButton ID="ImageButton2" runat="server" CssClass="img-btn" ImageUrl="~/images/customer-main.jpg" OnClick="btnCustomerPage_Click" />
    </div>

    </div>




</form>
</body>
</html>
