<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>User Login</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" 
integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>

    <style>

        .wrapper1
        {
            height:100vh !important;
            display:flex;
            align-items:center;
            flex-direction:column;
            justify-content:center;
            width:100% !important;
            padding:20px;
            background-color:#f5f5f5 !important;
        }

        .logincontainer
        {
            border-radius:0px;
            background-color:#fff;
            width:90%;
            max-width:450px;
            position:relative;
            padding:20px;
            border:1px white solid ;
            box-shadow:0 15px 10px #acacac;
        }

    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper1">

           <div class="logincontainer">

               <h3>
                   <img src="webform1icon.png" width="50px" height="50px" /> User Login
               </h3>

               <hr />

               <asp:TextBox runat="server" ID="txtUserName" placeholder="Username" CssClass="form-control" OnTextChanged="txtUserName_TextChanged" />
               <br />

               <asp:TextBox runat="server" ID="txtPassword" placeholder="Enter Enter Password" TextMode="Password" 
                   CssClass="form-control" OnTextChanged="txtPassword_TextChanged" />
               <br />

               <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-info form-control" Text="Login" OnClick="btnLogin_Click" 
                   />
               <br />
               <asp:Label ID="lblErrorMsg" runat="server" Text=""></asp:Label>
           </div> 


        </div>
    </form>
</body>
</html>