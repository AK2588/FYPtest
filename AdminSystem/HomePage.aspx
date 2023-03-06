<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 431px;
            height: 148px;
        }
    </style>
</head>
<body>
   <div class="HomePage" >
       
       <h2>&nbsp;</h2>
       <h2>
           <img alt="logo1" class="auto-style2" src="StarlightLogo.png" /></h2>
       <h2>&nbsp;</h2>
       <h2>Home Page</h2>
       <form runat="server">
           <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" Text="Order" OnClick="btnOrderPage_Click" CssClass="btnOrderPage, btnStockPage, btnEmployeePage, btnCustomerPage, btnLogout" />
            <asp:Button ID="Button2" runat="server" Text="Stock" OnClick="btnStockPage_Click" CssClass="btnOrderPage, btnStockPage, btnEmployeePage, btnCustomerPage, btnLogout" />
        </p>
        <p class="auto-style1">
            <asp:Button ID="Button3" runat="server"  Text="Employee"  OnClick="btnEmployeePage_Click" CssClass="btnOrderPage, btnStockPage, btnEmployeePage, btnCustomerPage, btnLogout" />
            <asp:Button ID="Button4" runat="server"  Text="Customer"  OnClick="btnCustomerPage_Click" CssClass="btnOrderPage, btnStockPage, btnEmployeePage, btnCustomerPage, btnLogout" />
        </p>
        <p class="auto-style1">
            <asp:Button ID="Button5" runat="server"  Text="Logout"  OnClick="btnLogout_Click" CssClass="btnOrderPage, btnStockPage, btnEmployeePage, btnCustomerPage, btnLogout" />
        </p>
       </form>
   </div>
    
    
    
    
</body>
</html>
