using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 GameID;
    //get the number of the address to be deleted from the session object
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        GameID = Convert.ToInt32(Session["GameID"]);
    }





    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book class
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(GameID);
        //delete the record
        StockBook.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}