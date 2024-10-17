using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы для валидаций значений полей.
    /// </summary>
    static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="propertyName">Название свойства.</param>
        /// <returns>Возвращает true, если длина менее максимально допустимой длины.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertStringOnLength (string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength || value.Length == 0)
            {
                throw new ArgumentException($"Too long {propertyName}. It can be maximum {maxLength} symbols.");
            }
            return true;
        }
        /// <summary>
        /// Проверяет, находится ли данное число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Название свойства.</param>
        /// <returns>Возвращает true, если значение находится в заданном диапазоне.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Value of {propertyName} must be in range from {min} to {max}.");
            }
            return true;
        }
    }
}
