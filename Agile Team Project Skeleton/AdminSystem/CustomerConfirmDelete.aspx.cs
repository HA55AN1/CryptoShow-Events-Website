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
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomer NewCustomer = new clsCustomer();
        NewCustomer.CustomerID = CustomerID;
        //create a new instance of the customer book collection class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer = NewCustomer;
        //find the record to delete
        CustomerBook.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}