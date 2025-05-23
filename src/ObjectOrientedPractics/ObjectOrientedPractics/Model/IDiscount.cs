using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для предоставления скидки.
    /// </summary>
    internal interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке.
        /// </summary>
        string Info { get; }
        /// <summary>
        /// Рассчитывает сумму скидки для заданного списка товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Сумма скидки.</returns>
        double Calculate(List<Item> items);
        /// <summary>
        /// Применяет скидку к заданному списку товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Сумма, на которую была предоствлена скидка.</returns>
        double Apply(List<Item> items);
        /// <summary>
        /// Обновляет количество накопительных баллов.
        /// </summary>
        /// <param name="items">Товары.</param>
        void Update(List<Item> items);
    }
}
