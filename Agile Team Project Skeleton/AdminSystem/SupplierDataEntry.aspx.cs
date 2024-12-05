using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Supplier to be processed
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is not the new record
            if (SupplierId != -1)
            {
                //display the current data for the record
                DisplaySupplier();
            }
            else
            {
                //sets the customerID to -1 for the add function
                txtSupplierId.Text = SupplierId.ToString();
                txtSupplierId.Enabled = false;
                btnFind.Enabled = false;
            }
        }
    }

     void DisplaySupplier()
    {
        //create an instance of the supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update
        SupplierBook.ThisSupplier.Find(SupplierId);
        //display the data for the record
        txtSupplierId.Text = SupplierBook.ThisSupplier.SupplierId.ToString();
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName.ToString();
        txtSupplierEmail.Text = SupplierBook.ThisSupplier.SupplierEmail.ToString();
        txtPhoneNumber.Text = SupplierBook.ThisSupplier.PhoneNumber.ToString();
        txtAddress.Text = SupplierBook.ThisSupplier.Address.ToString();
        txtLastOrderDate.Text = SupplierBook.ThisSupplier.LastOrderDate.ToString();
        chkAvailable.Checked = SupplierBook.ThisSupplier.Available;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the All data
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Address = txtAddress.Text;
        string LastOrderDate = txtLastOrderDate.Text;
        string Available = chkAvailable.Text;
        string Error = "";
        //validate the data
        Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
        if (Error == "")
        {
            //capture the All data
            AnSupplier.SupplierId = SupplierId;
            AnSupplier.SupplierName = SupplierName;
            AnSupplier.SupplierEmail = SupplierEmail;
            AnSupplier.PhoneNumber = PhoneNumber;
            AnSupplier.Address = Address;
            AnSupplier.LastOrderDate = Convert.ToDateTime(LastOrderDate);
            AnSupplier.Available = chkAvailable.Checked;
            //create a new instance of the supplier collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            //if this is a new record i.e supplierid = -1 then add the data
            if (SupplierId == -1)
            {
                //set the ThisSupplier property
                SupplierList.ThisSupplier = AnSupplier;
                //add the new record
                SupplierList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                SupplierList.ThisSupplier.Find(SupplierId);
                //set the ThisSupplier 
                SupplierList.ThisSupplier = AnSupplier;
                    //update the record
                    SupplierList.Update();
            }
           
            //redirect back to the list page
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier class
        clsSupplier AnSupplier = new clsSupplier();
        //create a variable to store the primary key
        Int32 SupplierId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record
        Found = AnSupplier.Find(SupplierId);
        //if found
        if (Found == true)
        {
            //display the values of the supplier in the form
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplierEmail.Text = AnSupplier.SupplierEmail;
            txtPhoneNumber.Text = AnSupplier.PhoneNumber;
            txtAddress.Text = AnSupplier.Address;
            txtLastOrderDate.Text = AnSupplier.LastOrderDate.ToString();
            chkAvailable.Checked = AnSupplier.Available;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}