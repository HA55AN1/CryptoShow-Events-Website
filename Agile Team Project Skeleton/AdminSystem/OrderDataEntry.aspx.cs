using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the adress to be processed.
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false) 
        {
            if (OrderID != -1)
            {
                /* If entering from the Edit order pathway, set the OrderID to the supplied OrderID
                 * and display the data from the order using DisplayOrder method. Then, ensure the
                 * Find button is visible (as it could be disabled previously) and prevent the user
                 * from updating the Date Placed field (as the field is NOT VALIDATED from this pathway)
                 * This is because the Validation test prevents the date from being in the past.
                 */
                DisplayOrder();
                btnFind.ToolTip = "To find, change the ID to a valid ID.";
                btnFind.Visible = true;
                txtDatePlaced.Enabled = false;
                btnSubmit.Text = "Update";
            }
            else
            {
                /* 
                 * If entering from the Create order pathway, set the OrderID to -1 in order to force the OrderID 
                 * to be the latest (highest) OrderID possible. Then, disable the Find button to prevent accessing 
                 * data and unintentional data duplication, and disable the OrderID text field to prevent users from 
                 * inputting their own OrderID.
                 */
                txtOrderID.Text = "-1";
                btnFind.Enabled = false;
                btnFind.ToolTip = "To find an Order, edit an order and follow the instructions.";
                txtOrderID.Enabled = false;
            }
        }
    }

    private void DisplayOrder()
    {
        // Create an instance of the Order book
        clsOrderCollection Orders = new clsOrderCollection();
        // Find the record to update
        Orders.ThisOrder.Find(OrderID);
        // Display the data for the record.
        txtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        chkPaid.Checked = Orders.ThisOrder.IsPaid;
        txtDatePlaced.Text = Orders.ThisOrder.DateOrderPlaced.ToString();
        txtDeliveryType.Text = Orders.ThisOrder.DeliveryType.ToString();
        txtStaffNote.Text = Orders.ThisOrder.StaffNote.ToString();
        txtCustomerNote.Text = Orders.ThisOrder.CustomerNote.ToString();
        txtPrice.Text = Orders.ThisOrder.OrderPrice.ToString();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        // Capture the data from the table.
        string OrderID = txtOrderID.Text;
        string IsPaid = chkPaid.Text;
        string DateOrderPlaced = txtDatePlaced.Text;
        string DeliveryType = txtDeliveryType.Text;
        string StaffNote = txtStaffNote.Text;
        string CustomerNote = txtCustomerNote.Text;
        string OrderPrice = txtPrice.Text;
        // Validate the data.
        string Error = "";
        // Workaround for edit but including old Date
        if (Convert.ToInt32(OrderID) == -1)
        {
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
        }
        else 
        {
            Error = AnOrder.Valid(OrderID, IsPaid, DateTime.Now.Date.ToString(), DeliveryType, OrderPrice, StaffNote, CustomerNote);
        }

        // Store the data.
        if (Error == "")
        {
            AnOrder.OrderID = Convert.ToInt32(OrderID); // DONT MISS
            AnOrder.IsPaid = Convert.ToBoolean(chkPaid.Checked);
            AnOrder.DateOrderPlaced = Convert.ToDateTime(DateOrderPlaced);
            AnOrder.DeliveryType = DeliveryType;
            AnOrder.StaffNote = StaffNote;
            AnOrder.CustomerNote = CustomerNote;
            AnOrder.OrderPrice = Convert.ToInt32(OrderPrice);
            // Create a new instance of the Order collection.
            clsOrderCollection OrderList = new clsOrderCollection();

            // If this is a new record i.e. AddressID
            if (Convert.ToInt32(OrderID) == -1)
            {
                // Set the ThisOrder property.
                OrderList.ThisOrder = AnOrder;
                // Add the new record.
                OrderList.Add();
            }
            else // Otherwise it must be an update.
            {
                // Find the record to update.
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderID));
                // Set the ThisOrder property.
                OrderList.ThisOrder = AnOrder;
                // Add the new record.
                OrderList.Update();
            }
            // Navigate to the view page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        // Create an instance of the Order class.
        clsOrder AnOrder = new clsOrder();
        // Create a variable to store the primary key.
        Int32 OrderID;
        // Create a variable to store the primary key.
        Boolean Found = false;
        // Get the key from user input.
        try
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
            // Find the record.
            Found = AnOrder.Find(OrderID);
            // If found.
            if (Found)
            {
                // Display the values of the properties in the form.
                chkPaid.Checked = AnOrder.IsPaid;
                txtDatePlaced.Text = AnOrder.DateOrderPlaced.ToString();
                txtDeliveryType.Text = AnOrder.DeliveryType;
                txtPrice.Text = AnOrder.OrderPrice.ToString();
                txtStaffNote.Text = AnOrder.StaffNote;
                txtCustomerNote.Text = AnOrder.CustomerNote;
            }
            else
            {
                lblError.Text = "Invalid OrderID!";
            }
        }
        catch (Exception ex)
        {
            lblError.Text = "Enter an OrderID!";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}