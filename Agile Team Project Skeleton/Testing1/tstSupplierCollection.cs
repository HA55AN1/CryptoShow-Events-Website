using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Testing1
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that is exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK() 
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to supplier
            //in this case the data needed to be a list object
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierId = 20;
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the supplier
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to supplier
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object
            TestSupplier.SupplierId = 20;
            TestSupplier.SupplierName = "Audi";
            TestSupplier.SupplierEmail = "audi@gmail.com";
            TestSupplier.PhoneNumber = "01234567890";
            TestSupplier.Address = "Leicester LE4 0AH";
            TestSupplier.LastOrderDate = DateTime.Now;
            TestSupplier.Available = true;
            //assign the data to the supplier
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to supplier
            //in this case the data needs to be list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set the properties of the test object
            TestItem.SupplierId = 20;
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the supplier
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierId = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierId = PrimaryKey;
            //modify the test record
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = false;
            //set the record based on the new record 
            AllSuppliers.ThisSupplier = TestItem;
            //update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.SupplierId = 20;
            TestItem.SupplierName = "Audi";
            TestItem.SupplierEmail = "audi@gmail.com";
            TestItem.PhoneNumber = "01234567890";
            TestItem.Address = "Leicester LE4 0AH";
            TestItem.LastOrderDate = DateTime.Now;
            TestItem.Available = true;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test
            TestItem.SupplierId = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //delete the record
            AllSuppliers.Delete();
            //now find the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create an instance of the filtered data
            clsSupplierCollection FilterSuppliers = new clsSupplierCollection();
            //apply a blank string(should return all record)
            FilterSuppliers.ReportByAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, FilterSuppliers.Count);
        }

        [TestMethod]
        public void ReportByAddressNoneFound()
        {
            //create an instance of the class we want to create
            clsSupplierCollection FilterSuppliers = new clsSupplierCollection();
            //apply a address that doesnt exist
            FilterSuppliers.ReportByAddress("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilterSuppliers.Count);
        }

        [TestMethod]
        public void ReportByAddressTestDataFound()
        {
            //create an instance of the class we want to create
            clsSupplierCollection FilterSuppliers = new clsSupplierCollection();
            //varable to be store the outcome
            Boolean OK = true;
            //apply a address that doesnt exist
            FilterSuppliers.ReportByAddress("yyy yyy");
            //check that the correct number of records are found
            if (FilterSuppliers.Count == 2)
            {
                //check to see that the first record is 76
                if (FilterSuppliers.SupplierList[0].SupplierId != 76)
                {
                    OK = false;
                }
                //check to see that the first record is 77
                if (FilterSuppliers.SupplierList[1].SupplierId != 77)
                {
                    OK = false;
                }
            }
            else 
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
    }
}
