using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о скидке.
    /// </summary>
    internal class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество накопительных баллов.
        /// </summary>
        private int _points;
        /// <summary>
        /// Возвращает и устанавливает накопительные баллы.
        /// </summary>
        public int Points
        {
            get { return _points; }
            set
            {
                if (ValueValidator.AssertValueOnMin(value, 0, nameof(Points)))
                {
                    _points = value;
                }
            }
        }
        /// <summary>
        /// Возвращает информацию о количестве накопительных баллов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов.";
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }
        /// <summary>
        /// Считает общую стоимость товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает общую стоимость товаров.</returns>
        public double CalculateTotalCost(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            return totalCost;
        }
        /// <summary>
        /// Считает скидку.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает скидку на покупку.</returns>
        public double Calculate(List<Item> items)
        {
            double maxDiscount = CalculateTotalCost(items) * 0.30;
            return Math.Min(maxDiscount, Points);
        }
        /// <summary>
        /// Считает стоимость после учета скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает конечную стоимость с учетом скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= (int)discount;
            return CalculateTotalCost(items) - discount;
        }
        /// <summary>
        /// Обновляет количество накопительных баллов.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            Points += (int)(CalculateTotalCost(items) / 10);
        }
        /// <summary>
        /// Выводит информацию в более удобной форме.
        /// </summary>
        /// <returns>Возвращает информацию.</returns>
        public override string ToString()
        {
            return Info;
        }
    }
}
