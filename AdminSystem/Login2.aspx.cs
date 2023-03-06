using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtUserName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtUserName.Text=="Admin" && txtPassword.Text=="Admin")
        {
            Response.Redirect("HomePage.aspx");
        }
        else
        {
            lblErrorMsg.Text = "Invalid Username or Password!";
        }
    }
}