using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEngineCS;
using Moq;

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
    public class UnitTestOrderPurchase
    {
        [TestMethod]
        public void TestOrderNoItem()
        {
            PurchaseOrder order = new PurchaseOrder();
            Assert.IsTrue(order.GetOrders().Count == 0);
        }

        [TestMethod]
        public void TestOrderSingleItem()
        {
            PurchaseOrder order = new PurchaseOrder();
            cItem item = new cItem("A100", 50.5);
            order.AddItem(item);
            Assert.IsTrue(order.GetOrders().Count == 1);
        }

        [TestMethod]
        public void TestOrderRemoveSingleItem()
        {
            PurchaseOrder order = new PurchaseOrder();
            cItem item = new cItem("A100", 50.5);
            order.AddItem(item);
            Assert.IsTrue(order.GetOrders().Count == 1);
            order.RemoveItem(item.itemNumber);
            Assert.IsTrue(order.GetOrders().Count == 0);
        }
    }

    [TestClass]
    public class UnitTestOrderItem
    {
        [TestMethod]
        public void TestItemFinalPrice()
        {
            cItem item = new cItem("A100", 10);
            PurchaseOrder poList = new PurchaseOrder();
            poList.AddItem(item);

            var mDiscountEngine = new Mock<IDiscountEngine>();
            mDiscountEngine.Setup((p) => p.Compute(ref poList));
        }
    }
}