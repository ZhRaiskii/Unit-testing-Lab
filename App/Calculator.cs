using App.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Calculator
    {
        private IShapeCalculationStrategy _calculationStrategy;

        public Calculator(IShapeCalculationStrategy calculationStrategy)
        {
            _calculationStrategy = calculationStrategy;
        }

        public void SetCalculationStrategy(IShapeCalculationStrategy strategy)
        {
            _calculationStrategy = strategy;
        }

        public double CalculateArea(Shape shape)
        {
            return _calculationStrategy.CalculateArea(shape);
        }

        public double CalculatePerimeter(Shape shape)
        {
            return _calculationStrategy.CalculatePerimeter(shape);
        }
    }
}
