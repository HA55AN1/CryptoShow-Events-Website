using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key of the Staff Member to be deleted
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the StaffId of the record to delete from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the collection class
        clsStaffCollection AllStaff = new clsStaffCollection();
        //find the record to be deleted
        AllStaff.ThisStaffMember.Find(StaffId);
        //delete the record
        AllStaff.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}