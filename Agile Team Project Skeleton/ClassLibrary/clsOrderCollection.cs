using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // Private data member for the list.
        List<clsOrder> privOrderList = new List<clsOrder>();
        // PRivate member data for thisOrder
        clsOrder privThisOrder = new clsOrder();
        public List<clsOrder> OrderList 
        {
            get
            {
                // Return the private data.
                return privOrderList;
            }

            set
            {
                // Set the private data.
                privOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                // Return the private data.
                return privOrderList.Count;
            }
            set
            { 
                // Return to this later.
            }
        }
        public clsOrder ThisOrder 
        {
            get 
            {
                // Return the private data.
                return privThisOrder;
            }

            set
            {
                // Set the private data.
                privThisOrder = value;
            }
        }
        public clsOrderCollection()
        {
            // Object for the data connection.
            clsDataConnection sqlDB = new clsDataConnection();
            // Execute the stored procedure.
            sqlDB.Execute("sproc_tblOrder_SelectAll");
            // Populate the array lit with the data table.
            PopulateArray(sqlDB);
        }

        public int Add()
        {
            // Adds a record to the database based on the values of privThisOrder
            // Connect to the database.
            clsDataConnection sqlDB = new clsDataConnection();
            // Set the parameters for the stored procedure.
            sqlDB.AddParameter("@IsPaid", privThisOrder.IsPaid);
            sqlDB.AddParameter("@DateOrderPlaced", privThisOrder.DateOrderPlaced);
            sqlDB.AddParameter("@DeliveryType", privThisOrder.DeliveryType);
            sqlDB.AddParameter("@OrderPrice", privThisOrder.OrderPrice);
            sqlDB.AddParameter("@StaffNote", privThisOrder.StaffNote);
            sqlDB.AddParameter("@CustomerNote", privThisOrder.CustomerNote);

            // Execute the query returnng the primary key value.
            return sqlDB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // Update an existing record based on the values of thisOrder
            // Connect to the DB.
            clsDataConnection sqlDB = new clsDataConnection();
            // Set the parameters for the new stored procedure.
            sqlDB.AddParameter("@OrderID", privThisOrder.OrderID);
            sqlDB.AddParameter("@IsPaid", privThisOrder.IsPaid);
            sqlDB.AddParameter("@DateOrderPlaced", privThisOrder.DateOrderPlaced);
            sqlDB.AddParameter("@DeliveryType", privThisOrder.DeliveryType);
            sqlDB.AddParameter("@OrderPrice", privThisOrder.OrderPrice);
            sqlDB.AddParameter("@StaffNote", privThisOrder.StaffNote);
            sqlDB.AddParameter("@CustomerNote", privThisOrder.CustomerNote);
            // Execute the stored procedure.
            sqlDB.Execute("sproc_tblOrder_Update");
        }

        public void Delete() 
        {
            // Deletes the record pointed to by thiOrder
            // Connect to the database.
            clsDataConnection sqlDB = new clsDataConnection();
            // Set the parameters for the stored procedure.
            sqlDB.AddParameter("@OrderID", privThisOrder.OrderID);
            // Execute the stored procedure.
            sqlDB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByStaffNote(string StaffNote)
        {
            // Filters the records based on staff note.
            // Connect to the database.
            clsDataConnection sqlDB = new clsDataConnection();
            // Set the parameters for the stored procedure.
            sqlDB.AddParameter("@StaffNote", StaffNote);
            // Execute the stored procedure.
            sqlDB.Execute("sproc_tblOrder_FilterByStaffNote");
            // Populate the array list with the data table.
            PopulateArray(sqlDB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the parameter DB.
            // Variable for the index.
            Int32 Index = 0;
            // Variable to store the record count.
            Int32 RecordCount;
            // Get the count of records.
            RecordCount = DB.Count;
            // Clear the private array list
            privOrderList = new List<clsOrder>();
            // While there are records to process.
            while (Index < RecordCount)
            {
                // Create a blank Order object.
                clsOrder AnOrder = new clsOrder();
                // Read in thefields from the current record.
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.DateOrderPlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrderPlaced"]);
                AnOrder.DeliveryType = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryType"]);
                AnOrder.StaffNote = Convert.ToString(DB.DataTable.Rows[Index]["StaffNote"]);
                AnOrder.CustomerNote = Convert.ToString(DB.DataTable.Rows[Index]["CustomerNote"]);
                AnOrder.OrderPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderPrice"]);
                // Add the record to the private data member.
                privOrderList.Add(AnOrder);
                // Point at the next record.
                Index++;
            }
    }
    }
}