using App;
using App.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMath
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            var calculator = new Calculator(new AreaCalculationStrategy());
            var rectangle = new Rectangle { Length = 5, Width = 3 };
            var res = calculator.CalculateArea(rectangle);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            var calculator = new Calculator(new AreaCalculationStrategy());
            var square = new Square { SideLength = 6 };
            var res = calculator.CalculateArea(square);
            Assert.AreEqual(36, res);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            var calculator = new Calculator(new PerimeterCalculationStrategy());
            var rectangle = new Rectangle { Length = 5, Width = 3 };
            var res = calculator.CalculatePerimeter(rectangle);
            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            var calculator = new Calculator(new PerimeterCalculationStrategy());
            var square = new Square { SideLength = 6 };
            var res = calculator.CalculatePerimeter(square);
            Assert.AreEqual(24, res);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            var calculator = new Calculator(new PerimeterCalculationStrategy());
            var triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };
            var res = calculator.CalculatePerimeter(triangle);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void TestRectangleAreaWithZeroValues()
        {
            var calculator = new Calculator(new AreaCalculationStrategy());
            var rectangle = new Rectangle { Length = 0, Width = 0 };
            var res = calculator.CalculateArea(rectangle);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCirclePerimeterWithLargeRadius()
        {
            var calculator = new Calculator(new PerimeterCalculationStrategy());
            var circle = new Circle { Radius = double.MaxValue };
            var res = calculator.CalculatePerimeter(circle);
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void TestRectangleAreaWithLargeValues()
        {
            var calculator = new Calculator(new AreaCalculationStrategy());
            var rectangle = new Rectangle { Length = double.MaxValue, Width = double.MaxValue };
            var res = calculator.CalculateArea(rectangle);
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void TestSquarePerimeterWithZeroValue()
        {
            var calculator = new Calculator(new PerimeterCalculationStrategy());
            var square = new Square { SideLength = 0 };
            var res = calculator.CalculatePerimeter(square);
            Assert.AreEqual(0, res);
        }
    }
}
