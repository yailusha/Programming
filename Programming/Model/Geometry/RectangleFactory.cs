using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal static class RectangleFactory
    {
        static public Rectangle Randomize()
        {
            Random random = new Random();
            string[] colours = new string[] { "white", "red", "blue", "purple", "green" };
            int length = random.Next(1, 100);
            int width = random.Next(1, 100);
            int selectedColour = random.Next(colours.Length);
            int centerX = random.Next(1, 350);
            int centerY = random.Next(1, 350);
            Rectangle rectangle = new Rectangle(length, width, colours[selectedColour], new Point2D(centerX, centerY));
            return rectangle;
        }
    }
}
