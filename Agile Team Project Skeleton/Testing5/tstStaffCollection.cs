using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing5
{
    
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOk() 
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property, in this case a list
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }
        [TestMethod]
        public void ThisStaffMemberPropertyOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //assign the data to the property
            AllStaff.ThisStaffMember = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaffMember, TestItem);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property, in this case a list
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);  
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "bob";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //set thisStaffMember to the test data
            AllStaff.ThisStaffMember = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaffMember.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaffMember, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffName = "greg";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //set thisStaffMember to the test data
            AllStaff.ThisStaffMember = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test data
            TestItem.StaffName = "brad";
            TestItem.JobTitle = "cleaner";
            TestItem.StaffEmail = "brad@work.com";
            TestItem.StaffAddress = "1 different street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = false;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaffMember.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaffMember, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffName = "joe";
            TestItem.JobTitle = "admin";
            TestItem.StaffEmail = "bob@work.com";
            TestItem.StaffAddress = "1 main street";
            TestItem.DateJoined = DateTime.Now;
            TestItem.IsAdmin = true;
            //set thisStaffMember to the test data
            AllStaff.ThisStaffMember = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaffMember.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaffMember.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByJobTitleOK()
        {
            //create an instance of the class containing unfiltered records
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create another instance to filter
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByJobTitle("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        }
        [TestMethod]
        public void ReportByJobTitleNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a job title that doesn't exist
            FilteredStaff.ReportByJobTitle("xxxxxxxx");
            Assert.AreEqual(0, FilteredStaff.Count);

        }
        [TestMethod]
        public void ReportByJobTitleTestDataFound() 
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //create a variable to store the outcome
            Boolean OK = true;
            //apply a job title that does exist
            FilteredStaff.ReportByJobTitle("filterTesting");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffId != 56)
                { 
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffId != 57)
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
