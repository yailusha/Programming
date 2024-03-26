using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private double _innerRadius;
        private double _outerRadius;
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                if (value > _outerRadius || value < 0)
                {
                    throw new ArgumentException("Value is incorrect. It probably negative or it less than Outer Radius");
                }
                _innerRadius = value;
            }
        }
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                if (value < _innerRadius || value < 0)
                {
                    throw new ArgumentException("Value is incorrect. It probably negative or it bigger than Inner Radius");
                }
                _outerRadius = value;
            }
        }
        public Point2D Center { get; private set; }
        public double Area
        {
            get { return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2)); }
        }
        public Ring( Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
        public Ring() { }
    }
}
