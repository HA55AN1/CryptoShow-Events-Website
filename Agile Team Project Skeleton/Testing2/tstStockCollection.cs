using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.CarID = 1;
            TestItem.StockTotal = 12;
            TestItem.CarModel = "Ford";
            TestItem.CarColour = "Blue";
            TestItem.CarBrand = "Focus";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the test property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.CarID = 1;
            TestStock.StockTotal = 12;
            TestStock.CarModel = "Focus";
            TestStock.CarColour = "Blue";
            TestStock.CarBrand = "Ford";
            TestStock.StockArriveDate= DateTime.Now;
            TestStock.StockAvailable = true;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of the objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.CarID = 1;
            TestItem.StockTotal = 12;
            TestItem.CarModel = "Ford";
            TestItem.CarColour = "Blue";
            TestItem.CarBrand = "Focus";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CarID = 1;
            TestItem.StockTotal = 3;
            TestItem.CarModel = "911";
            TestItem.CarColour = "Black";
            TestItem.CarBrand = "Porsche";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockTotal = 3;
            TestItem.CarModel = "911";
            TestItem.CarColour = "Black";
            TestItem.CarBrand = "Porsche";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //modify the test record
            TestItem.StockTotal = 0;
            TestItem.CarModel = "Aventador";
            TestItem.CarColour = "Purple";
            TestItem.CarBrand = "Lamborghini";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = false;
            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;
            //update the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see of ThisStock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an insatance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //Variable to store the priamry key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CarID = 1;
            TestItem.StockTotal = 3;
            TestItem.CarModel = "911";
            TestItem.CarColour = "Black";
            TestItem.CarBrand = "Porsche";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCarBrandMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all record)
            FilteredStocks.ReportByCarBrand("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByCarBrandNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilterdStocks = new clsStockCollection();
            //apply a car brand that doesn't exist
            FilterdStocks.ReportByCarBrand("Honda");
            //test to see that there are no records
            Assert.AreEqual(0, FilterdStocks.Count);
        }

        [TestMethod]
        public void ReportByCarBrandTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a car brand that doesn't exist
            FilteredStocks.ReportByCarBrand("Mini");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check to see that the first record is 80
                if (FilteredStocks.StockList[0].CarID != 80)
                {
                    OK = false;
                }
                //check to see that the first record is 81
                if (FilteredStocks.StockList[1].CarID != 81)
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

    }
}
