using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTestFramework
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineID = 5;
            TestItem.OrderID = "5";
            TestItem.ProductID = "5";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }

        [TestMethod]
        public void ThisOrderLinePropertytOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            clsOrderLine TestOrder = new clsOrderLine();
            //set the properties of the test object
            TestOrder.OrderLineID = 5;
            TestOrder.OrderID = "5";
            TestOrder.ProductID = "5";
            //assign the data to the property
            AllOrderLines.ThisOrderLine = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrder);
        }

        [TestMethod]
        public void ListAndCountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineID = 5;
            TestItem.OrderID = "5";
            TestItem.ProductID = "5";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderLineID = 5;
            TestItem.OrderID = "5";
            TestItem.ProductID = "5";
            //set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //Find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderLineID = 5;
            TestItem.OrderID = "5";
            TestItem.ProductID = "5";
            //set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //Find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //delete the record
            AllOrderLines.Delete();
            //now find the record
            Boolean Found = AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = "5";
            TestItem.ProductID = "5";
            //set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //modify the test data
            TestItem.OrderID = "6";
            TestItem.ProductID = "6";
            //set the record based on the new test data
            AllOrderLines.ThisOrderLine = TestItem;
            //update the record
            AllOrderLines.Update();
            //fnd the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test to see thisorderline matches the test data
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void FilterByOrderIDeMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            //apply a blank string (should return all records)
            FilteredOrderLines.FilterByOrderID("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, FilteredOrderLines.Count);
        }

        [TestMethod]
        public void FilterByOrderIDNoneFound()
        {
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            //apply a OrderID that doesn't exist
            FilteredOrderLines.FilterByOrderID("9");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrderLines.Count);
        }

        [TestMethod]
        public void FilterByOrderIDTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a OrderID that doesn't exist
            FilteredOrderLines.FilterByOrderID("1");
            //checked that the correct number of records ar found
            if (FilteredOrderLines.OrderLineList.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredOrderLines.OrderLineList[0].OrderLineID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredOrderLines.OrderLineList[1].OrderLineID != 2)
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
