using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key of the record to be deleted
    Int32 SupplierId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be deleted from the session object
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supplier book collection class
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to delete
        SupplierBook.ThisSupplier.Find(SupplierId);
        //find the record to delete
        SupplierBook.Delete();
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }
}