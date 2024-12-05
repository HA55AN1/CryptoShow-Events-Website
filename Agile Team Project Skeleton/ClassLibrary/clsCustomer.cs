using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the address id property
        private Int32 mCustomerID;

        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the EmailOptIn property
        private Boolean mEmailOptIn;
        //active public property
        public bool EmailOptIn
        {
            get
            {
                //this line of code sends data out of the property
                return mEmailOptIn;
            }
            set
            {
                //this line of code allows data into the property
                mEmailOptIn = value;
            }
        }

        //private data member for the registration date property
        private DateTime mRegistrationDate;
        //date added public property
        public DateTime RegistrationDate
        {
            get
            {
                //this line of code sends data out of the property
                return mRegistrationDate;
            }
            set
            {
                mRegistrationDate = value;
            }
        }
        
        //private data member for the street property
        private String mFullName;
        //street public property 
        public String FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }

        //private data member for the street property
        private String mCustomerEmail;
        //street public property 
        public String CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        //private data member for the street property
        private String mCustomerPhone;
        //street public property 
        public String CustomerPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPhone;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPhone = value;
            }
        }

        //private data member for the street property
        private String mAddress;
        //street public property 
        public String Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }


       // **** Find Method ***** //
       public bool Find (int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mEmailOptIn = Convert.ToBoolean(DB.DataTable.Rows[0]["EmailOptIn"]);
                mRegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RegistrationDate"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPhone = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhone"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string FullName, string CustomerEmail, string CustomerPhone, string Address, string RegistrationDate)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the FullName is Blank
            if (FullName.Length == 0)
            {
                //record the error
                Error = Error + "The Full Name may not be blank : ";
            }
            //if the full name number is greater than 20 characters
            if (FullName.Length > 20)
            {
                //record the error 
                Error = Error + "The Full Name must be less than 20 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the RegistrationDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(RegistrationDate);

                if (DateTemp < DateTime.Now.Date) //compare RegistrationDate with Date
                {
                    //record the error
                    Error = Error + "The Registration Date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + " The Registration Date cannot be in the future : ";
                }

            }
            catch
            {
                //return any error messages
                //return Error;
                Error = Error + "The Registration Date was not a valid date :";

            }

            //if the Phone Number is blank
            if (CustomerPhone.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Number may not be left as blank : ";
            }
            //if the Phone Number is too long
            if (CustomerPhone.Length > 50)
            {
                //record the error
                Error = Error + "The Phone Number must be less than 50 characters : ";
            }

            //if the Email is blank
            if (CustomerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is too long
            if (CustomerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters: ";
            }

            //if the address is blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 20 characters : ";
            }
            // Return empty string if there are no errors
            return Error;
        }
    }
}
