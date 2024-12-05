using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaffMember
        clsStaff mThisStaffMember = new clsStaff();

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank staff object
                clsStaff Staff = new clsStaff();
                //read in the fields for the current record
                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                Staff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                Staff.JobTitle = Convert.ToString(DB.DataTable.Rows[Index]["jobTitle"]);
                Staff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["staffEmail"]);
                Staff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staffAddress"]);
                Staff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateJoined"]);
                Staff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["isAdmin"]);
                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }
        //public property for StaffList
        public List<clsStaff> StaffList
        {
            get
            {
                //set the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        //public property for Count
        public int Count 
        {
            get
            {
                return StaffList.Count;
            }
            set
            {
                //nothing for now
            }
        }
        //public property for ThisStaffMember
        public clsStaff ThisStaffMember 
        {
            get
            {
                //set the private data
                return mThisStaffMember;
            }
            set
            {
                //set the private data
                mThisStaffMember = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStaffMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffName", mThisStaffMember.StaffName);
            DB.AddParameter("@jobTitle", mThisStaffMember.JobTitle);
            DB.AddParameter("@staffEmail", mThisStaffMember.StaffEmail);
            DB.AddParameter("@staffAddress", mThisStaffMember.StaffAddress);
            DB.AddParameter("@dateJoined", mThisStaffMember.DateJoined);
            DB.AddParameter("@isAdmin", mThisStaffMember.IsAdmin);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the value of thisStaffMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffId", mThisStaffMember.StaffId);
            DB.AddParameter("@staffName", mThisStaffMember.StaffName);
            DB.AddParameter("@jobTitle", mThisStaffMember.JobTitle);
            DB.AddParameter("@staffEmail", mThisStaffMember.StaffEmail);
            DB.AddParameter("@staffAddress", mThisStaffMember.StaffAddress);
            DB.AddParameter("@dateJoined", mThisStaffMember.DateJoined);
            DB.AddParameter("@isAdmin", mThisStaffMember.IsAdmin);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaffMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@staffId", mThisStaffMember.StaffId);
            //excute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByJobTitle(string JobTitle)
        {
            //filters the records based on a full or partial job title
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the job title parameter to the database
            DB.AddParameter("@JobTitle", JobTitle);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByJobTitle");
            //populate array list with data fetched from the table
            populateArray(DB);
        }

        void populateArray(clsDataConnection DB)
        {

            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff object
                clsStaff Staff = new clsStaff();
                //read in the fields for the current record
                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                Staff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                Staff.JobTitle = Convert.ToString(DB.DataTable.Rows[Index]["jobTitle"]);
                Staff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["staffEmail"]);
                Staff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staffAddress"]);
                Staff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateJoined"]);
                Staff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["isAdmin"]);
                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }
    }

    
}