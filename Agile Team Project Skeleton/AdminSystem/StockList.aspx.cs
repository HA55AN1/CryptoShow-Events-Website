using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }

        //create a new instance of the clsStockUser
        clsStockUser AnUser = new clsStockUser();
        //get data from the session object
        AnUser = (clsStockUser)Session["AnUser"];
        //display the username
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "CarID";
        //set the data field to dispaly
        lstStockList.DataTextField = "CarModel";
        //bind the data to the list
        lstStockList.DataBind();
    }





    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CarID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CarID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CarID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else         //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CarID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            CarID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");

        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection AStock = new clsStockCollection();
        //retrieve the value of car brand from the presentation layer
        AStock.ReportByCarBrand(txtFilter.Text);
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "CarID";
        //set the name of the field to display - I am sorting by car brand
        //but display the carmodels of that brand
        lstStockList.DataTextField = "CarModel";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection AStock = new clsStockCollection();
        //set an empty string
        AStock.ReportByCarBrand("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "CarID";
        //set the name of the field to display - I am sorting by car brand
        //but display the carmodels of that brand
        lstStockList.DataTextField = "CarModel";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }



    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}