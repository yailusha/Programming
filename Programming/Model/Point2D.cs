using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private readonly double _x;
        private readonly double _y;
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point2D(double x, double y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Value must be positive");
            }
            X = x;
            Y = y;
        }
        public Point2D () {}
    }
}
