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
            Assert.IsTrue(Bets.EvensOdds("evens", 22));
        }

        [TestMethod]
        public void TestMethod_EvenOdds2()
        {
            Assert.IsFalse(Bets.EvensOdds("evens", 23));
        }
        [TestMethod]
        public void TestMethod_EvenOdds3()
        {
            Assert.IsTrue(Bets.EvensOdds("odds", 35));
        }

        [TestMethod]
        public void TestMethod_EvenOdds4()
        {
            Assert.IsFalse(Bets.EvensOdds("odds", 30));
        }

        [TestMethod]
        public void TestMethod_RedsBlacks1()
        {
            Assert.IsTrue(Bets.RedsBlacks("red", "red"));
        }

        [TestMethod]
        public void TestMethod_RedsBlacks2()
        {
            Assert.IsFalse(Bets.RedsBlacks("black", "red"));
        }

        [TestMethod]
        public void TestMethod_LowsHighs1()
        {
            Assert.IsTrue(Bets.LowsHighs("low", 10));
        }

        [TestMethod]
        public void TestMethod_LowsHighs2()
        {
            Assert.IsFalse(Bets.LowsHighs("low", 25));
        }
        [TestMethod]
        public void TestMethod_LowsHighs3()
        {
            Assert.IsTrue(Bets.LowsHighs("high", 23));
        }

        [TestMethod]
        public void TestMethod_LowsHighs4()
        {
            Assert.IsFalse(Bets.LowsHighs("high", 5));
        }

        [TestMethod]
        public void TestMethod_Dozens1()
        {
            Assert.IsTrue(Bets.Dozens("first", 10));
        }

        [TestMethod]
        public void TestMethod_Dozens2()
        {
            Assert.IsFalse(Bets.Dozens("first", 29));
        }
        [TestMethod]
        public void TestMethod_Dozens3()
        {
            Assert.IsTrue(Bets.Dozens("second", 15));
        }

        [TestMethod]
        public void TestMethod_Dozens4()
        {
            Assert.IsFalse(Bets.Dozens("second", 5));
        }
        [TestMethod]
        public void TestMethod_Dozens5()
        {
            Assert.IsTrue(Bets.Dozens("third", 30));
        }

        [TestMethod]
        public void TestMethod_Dozens6()
        {
            Assert.IsFalse(Bets.Dozens("third", 17));
        }

        [TestMethod]
        public void TestMethod_Columns1()
        {
            Assert.IsTrue(Bets.Columns("column1", 34));
        }

        [TestMethod]
        public void TestMethod_Columns2()
        {
            Assert.IsFalse(Bets.Columns("column1", 17));
        }
        [TestMethod]
        public void TestMethod_Columns3()
        {
            Assert.IsTrue(Bets.Columns("column2", 17));
        }

        [TestMethod]
        public void TestMethod_Columns4()
        {
            Assert.IsFalse(Bets.Columns("column2", 27));
        }
        [TestMethod]
        public void TestMethod_Columns5()
        {
            Assert.IsTrue(Bets.Columns("column3", 36));
        }

        [TestMethod]
        public void TestMethod_Columns6()
        {
            Assert.IsFalse(Bets.Columns("column3", 1));
        }

        [TestMethod]
        public void TestMethod_Street1()
        {
            Assert.IsTrue(Bets.Street(1, 3));
        }

        [TestMethod]
        public void TestMethod_Street2()
        {
            Assert.IsFalse(Bets.Street(4, 13));
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
            Assert.IsTrue(Bets.Corner(20, 29));
        }

        [TestMethod]
        public void TestMethod_Corner2()
        {
            Assert.IsFalse(Bets.Corner(3, 20));
        }

    }
}
