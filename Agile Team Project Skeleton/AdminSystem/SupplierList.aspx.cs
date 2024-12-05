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
            //update the list view
            DisplaySuppliers();
        }

        //create a new instance of clsSupplierUser
        clsSupplierUser AnUser = new clsSupplierUser();
        //get data from the session object
        AnUser = (clsSupplierUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

     void DisplaySuppliers()
    {
        //create an instance of the supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        //set the data field to display
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplierId"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variabe to store the primary key value of the record to be edited
        Int32 SupplierId;
        //if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["SupplierId"] = SupplierId;
            //redirect to the edit page
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 SupplierId;
        //if a record has been selected from list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object 
            Session["SupplierId"] = SupplierId;
            //redirect to the delecte page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            //display an error message
            lblError.Text = "please select a record from the list to be deleted";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier object
        clsSupplierCollection AnSupplier = new clsSupplierCollection();
        //retrive the value of address from the presentation layer
        AnSupplier.ReportByAddress(txtFilterAddress.Text);
        //set the data source to the list of suppliers in the collection
        lstSupplierList.DataSource = AnSupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        //set the name of the field to display
        lstSupplierList.DataTextField = "Address";
        //bind the data to the list
        lstSupplierList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier object
        clsSupplierCollection AnSupplier = new clsSupplierCollection();
        //set an empty string
        AnSupplier.ReportByAddress("");
        //clear any existing filter to tidy up the interface
        txtFilterAddress.Text = "";
        //set the data source to the list of suppliers in the collection
        lstSupplierList.DataSource = AnSupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierId";
        //set the name of the field to display
        lstSupplierList.DataTextField = "Address";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}