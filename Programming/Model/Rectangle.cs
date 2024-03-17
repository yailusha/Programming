using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        private string _colour;

        public double Length
        {
            get { return _length; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    _length = value;
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    _width = value;
                }
            }
        }
        public string Colour
        {
            get { return _colour; }
            set
            {
                bool flag = false;
                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect value. It probably contains numbers or empty");
                }
                _colour = value;
            }
        }
        public Rectangle(double length, double width, string colour)
        {
            Length = length;
            Width = width;
            Colour = colour;
        }
        public Rectangle()
        {

        }
    }
}
