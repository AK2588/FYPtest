<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
    <div class="data-col">    
        
        <div class="data-row">
        <asp:Label ID="lblCustomerNo" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="data-textbox"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" CssClass="data-button"/>
        </div>

        <br />
        
        <div class="data-row">
        <asp:Label ID="lblUsername" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtCustomerUsername" runat="server" CssClass="data-textbox"></asp:TextBox>
        </div>

        <br />

        <div class="data-row">
        <asp:Label ID="Label1" runat="server" Text="Password" ></asp:Label>
        <asp:TextBox ID="txtCustomerPassword" runat="server" CssClass="data-textbox"></asp:TextBox>
        </div>

        <br />
        
        <div class="data-row">
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Postcode"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" CssClass="data-textbox"></asp:TextBox>
        </div>

        <br />

        <div class="data-row">
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtCustomerDateAdded" runat="server" CssClass="data-textbox"></asp:TextBox>
        </div>

        <br />

        <div class="data-row">
        <asp:CheckBox ID="cbxCustomerActive" runat="server" Text="Active" />
        </div>
        
        <br />

        <div class="data-row">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" CssClass="data-button"/>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="data-button"/>
        
        </div>

        <br />

        <asp:Label ID="lblError" runat="server" ></asp:Label>





    </div>
    </form>
</body>
</html>
