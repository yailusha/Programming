using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит методы, которые проверяют пересечение фигур.
    /// </summary>
    internal static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если пересекаются.</returns>
        static public bool IsCollision(Rectangle rectangle1,  Rectangle rectangle2)
        {
            //Расстояние между координатами.
            int differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            //Половины сторон.
            double halfWidth = (rectangle1.Width + rectangle2.Width) / 2;
            double halfLength = (rectangle1.Length + rectangle2.Length) / 2;
            return differenceX < halfWidth && differenceY < halfLength;
        }
        /// <summary>
        /// Проверяет, пересекаются ли кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если пересекаются.</returns>
        static public bool IsCollision(Ring ring1, Ring ring2)
        {
            //Расстояние между координатами.
            double differenceX = Math.Abs(ring1.Center.X - ring2 .Center.X);
            double differenceY = Math.Abs(ring1.Center.Y - ring2 .Center.Y);
            //Гипотенуза.
            double hypothesis = Math.Sqrt(differenceY * differenceY + differenceX * differenceX);
            //Сумма внешних радиусов.
            double sumRadiuses = ring1.OuterRadius + ring2.OuterRadius;
            return hypothesis < sumRadiuses;
        }
    }
}
