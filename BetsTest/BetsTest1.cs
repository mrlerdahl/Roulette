using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roulette;

namespace BetsTest
{
    [TestClass]
    public class BetsTest1
    {
        [TestMethod]
        public void TestMethod_Numbers1()
        {
            Assert.IsTrue(Bets.Number(5, 5));
        }

        [TestMethod]
        public void TestMethod_Numbers2()
        {
            Assert.IsFalse(Bets.Number(31, 20));
        }

        [TestMethod]
        public void TestMethod_EvensOdds1()
        {
            Assert.IsTrue(Bets.EvensOdds("Evens", 22));
        }

        [TestMethod]
        public void TestMethod_EvenOdds2()
        {
            Assert.IsFalse(Bets.EvensOdds("Evens", 23));
        }

        [TestMethod]
        public void TestMethod_RedsBlacks1()
        {
            Assert.IsTrue(Bets.RedsBlacks("Reds", "Red"));
        }

        [TestMethod]
        public void TestMethod_RedsBlacks2()
        {
            Assert.IsFalse(Bets.RedsBlacks("Blacks", "Red"));
        }

        [TestMethod]
        public void TestMethod_LowsHighs1()
        {
            Assert.IsTrue(Bets.LowsHighs("Low", 10));
        }

        [TestMethod]
        public void TestMethod_LowsHighs2()
        {
            Assert.IsFalse(Bets.LowsHighs("Low", 25));
        }

        [TestMethod]
        public void TestMethod_Dozens1()
        {
            Assert.IsTrue(Bets.Dozens("First", 10));
        }

        [TestMethod]
        public void TestMethod_Dozens2()
        {
            Assert.IsFalse(Bets.Dozens("Second", 29));
        }

        [TestMethod]
        public void TestMethod_Columns1()
        {
            Assert.IsTrue(Bets.Columns("Column1", 34));
        }

        [TestMethod]
        public void TestMethod_Columns2()
        {
            Assert.IsFalse(Bets.Columns("Column2", 30));
        }

        [TestMethod]
        public void TestMethod_Street1()
        {
            Assert.IsTrue(Bets.Street(1, 3));
        }

        [TestMethod]
        public void TestMethod_Street2()
        {
            Assert.IsFalse(Bets.Street(4, 10));
        }

        [TestMethod]
        public void TestMethod_SixNumbers1()
        {
            Assert.IsTrue(Bets.SixNumbers(1, 5));
        }

        [TestMethod]
        public void TestMethod_SixNumbers2()
        {
            Assert.IsFalse(Bets.SixNumbers(7, 30));
        }

        [TestMethod]
        public void TestMethod_Split1()
        {
            Assert.IsTrue(Bets.Split(11, 14, 11));
        }

        [TestMethod]
        public void TestMethod_Split2()
        {
            Assert.IsFalse(Bets.Split(1, 2, 9));
        }

        [TestMethod]
        public void TestMethod_Corner1()
        {
            Assert.IsTrue(Bets.Corner());
        }

        [TestMethod]
        public void TestMethod_Corner2()
        {
            Assert.IsFalse(Bets.Corner());
        }

    }
}
