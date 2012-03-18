using System.Diagnostics;
using System.Threading;
using EveEnv;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for EnvWindowListTest and is intended
    ///to contain all EnvWindowListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EnvWindowListTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetWindowByStartsWith
        ///</summary>
        [TestMethod()]
        public void GetWindowByEndsWithTest()
        {
            string value = " - Notepad"; 
            var actual = EnvWindowList.GetWindowByEndsWith(value);
            for (var i = 0; i < 5; i++)
                foreach (var window in actual)
                {
                    Console.WriteLine("[{0}]", window.Title);
                    window.BringToFront();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
        }
    }
}
