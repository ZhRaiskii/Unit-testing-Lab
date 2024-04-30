using App.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class AreaCalculationStrategy : IShapeCalculationStrategy
    {
        public double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        public double CalculatePerimeter(Shape shape)
        {
            return 0;
        }
    }
}
