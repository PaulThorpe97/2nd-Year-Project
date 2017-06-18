using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTestFramework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.ProductSize = "5";
            TestItem.Quantity = 5;
            TestItem.HouseNo = "5";
            TestItem.Street = "TestStreet";
            TestItem.Town = "TestTown";
            TestItem.Postcode = "xxx xxx";
            TestItem.StandardDelivery = true;
            TestItem.NextDayDelivery = false;
            TestItem.OrderDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertytOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 5;
            TestOrder.ProductID = 5;
            TestOrder.ProductSize = "5";
            TestOrder.Quantity = 5;
            TestOrder.HouseNo = "5";
            TestOrder.Street = "TestStreet";
            TestOrder.Town = "TestTown";
            TestOrder.Postcode = "xxx xxx";
            TestOrder.StandardDelivery = true;
            TestOrder.NextDayDelivery = false;
            TestOrder.OrderDate = DateTime.Now.Date;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.ProductSize = "5";
            TestItem.Quantity = 5;
            TestItem.HouseNo = "5";
            TestItem.Street = "TestStreet";
            TestItem.Town = "TestTown";
            TestItem.Postcode = "xxx xxx";
            TestItem.StandardDelivery = true;
            TestItem.NextDayDelivery = false;
            TestItem.OrderDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.ProductSize = "5";
            TestItem.Quantity = 5;
            TestItem.HouseNo = "5";
            TestItem.Street = "TestStreet";
            TestItem.Town = "TestTown";
            TestItem.Postcode = "xxx xxx";
            TestItem.StandardDelivery = true;
            TestItem.NextDayDelivery = false;
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 5;
            TestItem.ProductID = 5;
            TestItem.ProductSize = "5";
            TestItem.Quantity = 5;
            TestItem.HouseNo = "5";
            TestItem.Street = "TestStreet";
            TestItem.Town = "TestTown";
            TestItem.Postcode = "xxx xxx";
            TestItem.StandardDelivery = true;
            TestItem.NextDayDelivery = false;
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 5;
            TestItem.ProductSize = "5";
            TestItem.Quantity = 5;
            TestItem.HouseNo = "5";
            TestItem.Street = "TestStreet";
            TestItem.Town = "TestTown";
            TestItem.Postcode = "xxx xxx";
            TestItem.StandardDelivery = true;
            TestItem.NextDayDelivery = false;
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.ProductID = 6;
            TestItem.ProductSize = "6";
            TestItem.Quantity = 6;
            TestItem.HouseNo = "6";
            TestItem.Street = "TestStreet2";
            TestItem.Town = "TestTown2";
            TestItem.Postcode = "xxx xxp";
            TestItem.StandardDelivery = false;
            TestItem.NextDayDelivery = true;
            TestItem.OrderDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void FilterByPostcodeMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.FilterByPostcode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void FilterByPostcodeNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a postcode that doesn't exist
            FilteredOrders.FilterByPostcode("ppp ppp");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void FilterByPostcodeTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredOrders.FilterByPostcode("NG2 1PN");
            //checked that the correct number of records ar found
            if (FilteredOrders.OrderList.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredOrders.OrderList[0].OrderID !=1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredOrders.OrderList[1].OrderID != 2)
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
