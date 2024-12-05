using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Test to see that it exists.
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void AddressListOK() 
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create some test data to assign to the property --
            // in this case, the data needs to be a list of objects.
            List<clsOrder> TestList = new List<clsOrder>();
            // Add an item to the List
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Set its properties.
            TestItem.OrderID = 1;
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "Test note customer.";
            TestItem.StaffNote = "Test note staff.";
            TestItem.OrderPrice = 10000;
            // Add the item to the test list.
            TestList.Add(TestItem);
            // Assign the data to the property.
            AllOrders.OrderList = TestList;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create some test data to assign to the property.
            clsOrder TestOrder = new clsOrder();
            // Set the properties of the test object.
            TestOrder.OrderID = 1;
            TestOrder.IsPaid = true;
            TestOrder.DateOrderPlaced = DateTime.Now;
            TestOrder.DeliveryType = "Slow";
            TestOrder.CustomerNote = "Test note customer.";
            TestOrder.StaffNote = "Test note staff.";
            TestOrder.OrderPrice = 10000;
            // Assign the data to the property.
            AllOrders.ThisOrder = TestOrder;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create some test data to assign to the property --
            // in this case, the data needs to be a list of objects.
            List<clsOrder> TestList = new List<clsOrder>();
            // Add an Item to the List.
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Set its properties.
            TestItem.OrderID = 1;
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "Test note customer.";
            TestItem.StaffNote = "Test note staff.";
            TestItem.OrderPrice = 10000;
            // Add the item to the test list.
            TestList.Add(TestItem);
            // Assign the data to the property.
            AllOrders.OrderList = TestList;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Variable to store the primary key.
            Int32 PrimaryKey = 33;
            // Set its properties.
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "This is a test for the Add Method.";
            TestItem.StaffNote = "This is a test for the AddMethodOK.";
            TestItem.OrderPrice = 100000;
            // Set ThisOrder to the test data.
            AllOrders.ThisOrder = TestItem;
            // Add the record.
            PrimaryKey = AllOrders.Add();
            // Find the record.
            AllOrders.ThisOrder.Find(PrimaryKey);
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Variable to store the primary key.
            Int32 PrimaryKey = 33;
            // Set its properties.
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "This is a test for the Update Method.";
            TestItem.StaffNote = "This is a test for the UpdateMethodOK.";
            TestItem.OrderPrice = 100000;
            // Set ThisOrder to the test data.
            AllOrders.ThisOrder = TestItem;
            // Add the record
            PrimaryKey = AllOrders.Add();
            // Set the primary key of the test data.
            TestItem.OrderID = PrimaryKey;
            // Modify the test record.
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "Updated!";
            TestItem.StaffNote = "Updated 2!";
            TestItem.OrderPrice = 100000;
            // Set the record based on the new test data.
            AllOrders.ThisOrder = TestItem;
            // Update the record.
            AllOrders.Update();
            // Find the record.
            AllOrders.ThisOrder.Find(PrimaryKey);
            // Test to see if ThisOrder matches the test data.
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Variable to store the primary key.
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.OrderID = 1;
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now.Date;
            TestItem.DeliveryType = "Express";
            TestItem.StaffNote = "Staff note.";
            TestItem.CustomerNote = "Customer note.";
            TestItem.OrderPrice = 34000;
            // Set the primary key of the test data.
            TestItem.OrderID = PrimaryKey;
            // Find the record.
            AllOrders.ThisOrder.Find(PrimaryKey);
            // Delete the record.
            AllOrders.Delete();
            // Now find the record.
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            // Test to see that the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStaffNoteMethodOK()
        {
            // Create an instance of the clas containing unfiltered results.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create an instance of the filtered data.
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // Apply a blank string (should return all records)
            FilteredOrders.ReportByStaffNote("");
            // Test to see hat the two values are the same.
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStaffNoteNoneFound() 
        {
            // Create an instance of the class we want to create.
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // Apply a post code that doesn't exist.
            FilteredOrders.ReportByStaffNote("Foo bar.");
            // Test to see that there are no records.
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStaffNoteTestDataFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //create a variable to store the outcome
            Boolean OK = true;
            //apply a job title that does exist
            FilteredOrders.ReportByStaffNote("filterTesting");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 56)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 57)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }

            //test to see that the filtered records are in the list
            Assert.IsTrue(OK);
        }
    }
}
