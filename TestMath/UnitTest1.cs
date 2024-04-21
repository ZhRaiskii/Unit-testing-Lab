using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace TestMath
{
    [TestClass]
    public class UnitTest1
    {
        GeometryCalculator calculator = new GeometryCalculator();

        [TestMethod]
        public void TestRectangleArea()
        {
            var res = calculator.CalculateRectangleArea(5, 3);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            var res = calculator.CalculateSquareArea(6);
            Assert.AreEqual(36, res);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            var res = calculator.CalculateTriangleArea(5, 2);
            Assert.AreEqual(5, res);
        }


        [TestMethod]
        public void TestRectanglePerimeter()
        {
            var res = calculator.CalculateRectanglePerimeter(5, 3);
            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            var res = calculator.CalculateSquarePerimeter(6);
            Assert.AreEqual(24, res);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            var res = calculator.CalculateTrianglePerimeter(3, 4, 5);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void TestCirclePerimeter()
        {
            var res = calculator.CalculateCirclePerimeter(5);
            Assert.IsTrue(res >= 0);
        }


        [TestMethod]
        public void TestRectangleAreaWithZeroValues()
        {
            var res = calculator.CalculateRectangleArea(0, 0);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCirclePerimeterWithLargeRadius()
        {
            var res = calculator.CalculateCirclePerimeter(double.MaxValue);
            Assert.IsTrue(res > 0);
        }


        [TestMethod]
        public void TestRectangleAreaWithLargeValues()
        {
            var res = calculator.CalculateRectangleArea(double.MaxValue, double.MaxValue);
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void TestSquarePerimeterWithZeroValue()
        {
            var res = calculator.CalculateSquarePerimeter(0);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestTrianglePerimeterWithNegativeValue()
        {
            Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTrianglePerimeter(-3, -4, -5));
        }
    }
}
