using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instnace of clsOrder
        //clsOrder AnOrder = new clsOrder();
        // Get the data from the session object.
        Response.Redirect("OrderList.aspx");
    }
}