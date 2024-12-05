using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        // Good test data.
        string OrderID = "1";
        string IsPaid = "true";
        string DateOrderPlaced = DateTime.Now.Date.ToString();
        string DeliveryType = "Express";
        string OrderPrice = "10000";
        string StaffNote = "Staff note testing a longer length string.";
        string CustomerNote = "Cnote.";

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Test to see that it exists.
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void IsPaidPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            Boolean TestData = true;
            // Assign the data to the property
            AnOrder.IsPaid = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void DateOrderPlacedPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnOrder.DateOrderPlaced = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateOrderPlaced, TestData);
        }

        [TestMethod]
        public void DeliveryTypePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            string TestData = "Express";
            // Assign the data to the property
            AnOrder.DeliveryType = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryType, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            int TestData = 10000;
            // Assign the data to the property
            AnOrder.OrderPrice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void StaffNotePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            string TestData = "Staff Note.";
            // Assign the data to the property
            AnOrder.StaffNote = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffNote, TestData);
        }

        [TestMethod]
        public void CustomerNotePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            string TestData = "Customer Note.";
            // Assign the data to the property
            AnOrder.CustomerNote = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerNote, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            int TestData = 42;
            // Assign the data to the property
            AnOrder.OrderID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the Order ID.
            if (AnOrder.OrderID != 1) 
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestIsPaidOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check isPaid.
            if (AnOrder.IsPaid != true)
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestDateOrderPlacedOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the DateOrderPlaced.
            if (AnOrder.DateOrderPlaced != Convert.ToDateTime("01/05/2024"))
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestDeliveryTypeOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the DeliveryType.
            if (AnOrder.DeliveryType != "Express")
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestOrderPriceOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the OrderPrice.
            if (AnOrder.OrderPrice != 34000)
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestStaffNoteOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the Order ID.
            if (AnOrder.StaffNote != "Staff note.")
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestCustomerNoteOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 1;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the Order ID.
            if (AnOrder.CustomerNote != "Customer note.")
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            string Error = "";
            // Invoke the metohd.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        /**
         * DateTime / DateOrderPlaced tests. 
        **/
        [TestMethod]
        public void DateOrderPlacedExtremeMin()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create a variable to store the test date data.
            DateTime TestDate;
            // Set the date to Today's date.
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is minus 100 years.
            TestDate = TestDate.AddYears(-100);
            // Convert the date variable to a string variable.
            string DateOrderPlaced = TestDate.ToString();
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderPlacedMinLessOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create a variable to store the test date data.
            DateTime TestDate;
            // Set the date to Today's date.
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is minus 1 day.
            TestDate = TestDate.AddDays(-1);
            // Convert the date variable to a string variable.
            string DateOrderPlaced = TestDate.ToString();
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderPlacedMin()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create a variable to store the test date data.
            DateTime TestDate;
            // Set the date to Today's date.
            TestDate = DateTime.Now.Date;
            // Convert the date variable to a string variable.
            string DateOrderPlaced = TestDate.ToString();
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderPlacedMinPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create a variable to store the test date data.
            DateTime TestDate;
            // Set the date to Today's date.
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 1 day.
            TestDate = TestDate.AddDays(1);
            // Convert the date variable to a string variable.
            string DateOrderPlaced = TestDate.ToString();
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderPlacedExtremeMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create a variable to store the test date data.
            DateTime TestDate;
            // Set the date to Today's date.
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 100 years.
            TestDate = TestDate.AddYears(100);
            // Convert the date variable to a string variable.
            string DateOrderPlaced = TestDate.ToString();
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderPlacedInvalidDate()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Set the DateOrderPlaced to an incorrect value.
            string DateOrderPlaced = "Test.";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        /**
         * String / CustomerNote testing. 
        **/
        [TestMethod]
        public void CustomerNoteMin()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoteMinPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "A";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoteMaxLessOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "".PadLeft(49, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoteMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "".PadLeft(50, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoteMaxPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "".PadLeft(51, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoteMid()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "".PadLeft(25, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNoteExtremeMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string CustomerNote = "".PadLeft(1000, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        /**
         * String / StaffNote testing.
        **/
        [TestMethod]
        public void StaffNoteMin()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoteMinPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "A";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoteMaxLessOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "".PadLeft(49, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoteMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "".PadLeft(50, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoteMaxPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "".PadLeft(51, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoteMid()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "".PadLeft(25, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffExtremeMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string StaffNote = "".PadLeft(1000, 'A');
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        /**
         * String / DeliveryType testing.
        **/
        [TestMethod]
        public void DeliveryTypeInvalidDeliveryType()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string DeliveryType = "Slow";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see that the result is correct.
            Assert.AreEqual(Error, "");
        }

        /**
         * Integer / OrderPrice testing.
        **/
        [TestMethod]
        public void OrderPriceMinMinusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "-1";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMin()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "0";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "1";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxMinusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "14999999";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "15000000";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxPlusOne()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "15000001";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMid()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "7500000";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceExtremeMax()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message.
            String Error = "";
            // Create some test data to pass to the method.
            string OrderPrice = "1000000000";
            // Invoke the method.
            Error = AnOrder.Valid(OrderID, IsPaid, DateOrderPlaced, DeliveryType, OrderPrice, StaffNote, CustomerNote);
            // Test to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }
    }
}
