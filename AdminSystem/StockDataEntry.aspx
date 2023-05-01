<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            <li><a href="StaffList.aspx" id="staffbtn">Staff</a></li>
            <li><a href="CustomerList.aspx" id="customerbtn">Customer</a></li>
        </ul>
      </nav>
    </header>





    <form id="form1" runat="server">
        <div class="data-col">

            <div class="data-row">
            <asp:Label ID="lblGameID" runat="server" Text="Game ID" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtGameID" runat="server" Width="134px" CssClass="data-textbox"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" CssClass="data-button" />
            </div>
            
            <br />

            <div class="data-row">
            <asp:Label ID="lblGameName" runat="server" Text="Game Name" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtGameName" runat="server" width="217px" CssClass="data-textbox"></asp:TextBox>
            </div>
            
            <br />

            <div class="data-row">
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPrice" runat="server" width="210px" CssClass="data-textbox"></asp:TextBox>
            </div>
            
            <br />

            <div class="data-row">
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availabile" />
            </div>
            
            <br />

            <div class="data-row">
            <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtReleaseDate" runat="server" width="214px" CssClass="data-textbox"></asp:TextBox>
            </div>
            
            <br />

            <div class="data-row">
            <asp:Label ID="lblAgeRating" runat="server" Text="Age Rating" width="118px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAgeRating" runat="server" width="211px" CssClass="data-textbox"></asp:TextBox>
            </div>
            
            <br />
            <br />

            <div class="data-row">
            <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
            
            <br />

            <div class="data-row">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" CssClass="data-button"/>
       &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="data-button" />
            </div>
            
            <br />


        </div>
        <br />
    </form>
</body>
</html>
