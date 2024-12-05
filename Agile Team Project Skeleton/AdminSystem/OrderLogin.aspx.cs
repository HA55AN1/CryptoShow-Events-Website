using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // Create an instance of the Order user class.
        clsOrderUser AnUser = new clsOrderUser();
        // Create the variables to store the username and password.
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        // Create a variable to sore the result of the find user operation.
        Boolean Found = false;
        // Get the username entered by the user.
        UserName = Convert.ToString(txtUserName.Text);
        // Get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        // Find the record.
        Found = AnUser.FindUser(UserName, Password);
        // Add a session to capture the username.
        Session["AnUser"] = AnUser;
        // If username and/or password is empty.
        if (txtUserName.Text == "") { lblError.Text = "Enter a username."; }
        else if (txtPassword.Text == "") { lblError.Text = "Enter a password."; }
        else if (Found == true) { Response.Redirect("OrderList.aspx"); }
        else if (Found == false) { lblError.Text = "Login details are incorrect. Please try again."; }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}