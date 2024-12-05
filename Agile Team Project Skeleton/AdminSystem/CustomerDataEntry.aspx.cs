using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
            else
            {
                //sets the customerID to -1 for the add function
                txtCustomerID.Text = CustomerID.ToString();
                txtCustomerID.Enabled = false;
                btnFind.Enabled = false;
            }
        }

    }

    void DisplayCustomer()
    {
        //crete an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for the record
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtFullName.Text = CustomerBook.ThisCustomer.FullName.ToString();
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail.ToString();
        txtCustomerPhone.Text = CustomerBook.ThisCustomer.CustomerPhone.ToString();
        txtRegistrationDate.Text = CustomerBook.ThisCustomer.RegistrationDate.ToString();
        chkEmailOptIn.Checked = CustomerBook.ThisCustomer.EmailOptIn;
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();


        //capture the Fullname 
        String FullName = txtFullName.Text;
        //capture the Customer Email
        String CustomerEmail = txtCustomerEmail.Text;
        //capture the Customer Phone Number
        String CustomerPhone = txtCustomerPhone.Text;
        //capture the Customer Address
        String Address = txtAddress.Text;
        //capture the Registration Date
        String RegistrationDate = txtRegistrationDate.Text;    
        //Capture Email Opt In check box
        String EmailOptIn = chkEmailOptIn.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
        if (Error == "")
        {
            //capture the CustomerID
            AnCustomer.CustomerID = CustomerID; 
            //capture the FullName
            AnCustomer.FullName = FullName;
            //capture the CustomerEmail
            AnCustomer.CustomerEmail = CustomerEmail;
            //capture the CustomerPhone
            AnCustomer.CustomerPhone = CustomerPhone;
            //capture the Address
            AnCustomer.Address = Address;
            //capture the RegistrationDate
            AnCustomer.RegistrationDate = Convert.ToDateTime(RegistrationDate);
            //capture the EmailOptIn
            AnCustomer.EmailOptIn = chkEmailOptIn.Checked;
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
            

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
 
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerID;
        //create a variable to store the primary key
        Boolean Found = false;
        //gets the primary key entered by the user
        if(txtCustomerID.Text!= "")
        {
            CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //Find the record
            Found = AnCustomer.Find(CustomerID);
            //if found
            if (Found)
            {
                //display the values of the properties in the form
                txtAddress.Text = AnCustomer.Address;
                txtCustomerPhone.Text = AnCustomer.CustomerPhone;
                txtCustomerEmail.Text = AnCustomer.CustomerEmail;
                txtFullName.Text = AnCustomer.FullName;
                txtRegistrationDate.Text = AnCustomer.RegistrationDate.ToString();
                chkEmailOptIn.Checked = AnCustomer.EmailOptIn;
            }
        }
        else
        {
            lblError.Text = "Enter a CustomerID to find";
        }

    }

    protected void chkEmailOptIn_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("CustomerList.aspx");
    }
}
