using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private bool privIsPaid;
        private DateTime privDateOrderPlaced;
        private string privDeliveryType;
        private int privOrderPrice;
        private string privStaffNote;
        private string privCustomerNote;
        private Int32 privOrderID;

        public bool IsPaid 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privIsPaid;
            }
            set
            {
                // This line of code allows data into the property.
                privIsPaid = value;
            }
        }

        public DateTime DateOrderPlaced 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privDateOrderPlaced;
            }
            set
            {
                // This line of code allows data into the property.
                privDateOrderPlaced = value;
            }
        }

        public string DeliveryType 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privDeliveryType;
            }
            set
            {
                // This line of code allows data into the property.
                privDeliveryType = value;
            }
        }

        public int OrderPrice 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privOrderPrice;
            }
            set
            {
                // This line of code allows data into the property.
                privOrderPrice = value;
            }
        }

        public string StaffNote 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privStaffNote;
            }
            set
            {
                // This line of code allows data into the property.
                privStaffNote = value;
            }
        }

        public string CustomerNote 
        {
            get
            {
                // This line of code sends the data out of the property.
                return privCustomerNote;
            }
            set
            {
                // This line of code allows data into the property.
                privCustomerNote = value;
            }
        }
        
        public int OrderID 
        {
            get 
            {
                // This line of code sends the data out of the property.
                return privOrderID;
            }
            set 
            {
                // This line of code allows data into the property.
                privOrderID = value;
            } 
        }

        public bool Find(int orderID)
        {
            /* New Code */
            // Create an instance of the data connection.
            clsDataConnection sqlDB = new clsDataConnection();
            // Add the parameter for the orderID to search for.
            sqlDB.AddParameter("@OrderID", orderID);
            // Execute stored proceedure.
            sqlDB.Execute("sproc_tblOrder_FilterByOrderID");
            // If one record found (zero or one only)
            if (sqlDB.Count == 1)
            {
                // Copy the data from the database to the private data members
                privOrderID = Convert.ToInt32(sqlDB.DataTable.Rows[0]["OrderID"]);
                privIsPaid = Convert.ToBoolean(sqlDB.DataTable.Rows[0]["IsPaid"]);
                privDateOrderPlaced = Convert.ToDateTime(sqlDB.DataTable.Rows[0]["DateOrderPlaced"]);
                privDeliveryType = Convert.ToString(sqlDB.DataTable.Rows[0]["DeliveryType"]);
                privOrderPrice = Convert.ToInt32(sqlDB.DataTable.Rows[0]["OrderPrice"]);
                privStaffNote = Convert.ToString(sqlDB.DataTable.Rows[0]["StaffNote"]);
                privCustomerNote = Convert.ToString(sqlDB.DataTable.Rows[0]["CustomerNote"]);
                // Return true as successful.
                return true;
            }
            else 
            {
                // Return false if problems.
                return false;
            }
        }

        public string Valid(string OrderID,
            string IsPaid,
            string DateOrderPlaced,
            string DeliveryType,
            string OrderPrice,
            string StaffNote,
            string CustomerNote)
        {
            // Create a string variable to store the error.
            String Error = "";

            /* Date Tests */
            // Create a temporary variable to store the date values.
            DateTime DateTemp;
            try
            {
                // Copy the DateOrderPlaced value to the DateTemp variable.
                DateTemp = Convert.ToDateTime(DateOrderPlaced);
                // Check to see if the date is less than today's date.
                if (DateTemp < DateTime.Now.Date)
                {
                    // Add error.
                    Error = Error + "The date cannot be in the past : ";
                }
                // Check to see if the date is greater than today's date.
                if (DateTemp > DateTime.Now.Date)
                {
                    // Add error.
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch // Exception not needed. 
            {
                // Add error.
                Error = Error + "The date has to be a valid date type : ";
            }

            /* String Tests */
            if (CustomerNote.Length > 50)
            {
                // Add error.
                Error = Error + "The CustomerNote string may not be longer than 50 chars : ";
            }

            if (StaffNote.Length > 50)
            {
                // Add error.
                Error = Error + "The StaffNote string may not be longer than 50 chars : ";
            }
            // DeliveryType
            switch (DeliveryType)
            {
                case "Slow":
                case "Fast":
                case "Express":
                    break;
                default:
                    Error = Error + "The DeliveryType must be a valid DeliveryType : ";
                    break;
            }

            /* Integer Tests */
            // Create a temporary variable to store the date values.
            Int32 IntTemp;
            // Convert the string-stored integer to an actual Int32.
            try
            {
                IntTemp = Convert.ToInt32(OrderPrice);
                if (IntTemp < 0)
                {
                    // Add error.
                    Error = Error + "The OrderPrice cannot be below 0 : ";
                }
                if (IntTemp > 15000000)
                {
                    // Add error.
                    Error = Error + "The OrderPrice cannot exceed 15 000 000 : ";
                }
            }
            catch(Exception ex)
            {
                Error = Error + "The OrderPrice must be an integer : ";
            }
            // Return any error messages.
            return Error;
        }
    }
}