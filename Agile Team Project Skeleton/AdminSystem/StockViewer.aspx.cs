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
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the car id for this entry
        Response.Write(AStock.CarID);
        //display the stock total for this entry
        Response.Write(AStock.StockTotal);
        //display the car model for this entry
        Response.Write(AStock.CarModel);
        //display the car colour for this entry
        Response.Write(AStock.CarColour);
        //display the car brand for this entry
        Response.Write(AStock.CarBrand);
        //display the stock arrive date for this entry
        Response.Write(AStock.StockArriveDate);
        //display the stock available for this entry
        Response.Write(AStock.StockAvailable);


    }
}