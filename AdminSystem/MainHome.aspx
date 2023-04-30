<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainHome.aspx.cs" Inherits="MainHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css"/>

    <title>Home</title>
    
</head>
<body>

    <header>
        <img class="logo" src="StarlightLogo.png" alt="logo" />
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
<form runat="server">
    

    <p class="centre">
     <asp:Button ID="btnOrderPage" runat="server" Text="Order" OnClick="btnOrderPage_Click" CssClass="button"/>
     <asp:Button ID="btnStockPage" runat="server" Text="Stock" OnClick="btnStockPage_Click" CssClass="button"/>
     
    <br /><br />

     <asp:Button ID="btnEmployeePage" runat="server" Text="Employee" OnClick="btnEmployeePage_Click" CssClass="button"/>
     <asp:Button ID="btnCustomerPage" runat="server" Text="Customer" OnClick="btnCustomerPage_Click" CssClass="button"/>
     
    <br /><br />

     <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" CssClass="button"/>
   
    </p>



    <p class="main-home-col">
        <br />
        <asp:ImageButton ID="ImageButtonOrder" runat="server" CssClass="img-btn" ImageUrl="~/images/home-main2.png" OnClick="btnOrderPage_Click" />
        <asp:ImageButton ID="ImageButtonStock" runat="server" CssClass="img-btn" ImageUrl="~/images/stock-main.jpg" />
        <asp:ImageButton ID="ImageButtonStaff" runat="server" CssClass="img-btn" ImageUrl="~/images/staff-main.jpg" />
        <asp:ImageButton ID="ImageButtonCustomer" runat="server" CssClass="img-btn" ImageUrl="~/images/customer-main.jpg" />
        <br /><br />
    </p>

    <p class="main-home-col">
        
        <asp:ImageButton ID="ImageButton5" runat="server" CssClass="img-btn" ImageUrl="~/images/logout-main.jpg" />

    </p>




</form>
</body>
</html>
