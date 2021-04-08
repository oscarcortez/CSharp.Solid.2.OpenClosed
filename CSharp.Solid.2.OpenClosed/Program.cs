using CSharp.Solid.ModelsBad;
using System;

namespace CSharp.Solid.OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleBad circle = new()
            { 
                Radius = 10 
            };
            RectangleBad rectangle = new()
            { 
                Height = 5,
                Width = 7
            };

            CombinedAreaCalculatorBad cac = new();
            object[] shapes = new object[3];
            shapes[0] = circle;
            shapes[1] = rectangle;
            Console.WriteLine(cac.Area(shapes));
        }
    }
}
