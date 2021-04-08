using Csharp.Solid.OpenClosed.ModelsGood;
using CSharp.Solid.OpenClosed.ModelsBad;
using System;

namespace CSharp.Solid.OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleBad circleBad = new()
            { 
                Radius = 10 
            };
            RectangleBad rectangleBad = new()
            { 
                Height = 5,
                Width = 7
            };            
            object[] shapesBad = new object[3];
            shapesBad[0] = circleBad;
            shapesBad[1] = rectangleBad;
            Console.WriteLine("bad: without open closed");
            CombinedAreaCalculatorBad cacBad = new();
            Console.WriteLine($"Area calculated without Open Closed: {cacBad.Area(shapesBad)}");

            Console.WriteLine();

            CircleGood circleGood = new()
            {
                Radius = 10
            };
            RectangleGood rectangleGood = new()
            {
                Height = 5,
                Width = 7
            };
            IShape[] shapesGood = new IShape[3];
            shapesGood[0] = circleGood;
            shapesGood[1] = rectangleGood;
            Console.WriteLine("good: WITH open closed");
            CombinedAreaCalculatorGood cacGood = new();
            Console.WriteLine($"Area calculated WITH Open Closed: {cacGood.Area(shapesGood)}");
        }
    }
}
