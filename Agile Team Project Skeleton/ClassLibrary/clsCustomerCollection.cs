using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data 
                mThisCustomer = value;
            }
        }



        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@fullName", mThisCustomer.FullName);
            DB.AddParameter("@customerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@customerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@address", mThisCustomer.Address);
            DB.AddParameter("@registrationDate", mThisCustomer.RegistrationDate);
            DB.AddParameter("@emailOptIn", mThisCustomer.EmailOptIn);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@fullName", mThisCustomer.FullName);
            DB.AddParameter("@customerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@customerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@address", mThisCustomer.Address);
            DB.AddParameter("@registrationDate", mThisCustomer.RegistrationDate);
            DB.AddParameter("@emailOptIn", mThisCustomer.EmailOptIn);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            //filters the records based on a full or partial full name code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FullName paramater to the database
            DB.AddParameter("@fullName", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramater DB
            //variable for the index
            //variable  for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                //copy the data from the database to the private data members
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.EmailOptIn = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailOptIn"]);
                AnCustomer.RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;

            }
        }
    }
}