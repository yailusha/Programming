using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double length;
        private double width;
        private string colour;

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной");
                }
                width = value;
            }
        }
        public string Colour
        {
            get { return colour; }
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
                    throw new ArgumentException("Такого значения не может быть");
                }
                colour = value;
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
