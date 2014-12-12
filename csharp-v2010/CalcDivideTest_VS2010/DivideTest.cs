using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyLibrary_VS2010;

namespace CalcDivideTest_VS2010
{
    /// <summary>
    /// Summary description for DivideTest
    /// </summary>
    [TestClass]
    public class DivideTest
    {
        public DivideTest()
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
        public void TestDivide()
        {
            Assert.AreEqual(42, Calc.Divide(84, 2));
        }

        [TestMethod]
        public void TestCallGetContextInDivideTest()
        {
            TestContext tc = this.TestContext;
            Assert.ReferenceEquals(tc, this.TestContext);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            Calc.Divide(1, 0);
        }

        [TestMethod]
        public void TestCallHorribleCode()
        {
            int result = 0;
            Calc.horrible_code(out result);            
        }
    }
}
