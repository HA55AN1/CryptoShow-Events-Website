using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        
        //good test data
        //create some test data to pass the method
        string RegistrationDate = DateTime.Now.ToShortDateString();
        string FullName = "Max";
        string CustomerEmail = "Max123@hotmail.com";
        string CustomerPhone = "+44 32708831";
        string Address = "Milton Keynes";


        //** Validation for full name **//

        [TestMethod]
        public void FullNameMinLessOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            // Variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string FullName = ""; // Full name with length less than 20  //this should trigger an error
            // Invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should be ok
            FullName = FullName.PadRight(19, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; 
            FullName = FullName.PadRight(20, 'a'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            // Variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string FullName = ""; // Full name with length greater than 20
            FullName = FullName.PadRight(21, 'a'); //this should be ok
            // Invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should be ok
            FullName = FullName.PadRight(10,'a');
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; 
            FullName = FullName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //** Validation for Registration Date **//

        [TestMethod]
        public void RegistrationDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void RegistrationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void RegistrationDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the RegistrationDate to a non date value
            string RegistrationDate = "This is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //** Validation for Address **//

        [TestMethod]
        public void AddressLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "a";
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "aa";
            //invoke method 
            Error = AnCustomer.Valid( FullName,CustomerEmail,CustomerPhone,Address,RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //** Validation for Customer Email **//

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //This should fail
            string CustomerEmail = "";
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //This should fail
            string CustomerEmail = "a";
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //This should fail
            string CustomerEmail = "aa";
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke method 
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //** Validation for fCustomer Phone **//

        [TestMethod]
        public void CustomerPhoneLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPhone = "";
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPhone = "a";
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPhone = "aa";
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhone = "aaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhone = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPhone = "";
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhone = "";
            CustomerPhone = CustomerPhone.PadRight(10, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPhone = "";
            CustomerPhone = CustomerPhone.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FullName, CustomerEmail, CustomerPhone, Address, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that if it exists 
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void EmailOptInOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AnCustomer.EmailOptIn = TestData;
            //test to see that the two valves are the same
            Assert.AreEqual(AnCustomer.EmailOptIn, TestData);
            }
        [TestMethod]
        public void RegistrationDateOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.RegistrationDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.RegistrationDate, TestData);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void FullNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the name
            string TestData = "Max";
            //assign the data to the FullName
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FullName, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {     
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the name
            string TestData = "Max123@hotmail.com";
            //assign the data to the FullName
            AnCustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerPhoneOK()
        { 
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the name
            string TestData = "+44 32708831";
            //assign the data to the FullName
            AnCustomer.CustomerPhone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPhone, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the name
            string TestData = "Milton Keynes";
            //assign the data to the FullName
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.CustomerID != 4)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailOptInFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.EmailOptIn != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRegistrationDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the date property
            if (AnCustomer.RegistrationDate != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 12;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.FullName != "Mikka Hakinnen")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.CustomerEmail != "lando@hotmail.com")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.CustomerPhone != "07732708852")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address id
            if (AnCustomer.Address != "MTC")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the error
            Error = AnCustomer.Valid(RegistrationDate, FullName, CustomerEmail, CustomerPhone, Address);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }   
}        
    
