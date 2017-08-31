using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEngineCS;

namespace UnitTestDiscountEngineCS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

namespace UnitTestPurchaseOrder
{
    [TestClass]
    public class UnitTestOrder
    {
        [TestMethod]
        public void TestOrderNoItem()
        {
            PurchaseOrder order = new PurchaseOrder();
            Assert.IsTrue(order.GetOrders().Count == 0);
        }

        public void TestOrderSingleItem()
        {
            PurchaseOrder order = new PurchaseOrder();
            cItem item = new cItem("A100", 50.5);
            order.AddItem(item);
            Assert.IsTrue(order.GetOrders().Count == 1);
        }

        [TestMethod]
        public void TestAddInvalidNumber()
        {

        }

        [TestMethod]
        public void TestAddPositive()
        {

        }
    }
}