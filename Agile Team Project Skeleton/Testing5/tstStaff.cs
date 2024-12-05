using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        string StaffName = "test name";
        string JobTitle = "admin";
        string StaffEmail = "testname@work.com";
        string StaffAddress = "1 main street";
        string DateJoined = DateTime.Now.ToShortDateString();

        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(Staff);
        }
        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void IsAdminOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            Staff.IsAdmin = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.IsAdmin);
        }

        [TestMethod]
        public void DateJoinedOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            Staff.DateJoined = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.DateJoined);

        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            Staff.StaffId = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.StaffId);

        }

        [TestMethod]
        public void StaffNameOk()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "test name";

            //assign the data to the property
            Staff.StaffName = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.StaffName);

        }

        [TestMethod]
        public void JobTitleOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "test job title";

            //assign the data to the property
            Staff.JobTitle = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.JobTitle);

        }

        [TestMethod]
        public void StaffEmailOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "testEmail@email.com";

            //assign the data to the property
            Staff.StaffEmail = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.StaffEmail);

        }

        [TestMethod]
        public void StaffAddressOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create some test data to assign to the property
            string TestData = "1 main street";

            //assign the data to the property
            Staff.StaffAddress = TestData;

            //test to see that the two value are equal
            Assert.AreEqual(TestData, Staff.StaffAddress);

        }
        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //test to see if the result is found
            Assert.IsTrue(found);
        }
        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.StaffId != 32)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.StaffName != "Testing Don't Delete")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobTitleFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.JobTitle != "testing")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.StaffEmail != "test@work.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.StaffAddress != "test address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.DateJoined != Convert.ToDateTime("22/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsAdminFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();

            //create a Boolean to store the result of the validation
            Boolean found = false;

            //create a Boolean to record if the data is OK (assumes it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 staffID = 32;

            //invoke the method
            found = Staff.Find(staffID);

            //check the staffId
            if (Staff.IsAdmin != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should trigger an error
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a"; //this should be ok
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(24, 'a'); //this should be ok
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(12, 'a'); //this should be ok
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(26, 'a'); //this should fail
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = ""; 
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "a"; 
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "aa";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(19, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(20, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(21, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(10, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JobTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(500, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "a";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "aa";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(34, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(35, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(36, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(18, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(500, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "aa";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            StaffAddress = StaffAddress.PadRight(49, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            StaffAddress = StaffAddress.PadRight(50, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            StaffAddress = StaffAddress.PadRight(51, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            StaffAddress = StaffAddress.PadRight(25, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            StaffAddress = StaffAddress.PadRight(500, 'a');
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date less 500 years
            TestDate = TestDate.AddYears(-500);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date less 81 years
            TestDate = TestDate.AddYears(-81);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateJoinedMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date less 80 years
            TestDate = TestDate.AddYears(-80);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date less 79 years
            TestDate = TestDate.AddYears(-79);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateJoinedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to yesterdays date
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateJoinedMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to tomorrows date
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date less 40 years
            TestDate = TestDate.AddYears(-40);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date plus 500 years
            TestDate = TestDate.AddYears(500);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateJoined = "this is not a valid date type";
            //invoke the method
            Error = Staff.Valid(StaffName, JobTitle, StaffEmail, StaffAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}