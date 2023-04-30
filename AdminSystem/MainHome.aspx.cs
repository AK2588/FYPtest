using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOrderPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Practice1.aspx");

    }

    protected void btnStockPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnEmployeePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnCustomerPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login2.aspx");
    }
}