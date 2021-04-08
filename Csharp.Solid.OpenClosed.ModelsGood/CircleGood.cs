using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Solid.OpenClosed.ModelsGood
{
    public class CircleGood : IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
