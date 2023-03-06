using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the house number for this entry
        Response.Write(AnStaff.Username);
        Response.Write("\n");
        Response.Write(AnStaff.Password);
        Response.Write("\n");
        Response.Write(AnStaff.Role);
        Response.Write("\n");
        Response.Write(AnStaff.Admin);
        Response.Write("\n");
        Response.Write(AnStaff.StaffID);
    }
}