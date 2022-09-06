using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirthEx;


namespace ThirtExTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Treangle3X4X5()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 0);
            Point p3 = new Point(3, 4);

            Figure testFig = new Figure(p1, p2, p3, "Треугольник");
            testFig.PerimetrCalculator();

            Assert.AreEqual(testFig.Perimetr, 12);
            Assert.AreEqual(testFig.LenghtSide(p1, p2), 3);
            Assert.AreEqual(testFig.LenghtSide(p2, p3), 4);
            Assert.AreEqual(testFig.LenghtSide(p3, p1), 5);
        }

        [TestMethod]
        public void Figure0X0X0X0X0()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 0);
            Point p3 = new Point(0, 0);
            Point p4 = new Point(0, 0);
            Point p5 = new Point(0, 0);

            Figure testFig = new Figure(p1, p2, p3, p4, p5, "Пятиугольник");
            testFig.PerimetrCalculator();

            Assert.AreEqual(testFig.Perimetr, 0);
            Assert.AreEqual(testFig.LenghtSide(p1, p2), 0);
            Assert.AreEqual(testFig.LenghtSide(p2, p3), 0);
            Assert.AreEqual(testFig.LenghtSide(p3, p4), 0);
            Assert.AreEqual(testFig.LenghtSide(p4, p5), 0);
            Assert.AreEqual(testFig.LenghtSide(p5, p1), 0);
            Assert.AreEqual(testFig.FigureName, "Пятиугольник");
        }

        [TestMethod]
        public void Quad8X8X8X8 ()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(8, 0);
            Point p3 = new Point(8, 8);
            Point p4 = new Point(0, 8);

            Figure testFig = new Figure(p1, p2, p3, p4, "Квадрат");
            testFig.PerimetrCalculator();

            Assert.AreEqual(testFig.Perimetr, 32);
            Assert.AreEqual(testFig.LenghtSide(p1, p2), 8);
            Assert.AreEqual(testFig.LenghtSide(p2, p3), 8);
            Assert.AreEqual(testFig.LenghtSide(p3, p4), 8);
            Assert.AreEqual(testFig.LenghtSide(p4, p1), 8);
            Assert.AreEqual(testFig.FigureName, "Квадрат");

            Assert.AreEqual(p1.getX, 0);
            Assert.AreEqual(p1.getY, 0);
        }
    }
}
