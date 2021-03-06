﻿using System.Diagnostics;
using System.Linq;
using EveEnv;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    using System.Collections.Generic;

    /// <summary>
    ///This is a test class for EveClientListTest and is intended
    ///to contain all EveClientListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EveClientListTest
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
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            var list = from process in Process.GetProcessesByName("ExeFile")
                       select process;

            foreach (var process in list)
            {
                Console.WriteLine("{0}-{1}", process.MainWindowTitle, process.ProcessName);
            }
        }

        [TestMethod()]
        public void GetWindowsTest()
        {
            var target = new EveClientList();

            var actual = target.GetWindows();
            foreach (var a in actual)
            {
                Console.WriteLine(a);
            }
        }
    }
}
