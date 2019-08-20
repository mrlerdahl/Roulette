using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roulette;

namespace MenuTest
{
    [TestClass]
    public class MenuTest1
    {
        [TestMethod]
        public void TestMethod_StartGameChoice_yes()
        {
            Assert.IsTrue(Menu.StartGameChoice("yes"));
        }

        [TestMethod]
        public void TestMethod_StartGameChoice_yES()
        {
            Assert.IsTrue(Menu.StartGameChoice("yES"));
        }

        [TestMethod]
        public void TestMethod_StartGameChoice_no()
        {
            Assert.IsFalse(Menu.StartGameChoice("no"));
        }

        [TestMethod]
        public void TestMethod_StartGameChoice_nO()
        {
            Assert.IsFalse(Menu.StartGameChoice("nO"));
        }
    }
}
