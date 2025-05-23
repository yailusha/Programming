using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит метод генерации прямоугольника.
    /// </summary>
    internal static class RectangleFactory
    {
        /// <summary>
        /// Генерирует прямоугольник.
        /// </summary>
        /// <returns>Прямоугольник со всеми данными.</returns>
        static public Rectangle Randomize()
        {
            Random random = new Random();
            //Список цветов.
            string[] colours = new string[] { "white", "red", "blue", "purple", "green" };

            //Генерируют длину и ширину в интервале от 1 до 100.
            int length = random.Next(1, 100);
            int width = random.Next(1, 100);

            //Генерация случайного цвета.
            int selectedColour = random.Next(colours.Length);

            //Генерация координат.
            int centerX = random.Next(1, 350);
            int centerY = random.Next(1, 350);

            Rectangle rectangle = new Rectangle(length, width, colours[selectedColour], new Point2D(centerX, centerY));
            return rectangle;
        }
    }
}
