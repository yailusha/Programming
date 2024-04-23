using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _length;
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;
        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _colour;
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Координата центра прямоугольника.
        /// </summary>
        private Point2D _center;
        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }
        /// <summary>
        /// Возвращает и задает длину прямоугольника. Не может быть отрицательной.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Не может быть отрицательной.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает цвет прямоугольника. Не может содержать цифрым или быть пустым.
        /// </summary>
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
        /// <summary>
        /// Задает количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            set { _allRectanglesCount = value; }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина прямоугольника. Не может быть отрицательной.</param>
        /// <param name="width">Ширина прямоугольника. Не может быть отрицательной.</param>
        /// <param name="colour">Цвет прямоугольника. Не может быть пустым или содержать цифры.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
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
