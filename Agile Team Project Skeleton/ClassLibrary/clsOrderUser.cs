using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 privUserID;
        private string privUserName;
        private string privPassword;
        private string privDepartment;

        public int UserID
        {
            get
            {
                // Return the data
                return privUserID;
            }
            set
            {
                // Set the data
                privUserID = value;
            }
        }
        public string Password
        {
            get
            {
                // Return the data
                return privPassword;
            }
            set
            {
                // Set the data
                privPassword = value;
            }
        }
        public string UserName
        {
            get
            {
                // Return the data
                return privUserName;
            }
            set
            {
                // Set the data
                privUserName = value;
            }
        }
        public string Department
        {
            get
            {
                // Return the data
                return privDepartment;
            }
            set
            {
                // Set the data
                privDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            // create an instance of the data connection
            clsDataConnection sqlDB = new clsDataConnection();
            // Add the parameters for the user username and password to search for
            sqlDB.AddParameter("@UserName", UserName);
            sqlDB.AddParameter("@Password", Password);
            // Execute the stored procedure
            sqlDB.Execute("sproc_tblUsers_FindUserNamePW");
            // If one record is found (there should be either one or none)
            if (sqlDB.Count == 1)
            {
                // Copy the data from the database to the private data variables.
                privUserID = Convert.ToInt32(sqlDB.DataTable.Rows[0]["UserID"]);
                privUserName = Convert.ToString(sqlDB.DataTable.Rows[0]["UserName"]);
                privPassword = Convert.ToString(sqlDB.DataTable.Rows[0]["Password"]);
                privDepartment = Convert.ToString(sqlDB.DataTable.Rows[0]["Department"]);
                // Return true to confirm everything worked.
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}