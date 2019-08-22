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
            Assert.IsTrue(Bet.Number(5, 5));
        }

        [TestMethod]
        public void TestMethod_Numbers2()
        {
            Assert.IsFalse(Bet.Number(31, 20));
        }

        [TestMethod]
        public void TestMethod_EvensOdds1()
        {
            Assert.IsTrue(Bet.EvensOdds("evens", 22));
        }

        [TestMethod]
        public void TestMethod_EvenOdds2()
        {
            Assert.IsFalse(Bet.EvensOdds("evens", 23));
        }
        [TestMethod]
        public void TestMethod_EvenOdds3()
        {
            Assert.IsTrue(Bet.EvensOdds("odds", 35));
        }

        [TestMethod]
        public void TestMethod_EvenOdds4()
        {
            Assert.IsFalse(Bet.EvensOdds("odds", 30));
        }

        [TestMethod]
        public void TestMethod_RedsBlacks1()
        {
            Assert.IsTrue(Bet.RedsBlacks("red", "red"));
        }

        [TestMethod]
        public void TestMethod_RedsBlacks2()
        {
            Assert.IsFalse(Bet.RedsBlacks("black", "red"));
        }

        [TestMethod]
        public void TestMethod_LowsHighs1()
        {
            Assert.IsTrue(Bet.LowsHighs("low", 10));
        }

        [TestMethod]
        public void TestMethod_LowsHighs2()
        {
            Assert.IsFalse(Bet.LowsHighs("low", 25));
        }
        [TestMethod]
        public void TestMethod_LowsHighs3()
        {
            Assert.IsTrue(Bet.LowsHighs("high", 23));
        }

        [TestMethod]
        public void TestMethod_LowsHighs4()
        {
            Assert.IsFalse(Bet.LowsHighs("high", 5));
        }

        [TestMethod]
        public void TestMethod_Dozens1()
        {
            Assert.IsTrue(Bet.Dozens("first", 10));
        }

        [TestMethod]
        public void TestMethod_Dozens2()
        {
            Assert.IsFalse(Bet.Dozens("first", 29));
        }
        [TestMethod]
        public void TestMethod_Dozens3()
        {
            Assert.IsTrue(Bet.Dozens("second", 15));
        }

        [TestMethod]
        public void TestMethod_Dozens4()
        {
            Assert.IsFalse(Bet.Dozens("second", 5));
        }
        [TestMethod]
        public void TestMethod_Dozens5()
        {
            Assert.IsTrue(Bet.Dozens("third", 30));
        }

        [TestMethod]
        public void TestMethod_Dozens6()
        {
            Assert.IsFalse(Bet.Dozens("third", 17));
        }

        [TestMethod]
        public void TestMethod_Columns1()
        {
            Assert.IsTrue(Bet.Columns("column1", 34));
        }

        [TestMethod]
        public void TestMethod_Columns2()
        {
            Assert.IsFalse(Bet.Columns("column1", 17));
        }
        [TestMethod]
        public void TestMethod_Columns3()
        {
            Assert.IsTrue(Bet.Columns("column2", 17));
        }

        [TestMethod]
        public void TestMethod_Columns4()
        {
            Assert.IsFalse(Bet.Columns("column2", 27));
        }
        [TestMethod]
        public void TestMethod_Columns5()
        {
            Assert.IsTrue(Bet.Columns("column3", 36));
        }

        [TestMethod]
        public void TestMethod_Columns6()
        {
            Assert.IsFalse(Bet.Columns("column3", 1));
        }

        [TestMethod]
        public void TestMethod_Street1()
        {
            Assert.IsTrue(Bet.Street(1, 3));
        }

        [TestMethod]
        public void TestMethod_Street2()
        {
            Assert.IsFalse(Bet.Street(4, 13));
        }

        [TestMethod]
        public void TestMethod_SixNumbers1()
        {
            Assert.IsTrue(Bet.SixNumbers(1, 5));
        }

        [TestMethod]
        public void TestMethod_SixNumbers2()
        {
            Assert.IsFalse(Bet.SixNumbers(7, 30));
        }

        [TestMethod]
        public void TestMethod_Split1()
        {
            Assert.IsTrue(Bet.Split(11, 14, 11));
        }

        [TestMethod]
        public void TestMethod_Split2()
        {
            Assert.IsFalse(Bet.Split(1, 2, 9));
        }

        [TestMethod]
        public void TestMethod_Corner1()
        {
            Assert.IsTrue(Bet.Corner(20, 29));
        }

        [TestMethod]
        public void TestMethod_Corner2()
        {
            Assert.IsFalse(Bet.Corner(3, 20));
        }

    }
}
