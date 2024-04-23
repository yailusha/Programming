using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о рейсе самолета.
    /// </summary>
    internal class Race
    {
        /// <summary>
        /// Отправная точка.
        /// </summary>
        private string _departurePoint;
        /// <summary>
        /// Точка прибытия.
        /// </summary>
        private string _destinationPoint;
        /// <summary>
        /// Время полета (в минутах).
        /// </summary>
        private int _flightTimeInMinutes;
        /// <summary>
        /// Возвращает и задает отправную точку. Не может быть пустым.
        /// </summary>
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value can not be empty");
                }
                _departurePoint = value;
            }
        }
        /// <summary>
        /// Возвращает и задает точку прибытия. Не может быть пустым.
        /// </summary>
        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value can not be empty");
                }
                _destinationPoint = value;
            }
        }
        /// <summary>
        /// Возвращает и задает длительность полета в минутах. Не может быть отрицательным.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    _flightTimeInMinutes = value;
                }
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Race"/>
        /// </summary>
        /// <param name="departurePoint">Точка отправления. Не может быть пустым.</param>
        /// <param name="destinationPoint">Точка прибытия. Не может быть пустым.</param>
        /// <param name="flightTimeInMinutes">Длительность полета. Не может быть отрицательным.</param>
        public Race(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
        public Race()
        {

        }
    }
}
