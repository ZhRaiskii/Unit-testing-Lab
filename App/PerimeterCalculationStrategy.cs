using App.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class PerimeterCalculationStrategy : IShapeCalculationStrategy
    {
        public double CalculateArea(Shape shape)
        {
            return 0;
        }

        public double CalculatePerimeter(Shape shape)
        {
            return shape.CalculatePerimeter();
        }
    }
}
