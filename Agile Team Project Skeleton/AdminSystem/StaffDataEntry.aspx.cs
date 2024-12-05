using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with class level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the StaffId for the staff member to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaffMember();
            }
            else
            {
                //sets staffId to -1 for the add function
                txtStaffId.Text = StaffId.ToString();
                txtStaffId.Enabled = false;
                btnFind.Enabled = false;
            }
        }

    }

    void DisplayStaffMember()
    {
        //create an instance of the StaffCollection
        clsStaffCollection AllStaff = new clsStaffCollection();
        //find record to update
        AllStaff.ThisStaffMember.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = AllStaff.ThisStaffMember.StaffId.ToString();
        txtStaffName.Text = AllStaff.ThisStaffMember.StaffName;
        txtJobTitle.Text = AllStaff.ThisStaffMember.JobTitle;
        txtStaffEmail.Text = AllStaff.ThisStaffMember.StaffEmail;
        txtStaffAddress.Text = AllStaff.ThisStaffMember.StaffAddress;
        txtDateJoined.Text = AllStaff.ThisStaffMember.DateJoined.ToShortDateString();
        chkIsAdmin.Checked = AllStaff.ThisStaffMember.IsAdmin;




    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff class
        clsStaff Staff = new clsStaff();
        //capture the StaffId
        Int32 StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the staffName
        string StaffName = txtStaffName.Text;
        //capture the job title
        string JobTitle = txtJobTitle.Text;
        //capture the staff email
        string StaffEmail = txtStaffEmail.Text;
        //capture the staff address
        string StaffAddress = txtStaffAddress.Text;
        //capture the date joined
        string DateJoined = txtDateJoined.Text;
        //capture isAdmin checkbox
        bool IsAdmin = chkIsAdmin.Checked;
        //validate the data
        string Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
        if(Error == "")
        {
            //capture the staffId 
            Staff.StaffId = Convert.ToInt32(txtStaffId.Text);
            //capture the staffName
            Staff.StaffName = txtStaffName.Text;
            //capture the job title
            Staff.JobTitle = txtJobTitle.Text;
            //capture the staff email
            Staff.StaffEmail = txtStaffEmail.Text;
            //capture the staff address
            Staff.StaffAddress = txtStaffAddress.Text;
            //capture the date joined
            Staff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
            //capture isAdmin checkbox
            Staff.IsAdmin = chkIsAdmin.Checked;

            //create a new instance of the StaffCollection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new staff member, i.e StaffId = -1, then add a new staff member
            if (StaffId == -1)
            {
                //set the ThisStaffMember property
                StaffList.ThisStaffMember = Staff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaffMember.Find(StaffId);
                //set the thisStaffMember property
                StaffList.ThisStaffMember = Staff;
                //update the record
                StaffList.Update();
            }

            
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error  message
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff Staff = new clsStaff();
        //create a variable to store the primary key
        Int32 staffId;
        //create a variable to store the result of the find method
        Boolean found = false;
        //get the primary key entered by the user
        if (txtStaffId.Text!= "")
        {
            staffId = Convert.ToInt32(txtStaffId.Text);
            //find the record
            found = Staff.Find(staffId);
            //if found
            if (found)
            {
                //display the properties in the form
                txtStaffName.Text = Staff.StaffName;
                txtJobTitle.Text = Staff.JobTitle;
                txtStaffEmail.Text = Staff.StaffEmail;
                txtStaffAddress.Text = Staff.StaffAddress;
                txtDateJoined.Text = Staff.DateJoined.ToShortDateString();
                chkIsAdmin.Checked = Staff.IsAdmin;

            }
        }
        else
        {
            lblError.Text = "Enter a StaffId to find";
        }


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("StaffList.aspx");
    }
}