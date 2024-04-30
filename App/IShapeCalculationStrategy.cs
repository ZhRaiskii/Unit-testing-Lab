using App.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public interface IShapeCalculationStrategy
    {
        double CalculateArea(Shape shape);
        double CalculatePerimeter(Shape shape);
    }
}
