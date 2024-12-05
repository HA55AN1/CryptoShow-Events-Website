using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CarID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CarID = Convert.ToInt32(Session["CarID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CarID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        Stock.ThisStock.Find(CarID);
        //display the data for the record
        txtCarID.Text = Stock.ThisStock.CarID.ToString();
        txtStockTotal.Text = Stock.ThisStock.StockTotal.ToString();
        txtCarModel.Text = Stock.ThisStock.CarModel.ToString();
        txtCarColour.Text = Stock.ThisStock.CarColour.ToString();
        txtCarBrand.Text = Stock.ThisStock.CarBrand.ToString();
        chkStockAvailable.Checked = Stock.ThisStock.StockAvailable;
        txtStockArriveDate.Text = Stock.ThisStock.StockArriveDate.ToString();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance o the clsStock
        clsStock AStock = new clsStock();
        //capture the stock total
        string StockTotal = txtStockTotal.Text;
        //capture the car model
        string CarModel = txtCarModel.Text;
        //capture the car colour
        string CarColour = txtCarColour.Text;
        //capture the car brand
        string CarBrand = txtCarBrand.Text;
        //capture the stock arrive date
        string StockArriveDate = txtStockArriveDate.Text;
        //capture stock available check box
        string StockAvailable = chkStockAvailable.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(StockTotal, CarModel, CarColour, CarBrand, StockArriveDate);
        if (Error == "")
        {
            //capture the CarID
            AStock.CarID = CarID;
            //capture the Stock total
            AStock.StockTotal = Convert.ToInt32(StockTotal);
            //capture the car model
            AStock.CarModel = CarModel;
            //capture the car colour
            AStock.CarColour = CarColour;
            //capture the car bramd
            AStock.CarBrand = CarBrand;
            //capture the StockAvailable
            AStock.StockAvailable = chkStockAvailable.Checked;
            //capture the Stock arrive date
            AStock.StockArriveDate = Convert.ToDateTime(StockArriveDate);
            //create a new instnace of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. CarID = -1 then add the data
            if (CarID == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(CarID);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    //BtnFind
    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 CarID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CarID = Convert.ToInt32(txtCarID.Text);
        //find the record
        Found = AStock.Find(CarID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockTotal.Text = AStock.StockTotal.ToString();
            txtCarModel.Text = AStock.CarModel;
            txtCarColour.Text = AStock.CarColour;
            txtCarBrand.Text = AStock.CarBrand;
            txtStockArriveDate.Text = AStock.StockArriveDate.ToString();
            chkStockAvailable.Checked = AStock.StockAvailable;
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("StockList.aspx");
    }
}