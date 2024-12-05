using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 CarID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be deleted from the session object
        CarID = Convert.ToInt32(Session["CarID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the stock colletion class
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delete
        Stock.ThisStock.Find(CarID);
        //delete the record
        Stock.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("StockList.aspx");
    }
}