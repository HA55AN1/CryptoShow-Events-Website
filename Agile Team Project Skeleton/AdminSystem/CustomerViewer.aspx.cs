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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];


        //display the fullname of the customer for this entry
        Response.Write(AnCustomer.FullName);
        //display the Customer Email of the customer for this entry
        Response.Write(AnCustomer.CustomerEmail);
        //display the CustomerPhone Number for this entry
        Response.Write(AnCustomer.CustomerPhone);
        //display the Customer Address for this entry
        Response.Write(AnCustomer.Address);
        //display Registration Date for this entry
        Response.Write(AnCustomer.RegistrationDate);
        //display email opt in for this entry
        Response.Write(AnCustomer.EmailOptIn);

        
    }
    
}

