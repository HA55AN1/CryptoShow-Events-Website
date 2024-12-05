using System;

namespace ClassLibrary
{
    public class clsSupplier
    {


        //private data member for the supplier id
        private Int32 mSupplierId;
        //suplierId public
        public Int32 SupplierId
        {
            get
            {
                //this line of code sends data out of the supplier
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the supplier
                mSupplierId = value;
            }

        }
        


        //private data member for the date added to supplier
        private DateTime mLastOrderDate;
        //date added public property
        public DateTime LastOrderDate
        {
            get
            {
                //this line of code sends data out of the supplier
                return mLastOrderDate;
            }
            set
            {
                //this line of code allows data into the supplier
                mLastOrderDate = value;
            }
        }

        //private data member for the supplier Name
        private string mSupplierName;
        //street public property
        public string SupplierName
        {
            get
            {
                //this line of code sends data out of the supplier
                return mSupplierName;
            }
            set
            {
                //this line of code allows data into the supplier
                mSupplierName = value;
            }
        }


        //private data member for the supplier Email
        private string mSupplierEmail;
        //town public property
        public string SupplierEmail
        {
            get
            {
                //this line of code sends data out of the supplier
                return mSupplierEmail;
            }
            set
            {
                //this line of code allows data into the supplier
                mSupplierEmail = value;
            }
        }



        //private data member for the supplier phone number
        private string mPhoneNumber;
        //town public property
        public string PhoneNumber
        {
            get
            {
                //this line of code sends data out of the supplier
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the supplier
                mPhoneNumber = value;
            }
        }


        //private data member for the supplier phone number
        private string mAddress;
        //town public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the supplier
                return mAddress;
            }
            set
            {
                //this line of code allows data into the supplier
                mAddress = value;
            }
        }


        //private data member for the active property
        private Boolean mAvailable;
        //active public property
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }


        public bool Find(int SupplierId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier id to search for
            DB.AddParameter("@SupplierId", SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mLastOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["LastOrderDate"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                //always return ture
                return true;
            }

            //if no record was found
            else
            {

                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string supplierName, string supplierEmail, string phoneNumber, string address, string lastOrderDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //if the SupplierName is blank
            if (supplierName.Length == 0)
            {
                //record the error
                Error = Error + "The supplier name may be blank : ";
            }
            //if the supplier name is greater than 30 characters
            if (supplierName.Length > 30)
            {
                //record the error
                Error = Error + "The supplier name must be less then 30 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the lastOrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(lastOrderDate);
                if (DateTemp < DateComp) //compare lastOrderDate with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the supplier email blank
            if (supplierEmail.Length == 0)
            {
                //record the error
                Error = Error + "The supplier email may not be blank : ";
            }
            //if the supplier email is too long
            if (supplierEmail.Length > 70)
            {
                //record the error
                Error = Error + "The supplier email must be less than 70 characters : ";
            }

            //is the phone number blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";
            }
            //if the phone number is too long
            if (phoneNumber.Length > 15)
            {
                //record the error
                Error = Error + "This phone number must be less than 15 characters : ";
            }

            //is the address blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the address is too long
            if (address.Length > 150)
            {
                //record the error
                Error = Error + "The address must be less than 150 characters : ";
            }
            //return any error messages
            return Error;  
        }
    }
}