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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();

        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];

        //display the entry
        
        Response.Write("Game Name : " + AnStock.GameName + "<br />");
        Response.Write("Price : " + AnStock.Price + "<br />");
        Response.Write("Stock is Available? " + AnStock.Availability + "<br />");
        Response.Write("Release Date : " + AnStock.ReleaseDate + "<br />");
        Response.Write("Age Rating : " + AnStock.AgeRating + "<br />");

    }
}