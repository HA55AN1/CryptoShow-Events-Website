using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for staff id property
        private Int32 mStaffId;
        //staffId public property
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        //private data member for staff name property
        private string mStaffName;
        //staff name public property
        public string StaffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }

        //private data member for job title property
        private string mJobTitle;
        //job title public property
        public string JobTitle
        {
            get
            {
                //this line of code sends data out of the property
                return mJobTitle;
            }
            set
            {
                //this line of code allows data into the property
                mJobTitle = value;
            }
        }

        //private data member for staff email property
        private string mStaffEmail;
        //staff email public property
        public string StaffEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }
        }

        //private data member for staff address property
        private string mStaffAddress;
        //staff address public property
        public string StaffAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAddress;
            }
            set
            {
                //this line of code allows data into the property
                mStaffAddress = value;
            }
        }

        //private data member for dateJoined property
        private DateTime mDateJoined;
        //dateJoined public property
        public DateTime DateJoined
        {
            get
            {
                //this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }

        //private data member for isAdmin property
        private Boolean mIsAdmin;
        //isAdmin public property
        public bool IsAdmin
        {
            get
            {
                //this line of code sends data out of the property
                return mIsAdmin;
            }
            set
            {
                //this line of code allows data into the property
                mIsAdmin = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@staffId", staffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one then record is found
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["staffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["staffName"]);
                mJobTitle = Convert.ToString(DB.DataTable.Rows[0]["jobTitle"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["staffEmail"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["staffAddress"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["dateJoined"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["isAdmin"]);

                //return that everything worked ok
                return true;
            }
            else { 
                //return false indicating that there is a problem
                return false; 
            }
        }
        /****** VALID METHOD ******/
        public string Valid(string staffName, string jobTitle, string staffEmail, string staffAddress, string dateJoined)
        {
            //create a string to store the error message
            String Error = "";
            //create a temporary value to store the date value
            DateTime DateTemp;

            //if the staffName is blank
            if(staffName.Length == 0)
            {
                //record the error
                Error += "The StaffName may not be blank : ";
            }
            //if the staffName is greater than 25 characters
            if (staffName.Length > 25)
            {
                //record the error
                Error += "The StaffName may not be greater than 25 characters : ";
            }

            //if the jobTitle is blank
            if (jobTitle.Length == 0)
            {
                //record the error
                Error += "The JobTitle may not be blank : ";
            }
            //if the jobTitle is greater than 20 characters
            if (jobTitle.Length > 20)
            {
                //record the error
                Error += "The JobTitle may not be greater than 20 characters : ";
            }

            //if the staffEmail is blank
            if (staffEmail.Length == 0)
            {
                //record the error
                Error += "The StaffEmail may not be blank : ";
            }
            //if the staffName is greater than 35 characters
            if (staffEmail.Length > 35)
            {
                //record the error
                Error += "The StaffEmail may not be greater than 35 characters : ";
            }

            //if the staffAddress is blank
            if (staffAddress.Length == 0)
            {
                //record the error
                Error += "The StaffAddress may not be blank : ";
            }
            //if the staffName is greater than 50 characters
            if (staffAddress.Length > 50)
            {
                //record the error
                Error += "The StaffAddress may not be greater than 50 characters : ";
            }
            try
            {//copy the dateJoined value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateJoined);
                //check to see if the date is more than 80 years ago
                if (DateTemp < DateTime.Now.Date.AddYears(-80))
                {
                    Error += "The DateJoined may not be more than 80 years ago : ";
                }

                //check to see if the date is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The DateJoined may not in the future : ";
                }
            } catch
            {
                //record the error
                Error += "invalid date : ";
            }
            

            //return any error messages
            return Error;
        }
    }
}