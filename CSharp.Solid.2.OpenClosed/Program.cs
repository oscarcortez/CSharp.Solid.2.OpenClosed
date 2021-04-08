using CSharp.Solid.ModelsBad;
using System;

namespace CSharp.Solid.OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new()
            { 
                Radius = 10 
            };
            Rectangle rectangle = new()
            { 
                Height = 5,
                Width = 7
            };

            CombinedAreaCalculator cac = new();
            object[] shapes = new object[3];
            shapes[0] = circle;
            shapes[1] = rectangle;
            Console.WriteLine(cac.Area(shapes));
        }
    }
}
