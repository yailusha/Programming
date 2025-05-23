using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Час.
        /// </summary>
        private int _hours;
        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;
        /// <summary>
        /// Возвращает и задает час. Должен быть в интервале от 0 до 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 23))
                {
                    _hours = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает минуты. Должны быть в интервале от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 60))
                {
                    _minutes = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает секунды. Должны быть в интервале от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if(Validator.AssertValueInRange(value, 0, 60))
                {
                    _seconds = value;
                }
            }
        }
        /// <summary>
        /// Создает экземлпяр класса <see cref="Time"/>
        /// </summary>
        /// <param name="hours">Час. Должен быть в интервале от 0 до 23.</param>
        /// <param name="minutes">Минуты. Должны быть в интервале от 0 до 60.</param>
        /// <param name="seconds">Секунды. Должны быть в интервале от 0 до 60.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time()
        {

        }
    }
}
