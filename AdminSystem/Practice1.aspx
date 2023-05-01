<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Practice1.aspx.cs" Inherits="Practice1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script>
        function printpage() {
            window.print()
        }
    </script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65%;
            height: 142px;
            background-color: #CCCCCC;
        }
        .auto-style2 {
            width: 87px;
        }
        .auto-style3 {
            width: 312px;
        }
        .auto-style4 {
            width: 238px;
        }
        .auto-style5 {
            width: 87px;
            text-align: center;
        }
        .auto-style6 {
            width: 312px;
            text-align: center;
        }
        .auto-style7 {
            width: 238px;
            text-align: center;
        }
        .auto-style8 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br />
            <table border="1" class="auto-style1">
                <tr>
                    <td class="auto-style5">ID</td>
                    <td class="auto-style6">Item Name</td>
                    <td class="auto-style7">Price</td>
                    <td class="auto-style8">Quantity</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="97px" style="text-align: center"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="264px" style="text-align: center"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" Height="33px" Width="217px" style="text-align: center"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Height="32px" Width="136px" style="text-align: center"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="Button3" runat="server" OnClick="btnFind_Click" BackColor="#FFCC00" Height="27px" Text="Find" Width="103px" />
                        <asp:Button ID="Button1" runat="server" BackColor="#FFCC00" Height="27px" Text="Add Data" Width="103px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" ShowFooter="True">
            <Columns>
                <asp:BoundField DataField="sno" HeaderText="S.No">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="productname" HeaderText="Product Name">
                <ItemStyle HorizontalAlign="Center" Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="quantity" HeaderText="Quantity">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="price" HeaderText="Price">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Total" HeaderText="Total">
                <ItemStyle HorizontalAlign="Center" Width="150px" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>










        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Print"  OnClientClick="printpage()"/>










    </form>
</body>
</html>
