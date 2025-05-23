using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Храниты методы для валидации значений полей.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет, положительное ли число.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <returns>Возвращает true, если положительное.</returns>
        /// <exception cref="ArgumentException">Выдает ошибку, если число отрицательное.</exception>
        public static bool AssertOnPositiveValue (int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Incorrect value: {value} in {nameof(value)}. Value must be positive");
            }
            return true;
        }
        /// <summary>
        /// Проверяет, положительное ли число.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <returns>Возвращает true, если положительное.</returns>
        /// <exception cref="ArgumentException">Выдает ошибку, если число отрицательное.</exception>
        public static bool AssertOnPositiveValue(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException($"Incorrect value: {value} in {nameof(value)}. Value must be positive");
            }
            return true;
        }
        /// <summary>
        /// Проверяет, находится ли число в интервале.
        /// </summary>
        /// <param name="value">Текущее значение.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <returns>Возвращает true, если текущее значение находится в заданном диапазоне.</returns>
        /// <exception cref="ArgumentException">Выдает ошибку, если текущее значение не находится в заданном диапазоне.</exception>
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Value not in range: {value} in {nameof(value)}");
            }
            return true;
        }
        /// <summary>
        /// Проверяет, находится ли число в интервале.
        /// </summary>
        /// <param name="value">Текущее значение.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <returns>Возвращает true, если текущее значение находится в заданном диапазоне.</returns>
        /// <exception cref="ArgumentException">Выдает ошибку, если текущее значение не находится в заданном диапазоне.</exception>
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Value not in range: {value} in {nameof(value)}");
            }
            return true;
        }
    }
}
