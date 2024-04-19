using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming.Model
{
    internal class Rectangle
    {
        private int _length;
        private int _width;
        private string _colour;
        private static int _allRectanglesCount;
        private readonly int _id;
        private Point2D _center;
        public int Id
        {
            get { return _id; }
        }
        public Point2D Center { get; set; }
        public int Length
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
        public int Width
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
        public static int AllRectanglesCount
        {
            set { _allRectanglesCount = value; }
        }
        public Rectangle(int length, int width, string colour, Point2D center)
        {
            Length = length;
            Width = width;
            Colour = colour;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        public Rectangle() { }
    }
}
