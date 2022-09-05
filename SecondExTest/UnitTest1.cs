using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondEx;

namespace SecondExTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectangleAreaWithSide_5_and_Side_2()
        {
            double side1 = 5.0;
            double side2 = 5.0;
            var rec1 = new Rectangle(side1, side2);

            Assert.AreEqual(rec1.Area, 25);
            Assert.AreEqual(rec1.Perimetr, 20);

        }

        [TestMethod]
        public void RectangleEmptyParam()
        {
            var rec1 = new Rectangle();

            Assert.AreEqual(rec1.Area, 0);
            Assert.AreEqual(rec1.Perimetr, 0);
        }

        [TestMethod]
        public void RectangleAreaWithSide_8_and_Side_1()
        {
            double side1 = 8.0;
            double side2 = 1.0;
            var rec1 = new Rectangle(side1, side2);

            double res1 = rec1.AreaCalculator();
            double res2 = rec1.PerimetrCalculator();

            Assert.AreEqual(res1, 8);
            Assert.AreEqual(res2, 18);
        }

        [TestMethod]
        public void RectangleSides()
        {
            double firstSide = 10.0;
            double SecondSide = 18.0;
            var rec1 = new Rectangle(firstSide, SecondSide);

            Assert.AreEqual(rec1.side1, firstSide);
            Assert.AreEqual(rec1.side2, SecondSide);
        }
    }
}
