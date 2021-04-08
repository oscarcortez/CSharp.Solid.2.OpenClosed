using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Solid.OpenClosed.ModelsGood
{
    public class CombinedAreaCalculatorGood
    {
        public double Area(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if(shape != null)
                    area += shape.Area();
            }
            return area;
        }
    }
}
