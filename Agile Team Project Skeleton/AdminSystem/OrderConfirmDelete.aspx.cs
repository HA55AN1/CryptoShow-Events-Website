using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Variable to store the primary key value.
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get hte number of the Order to be deleted from the session object.
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrder NewOrder = new clsOrder();
        NewOrder.OrderID = OrderID;
        // Create a new instance of the Order Collection class.
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder = NewOrder;
        // Find the record to delete.
        Orders.Delete();
        // Redirect back to the main page.
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect.
        Response.Redirect("OrderList.aspx");
    }
}