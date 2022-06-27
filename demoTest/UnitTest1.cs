using demodot1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace demoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer obj = new Customer(1, "userA");
            Assert.AreEqual(1, obj.Id);
            Assert.AreEqual("userA", obj.Name);
        }
        [TestMethod]
        public void UnitTestShouldAlwaysWorkTest()

        {

            Assert.IsTrue(true);

        }



        [TestMethod]

        public void OnePlusTwoEqualThreeTest()

        {

            Assert.IsTrue(true);

        }
    }
}