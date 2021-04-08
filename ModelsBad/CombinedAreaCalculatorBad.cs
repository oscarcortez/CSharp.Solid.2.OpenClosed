using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.OpenClosed.ModelsBad
{
    public class CombinedAreaCalculatorBad
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is RectangleBad)
                {
                    RectangleBad rectangle = (RectangleBad)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                if (shape is CircleBad)
                {
                    CircleBad circle = (CircleBad)shape;
                    area += (circle.Radius * circle.Radius) * Math.PI;
                }
            }
            return area;
        }
    }
}
