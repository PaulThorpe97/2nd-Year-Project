using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineID()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 OrderLineID = 1;
            //assign the data to the property
            AnOrderLine.OrderLineID = OrderLineID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineID, OrderLineID);
            
        }

        [TestMethod]
        public void OrderID()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String OrderID = "1";
            //assign the data to the property
            AnOrderLine.OrderID = OrderID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, OrderID);

        }

        [TestMethod]
        public void ProductID()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String ProductID = "1";
            //assign the data to the property
            AnOrderLine.ProductID = ProductID;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductID, ProductID);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean OK = true;
            //Create some test data to pass to the method
            String OrderID = "5";
            String ProductID = "5";
            //invoke the method
            OK = AnOrderLine.Valid(OrderID, ProductID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 OrderLineID = 1;
            //Invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderLineIDFoundOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderLineID = 1;
            //Invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //checkthe Order ID
            if (AnOrderLine.OrderLineID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFoundOK()
        {
            //create an instance of the class I want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderLineID = 1;
            //Invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //checkthe Order ID
            if (AnOrderLine.OrderID != "1")
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
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderLineID = 1;
            //Invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //checkthe product ID
            if (AnOrderLine.ProductID != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
    }
}
