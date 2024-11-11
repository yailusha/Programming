using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о процентной скидке.
    /// </summary>
    internal class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Возвращает информацию, сколько было потрачено.
        /// </summary>
        public double TotalSpent { get; private set; }
        /// <summary>
        /// Возвращает категорию товаров.
        /// </summary>
        public Category Category { get; private set; }
        /// <summary>
        /// Возвращает текущую скидку.
        /// </summary>
        public int CurrentDiscountPercentage { get; private set; }
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Скидка на {Category} - {CurrentDiscountPercentage}%.";
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>
        /// </summary>
        /// <param name="category">Категория товара.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            CurrentDiscountPercentage = 1;
            TotalSpent = 0;
        }
        /// <summary>
        /// Считает общую стоимость списка товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Стоимость списка товаров.</returns>
        public double CalculateTotalCost(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost;
        }
        /// <summary>
        /// Рассчитывает размер скидки в рублях.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            double discountAmount = CalculateTotalCost(items) * CurrentDiscountPercentage / 100;
            return discountAmount;
        }
        /// <summary>
        /// Рассчитывает стоимость с учетом скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Стоимость с учетом скидки.</returns>
        public double Apply(List<Item> items)
        {
            return CalculateTotalCost(items) - Calculate(items);
        }
        /// <summary>
        /// Обновляет данные о размере текущей скидки и сколько всего было потрачено.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            TotalSpent = CalculateTotalCost(items);
            CurrentDiscountPercentage = Math.Min(CurrentDiscountPercentage + (int)(TotalSpent / 1000), 10);
        }
        /// <summary>
        /// Предоставляет информацию в более удобной форме.
        /// </summary>
        /// <returns>Возвращает информацию.</returns>
        public override string ToString()
        {
            return Info;
        }
    }
}
