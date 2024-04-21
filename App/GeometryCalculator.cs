using System;

namespace App
{
    public class GeometryCalculator
    {

        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        public double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double CalculateSquareArea(double sideLength)
        {
            return sideLength * sideLength;
        }


        public double CalculateCirclePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateRectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        public double CalculateTrianglePerimeter(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("Сумма длин двух сторон треугольника должна быть больше длины третьей стороны.");
            }

            return side1 + side2 + side3;
        }

        public double CalculateSquarePerimeter(double sideLength)
        {
            return 4 * sideLength;
        }
    }
}
