using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        /******************Supplier OK TESTS******************/

        [TestMethod]
        public void AvailableSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to a supplier
            Boolean TestData = true;
            //assign the data to a supplier
            AnSupplier.Available = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Available, TestData);
        }

        [TestMethod]
        public void LastOrderDateSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            DateTime TestDate = DateTime.Now.Date;
            //asign the date to the supplier
            AnSupplier.LastOrderDate = TestDate;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.LastOrderDate, TestDate);
        }

        [TestMethod]
        public void SupplierIdSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            Int32 TestData = 1;
            //assign the data to the supplier
            AnSupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }

        [TestMethod]
        public void NameSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "Hassan";
            //assign the data to the supplier
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void EmailSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "MyEmail@gmail.com";
            //assign the data to the supplier
            AnSupplier.SupplierEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
        }

        [TestMethod]
        public void PhoneNumberSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "12345678901";
            //assign the data to the supplier
            AnSupplier.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.PhoneNumber, TestData);
        }

        [TestMethod]
        public void AddressSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "Some Street, PostCode";
            //assign the data to the supplier
            AnSupplier.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Address, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method 
            Found = AnSupplier.Find(SupplierId);
            //test to see  if the result is true
            Assert.IsTrue(Found);
        }

        /******************Supplier DATA TESTS******************/

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method 
            Found = AnSupplier.Find(SupplierId);
            //check the Supplier id  of the supplier
            if (AnSupplier.SupplierId != 20)
            {
                OK = false;
            }
            //test to see  if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastOrderDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the last order date added to the supplier
            if (AnSupplier.LastOrderDate != Convert.ToDateTime("01/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier name 
            if (AnSupplier.SupplierName != "Audi")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the email of the supplier
            if (AnSupplier.SupplierEmail != "audi@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the phone number of supplier
            if (AnSupplier.PhoneNumber != "01234567890")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the Address of supplier
            if (AnSupplier.Address != "Leicester LE4 0AH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the active property
            if (AnSupplier.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /******************Vaild METHOD TEST******************/

        //good test data
        //create some test data to pass the method
        string SupplierName = "Audi";
        string SupplierEmail = "audi@gmail.com";
        string PhoneNumber = "01234567890";
        string Address = "Leicester LE4 0AH";
        string LastOrderDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should trigger an error
            // Invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "a"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should be ok
            SupplierName = SupplierName.PadRight(29, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should be ok
            SupplierName = SupplierName.PadRight(30, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should fail
            SupplierName = SupplierName.PadRight(31, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should be ok
            SupplierName = SupplierName.PadRight(15, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should fail
            SupplierName = SupplierName.PadRight(500, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastOrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string LastOrderDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastOrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string LastOrderDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastOrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string LastOrderDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastOrderDateMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string LastOrderDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastOrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string LastOrderDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastOrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //set the LastOrderDate to a non date value
            string LastOrderDate = "this is not a date";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should trigger an error
            // Invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "a"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "aa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = ""; //this should be ok
            SupplierEmail = SupplierEmail.PadRight(69, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = ""; //this should be ok
            SupplierEmail = SupplierEmail.PadRight(70, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = ""; //this should fail
            SupplierEmail = SupplierEmail.PadRight(71, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
         [TestMethod]
        public void SupplierEmailMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = ""; //this should be ok
            SupplierEmail = SupplierEmail.PadRight(35, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = ""; //this should fail
            SupplierEmail = SupplierEmail.PadRight(500, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should trigger an error
            // Invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "a"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should be ok
            PhoneNumber = PhoneNumber.PadRight(14, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should be ok
            PhoneNumber = PhoneNumber.PadRight(15, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should fail
            PhoneNumber = PhoneNumber.PadRight(16, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should be ok
            PhoneNumber = PhoneNumber.PadRight(7, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should fail
            PhoneNumber = PhoneNumber.PadRight(500, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should trigger an error
            // Invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(149, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(150, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should fail
            Address = Address.PadRight(151, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(75, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should fail
            Address = Address.PadRight(500, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, PhoneNumber, Address, LastOrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
