using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }



        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "albon@hotmail.com";
            TestItem.CustomerPhone = "0734567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "williams";
            TestItem.FullName = "AlexAlbon";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerEmail = "albon@hotmail.com";
            TestItem.CustomerPhone = "0734567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "williams";
            TestItem.FullName = "AlexAlbon";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test record
            TestItem.EmailOptIn = false;
            TestItem.CustomerEmail = "sebbuemi@hotmail.com";
            TestItem.CustomerPhone = "0734557890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "Milton Keynes";
            TestItem.FullName = "Sebastian Buemi";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "albon@hotmail.com";
            TestItem.CustomerPhone = "0734567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "williams";
            TestItem.FullName = "AlexAlbon";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (this should return all records)
            FilteredCustomers.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportbyFullNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a FullName that does not exist
            FilteredCustomers.ReportByFullName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a full name that doesnt exist
            FilteredCustomers.ReportByFullName("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomers.CustomerList.Count == 2)
            {
                //check to see that the first record is 3
                if (FilteredCustomers.CustomerList[0].CustomerID != 3)
                {
                    OK = false;
                }
                //check to see that the first record is 4
                if (FilteredCustomers.CustomerList[1].CustomerID != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);

        }




        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.EmailOptIn = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerEmail = "max@hotmail.com";
            TestCustomer.CustomerPhone = "1234567890";
            TestCustomer.RegistrationDate = DateTime.Now;
            TestCustomer.Address = "Milton Keynes";
            TestCustomer.FullName = "Max Verstappen";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "max@hotmail.com";
            TestItem.CustomerPhone = "1234567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "Milton Keynes";
            TestItem.FullName = "Max Verstappen";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "max@hotmail.com";
            TestItem.CustomerPhone = "1234567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "Milton Keynes";
            TestItem.FullName = "Max Verstappen";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);



        }
    }
}
