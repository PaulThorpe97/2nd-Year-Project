using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderLineID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderLineID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }

        [TestMethod]
        public void NextDayDeliveryPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.NextDayDelivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.NextDayDelivery, TestData);
        }

        [TestMethod]
        public void StandardDeliveryPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.StandardDelivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StandardDelivery, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "21b";
            //assign the data to the property
            AnOrder.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.HouseNo, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "LE1 4AB";
            //assign the data to the property
            AnOrder.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Postcode, TestData);
        }

        [TestMethod]
        public void ProductSizePropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "8.5";
            //assign the data to the property
            AnOrder.ProductSize = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductSize, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Some Street";
            //assign the data to the property
            AnOrder.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            AnOrder.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Town, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.OrderID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.CustomerID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHouseNoFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.HouseNo != "5")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNextDayDeliveryFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.NextDayDelivery != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderDateFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.OrderDate != Convert.ToDateTime("30/03/2017"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderLineIDFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.OrderLineID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPostcodeFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.Postcode != "xxx xxx")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.ProductID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductSizeFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.ProductSize != "5")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestQuantityFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.Quantity != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStandardDeliveryFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.StandardDelivery != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStreetFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTownFoundOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //checkthe Order ID
            if (AnOrder.Street != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "";//this should trigger an error
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "a";//this should be ok
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "aa";//this should be ok
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "aaaa";//this should be ok
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "aaaaaa";//this should be ok
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "aaa";//this should be ok
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "aaaaaaa";//this should fail
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "";
            HouseNo = HouseNo.PadRight(500, 'a'); //this should fail
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            //set the OrderDate to a non date value
            String OrderDate = "this is not a date!";
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "";
            String OrderDate = "30/03/2017";
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "a";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMinPLusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "aa";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "aaaaaaaa";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "aaaaaaaaa";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "aaaaaaaaaa";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "Test Town";
            String Postcode = "aaaa";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = "30/03/2017";
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "a";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "aa";
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "";
            Street = Street.PadRight(49, 'a');
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "";
            Street = Street.PadRight(50, 'a');
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "";
            Street = Street.PadRight(51, 'a');
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "";
            Street = Street.PadRight(25, 'a');
            String Town = "Test Town";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MinLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "";
            String Postcode = "xxx xxx";
            String OrderDate = "30/03/2017";
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "a";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "aa";
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "";
            Town = Town.PadRight(49, 'a');
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "";
            Town = Town.PadRight(50, 'a');
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "";
            Town = Town.PadRight(51, 'a');
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class I want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //Create some test data to pass to the method
            String HouseNo = "5";
            String Street = "Test Street";
            String Town = "";
            Town = Town.PadRight(25, 'a');
            String Postcode = "xxx xxx";
            String OrderDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = AnOrder.Valid(HouseNo, Street, Town, Postcode, OrderDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
