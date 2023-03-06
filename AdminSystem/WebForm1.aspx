<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
   <div class="loginbox" >
       <img src="LoginIcon.png" alt ="Alternate Text" class="user" />
       <h2>Log In Here</h2>
       <form runat="server">
           <asp:Label Text="Email" CssClass="lblemail" runat="server" />
           <asp:TextBox runat="server" CssClass="txtemail" placeholder="EnterEmail" />
           <asp:Label Text="Password" CssClass="lblpass" runat="server" />
           <asp:TextBox runat="server" CssClass="txtpass" placeholder="*********" />
           <asp:Button Text="Sign In" CssClass="btnsubmit" runat="server" />
           <asp:LinkButton Text="Forget Password" CssClass="btnforget" runat="server" />
       </form>
   </div>
       
   
</body>
</html>
