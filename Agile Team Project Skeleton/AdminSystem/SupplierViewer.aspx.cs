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
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display the Name for the entry
        Response.Write(AnSupplier.SupplierId);
        Response.Write(AnSupplier.SupplierName);
        Response.Write(AnSupplier.SupplierEmail);
        Response.Write(AnSupplier.PhoneNumber);
        Response.Write(AnSupplier.Address);
        Response.Write(AnSupplier.LastOrderDate);
        Response.Write(AnSupplier.Available);
    }
}