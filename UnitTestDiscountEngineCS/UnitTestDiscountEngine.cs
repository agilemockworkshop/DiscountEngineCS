﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEngineCS;

namespace UnitTestDiscountEngineCS
{
    /// <summary>
    /// Summary description for UnitTestDiscountEngine
    /// </summary>
    [TestClass]
    public class UnitTestDiscountEngine
    {
        public UnitTestDiscountEngine()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestOderWithOneItem()
        {
            // Setup
            PurchaseOrder po = new PurchaseOrder();
            po.AddItem(new cItem("Shirt-123-456", 5));

            DiscountEngine de = new DiscountEngine();

            // Exercise
            Double totalprice = de.Compute(ref po);

            // Verify
            Assert.AreEqual(4.75, totalprice);
            Assert.AreEqual(po.GetOrders()[0].discountScheme, "Progressive Discount");
            Assert.AreEqual(po.GetOrders()[0].discountAmt, 0.25);
        }

        [TestMethod]
        public void TestOderWithTwoItems()
        {
            // Setup
            PurchaseOrder po = new PurchaseOrder();
            po.AddItem(new cItem("Shirt-123-456", 5));
            po.AddItem(new cItem("Shirt-123-456", 5));

            DiscountEngine de = new DiscountEngine();

            // Exercise
            Double totalprice = de.Compute(ref po);

            // Verify
            Assert.AreEqual(8.50, totalprice);
            Assert.AreEqual(po.GetOrders()[0].discountScheme, "Multi-item Discount");
            Assert.AreEqual(po.GetOrders()[0].discountAmt, 0);
            Assert.AreEqual(po.GetOrders()[1].discountScheme, "Multi-item Discount");
            Assert.AreEqual(po.GetOrders()[1].discountAmt, 1.50);
        }

        [TestMethod]
        public void TestOderWithFiveItems()
        {
            // Setup
            PurchaseOrder po = new PurchaseOrder();
            po.AddItem(new cItem("Woman-Socks-123-456", 15));
            po.AddItem(new cItem("Woman-Socks-123-456", 15));
            po.AddItem(new cItem("Woman-Socks-123-456", 15));
            po.AddItem(new cItem("Shirt-222-111", 5));
            po.AddItem(new cItem("Shirt-123-456", 5));

            DiscountEngine de = new DiscountEngine();

            // Exercise
            Double totalprice = de.Compute(ref po);

            // Verify
            Assert.AreEqual(35.00, totalprice);
            Assert.AreEqual(po.GetOrders()[0].discountScheme, "Bundling Discount");
            Assert.AreEqual(po.GetOrders()[0].discountAmt, 6.67);
            Assert.AreEqual(po.GetOrders()[1].discountScheme, "Bundling Discount");
            Assert.AreEqual(po.GetOrders()[1].discountAmt, 6.67);
            Assert.AreEqual(po.GetOrders()[2].discountScheme, "Bundling Discount");
            Assert.AreEqual(po.GetOrders()[2].discountAmt, 6.67);
            Assert.AreEqual(po.GetOrders()[3].discountScheme, "");
            Assert.AreEqual(po.GetOrders()[3].discountAmt, 0);
            Assert.AreEqual(po.GetOrders()[4].discountScheme, "");
            Assert.AreEqual(po.GetOrders()[4].discountAmt, 0);
        }
    }
}
