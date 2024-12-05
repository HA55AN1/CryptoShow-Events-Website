using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private member data for ThisSupplier
        clsSupplier mThisSupplier = new clsSupplier();

        //constructor for the class
        public clsSupplierCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property of the supplier list
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }

       //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //set shall worry about this later
               
            }
        }


        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
           set
            {
                //set the private data
                mThisSupplier = value;
            }
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("Address", mThisSupplier.Address);
            DB.AddParameter("LastOrderDate", mThisSupplier.LastOrderDate);
            DB.AddParameter("Available", mThisSupplier.Available);

            //execute the query returning the primary key values
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("Address", mThisSupplier.Address);
            DB.AddParameter("LastOrderDate", mThisSupplier.LastOrderDate);
            DB.AddParameter("Available", mThisSupplier.Available);

            //execute the query returning the primary key values
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by ThisSupplier
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByAddress(string Address)
        {
           //filter the record based on a full or partial address
           //connect to the database
           clsDataConnection DB = new clsDataConnection();
           //send the Address parameter to the database
           DB.AddParameter("@Address", Address);
           //execute the stored procedure
           DB.Execute("sproc_tblSupplier_FilterByAddress");
          //populate the array list with the data table
          PopulateArray(DB);
        }

    

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the record
            RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsSupplier AnSupplier = new clsSupplier();
                //set its properties
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.LastOrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastOrderDate"]);
                AnSupplier.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to the private data member
                mSupplierList.Add(AnSupplier);
                //point at the next record
                Index++;
            }
        }
    }
}