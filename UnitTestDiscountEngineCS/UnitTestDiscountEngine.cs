using System;
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
            List<cItem> items = new List<cItem>();
            items.Add(new cItem("Shirt-123-456", 5));

            DiscountEngine de = new DiscountEngine(o);

            // Exercise
            Double totalprice = de.Compute(items);

            // Verify
            Assert.AreEqual(4.75, totalprice);
            Assert.AreEqual(items[0].DiscountType, "Progressive Discount");
            Assert.AreEqual(items[0].Discount, 0.25);
        }

        [TestMethod]
        public void TestOderWithTwoItems()
        {
            // Setup
            List<cItem> items = new List<cItem>();
            items.Add(new cItem("Shirt-123-456", 5));
            items.Add(new cItem("Shirt-123-456", 5));

            DiscountEngine de = new DiscountEngine(o);

            // Exercise
            Double totalprice = de.Compute(items);

            // Verify
            Assert.AreEqual(8, totalprice);
            Assert.AreEqual(items[0].DiscountType, "Progressive Discount");
            Assert.AreEqual(items[0].Discount, 1);
            Assert.AreEqual(items[1].DiscountType, "Progressive Discount");
            Assert.AreEqual(items[1].Discount, 1);
        }

        [TestMethod]
        public void TestOderWithFiveItems()
        {
            // Setup
            List<cItem> items = new List<cItem>();
            items.Add(new cItem("Woman-Socks-123-456", 15));
            items.Add(new cItem("Woman-Socks-123-456", 15));
            items.Add(new cItem("Woman-Socks-123-456", 15));
            items.Add(new cItem("Shirt-222-111", 5));
            items.Add(new cItem("Shirt-123-456", 5));

            DiscountEngine de = new DiscountEngine(o);

            // Exercise
            Double totalprice = de.Compute(items);

            // Verify
            Assert.AreEqual(4.50, totalprice);
            Assert.AreEqual(items[0].DiscountType, "Progressive Discount");
            Assert.AreEqual(items[0].Discount, 1);
            Assert.AreEqual(items[1].DiscountType, "Progressive Discount");
            Assert.AreEqual(items[1].Discount, 1);
        }
    }
}
