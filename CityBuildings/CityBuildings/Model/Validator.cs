using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildings.Model
{
    /// <summary>
    /// Хранит методы для валидаций значений полей.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <returns>Возвращает true, если значение находится в заданном диапазоне.</returns>
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (value < min || value > max)
            {
                MessageBox.Show($"Value not in range from 0 to 5, current value: {value}");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="max">Максимально допустимая длина строки.</param>
        /// <returns>Возвращает true, если длина менее максимально допустимой длины.</returns>
        public static bool AssertOnLengthRange(string value, int max)
        {
            if (value.Length > max)
            {
                MessageBox.Show("The value is too high.");
                return false;
            }
            return true;
        }
    }
}
