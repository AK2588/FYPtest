<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Template.aspx.cs" Inherits="Template" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="styles.css"/>
    <title></title> 

   
</head>
<body>
<form id="form1" runat="server">
    
    
    <header>
        <img class="logo" src="StarlightLogo.png" alt="logo" />
        <nav>
          <ul class="nav__links">
            <li><a href="HomePage.aspx" id="homebtn">Home</a></li>
            <li><a href="Practice1.aspx" id="orderbtn">Order</a></li>
            <li><a href="StockList.aspx" id="stockbtn">Stock</a></li>
            <li><a href="StaffList.aspx" id="staffbtn">Staff</a></li>
            <li><a href="CustomerList.aspx" id="customerbtn">Customer</a></li>
        </ul>
      </nav>
        <a class="cta">
            <asp:Button ID="logoutbtn" runat="server" Text="Logout" OnClick="btnLogout_Click" CssClass="button"/>
        </a>
     
    </header>
  

</form>
</body>
</html>
