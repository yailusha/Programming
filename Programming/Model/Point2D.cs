using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private readonly int _x;
        private readonly int _y;
        public int X { get; private set; }
        public int Y { get; private set; }
        public Point2D (int x, int y)
        {
            if (x < 0 ||  y < 0)
            {
                throw new ArgumentException("Value must be positive");
            }
            X = x;
            Y = y;
        }
    }
}
