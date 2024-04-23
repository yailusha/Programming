using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;
        /// <summary>
        /// Возвращает и задает внутренний радиус кольца. Не может быть больше внешнего радиуса или отрицательным.
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                if (value > _outerRadius || !Validator.AssertOnPositiveValue(value))
                {
                    throw new ArgumentException("Value is incorrect. It probably negative or it less than Outer Radius");
                }
                _innerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает и задает внешний радиус. Не может быть меньше внутреннего радиуса или отрицательным.
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                if (value < _innerRadius || !Validator.AssertOnPositiveValue(value))
                {
                    throw new ArgumentException("Value is incorrect. It probably negative or it bigger than Inner Radius");
                }
                _outerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает и задает координаты центра кольца в двумерном пространстве.
        /// </summary>
        public Point2D Center { get; private set; }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get { return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2)); }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>
        /// </summary>
        /// <param name="center">Координаты центра кольца в двумерном пространстве.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        /// <param name="outerRadius">Внешний радиус.</param>
        public Ring( Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
        public Ring() { }
    }
}
