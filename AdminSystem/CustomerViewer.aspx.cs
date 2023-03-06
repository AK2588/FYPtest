using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        // Get the data from the session object
        Customer = (clsCustomer)Session["Customer"];
        // Display customer username for this entry
        Response.Write(Customer.Username);
    }
}