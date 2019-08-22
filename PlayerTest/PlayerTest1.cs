using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roulette;

namespace PlayerTest
{
    [TestClass]
    public class PlayerTest1
    {
        Player player = new Player(100);

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(100, player.PlaceMoneyBet(50, true));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-50, player.PlaceMoneyBet(50, false));
        }
    }
}
