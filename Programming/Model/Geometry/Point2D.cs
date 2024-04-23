using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о координатах.
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// Возвращает и задает координату X.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Возвращает и задает координату Y.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Координата X. Не может быть отрицательной.</param>
        /// <param name="y">Координата Y. Не может быть отрицательной.</param>
        /// <exception cref="ArgumentException">Выдает ошибку, если одна из координат отрицательная.</exception>
        public Point2D(int x, int y)
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
