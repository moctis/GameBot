using EVEBotAI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    using System.Threading.Tasks;

    [TestClass()]
    public class TestTest
    {


        private TestContext testContextInstance;

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


        [TestMethod()]
        [DeploymentItem("EVEBotAI.dll")]
        public void testTest()
        {
            EVEBotAI.Test_Accessor target = new EVEBotAI.Test_Accessor(); // TODO: Initialize to an appropriate value
            target.test();
        }


        [TestMethod()]
        public void Test()
        {
            Action new1 = () => Console.WriteLine("New1");
            Action continue1 = () => Console.WriteLine("Continue1");
            Action continue2 = () => Console.WriteLine("Continue2");
            var startNew = new1.Execute().ContinueWith(p => continue1).ContinueWith(p2 => continue2);
        }
    }

    public static class ext
    {
        public static Task Execute(this Action action)
        {
            return Task.Factory.StartNew(action);
        }
    }
}
