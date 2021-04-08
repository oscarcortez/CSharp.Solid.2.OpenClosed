using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Solid.OpenClosed.ModelsGood
{
    public class TriangleGood : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area()
        {
            return Height * Width * 0.5;
        }
    }
}
