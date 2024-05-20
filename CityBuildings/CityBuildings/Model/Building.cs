using CityBuildings.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildings.Model
{
    /// <summary>
    /// Хранит данные о городском строении.
    /// </summary>
    internal class Building
    {
        /// <summary>
        /// Название заведения.
        /// </summary>
        private string _title;
        /// <summary>
        /// Адрес заведения.
        /// </summary>
        private string _adress;
        /// <summary>
        /// Категория заведения.
        /// </summary>
        private Categories _category;
        /// <summary>
        /// Рейтинг заведения.
        /// </summary>
        private double _rating;
        /// <summary>
        /// Уникальный идентификатор заведения.
        /// </summary>
        private int _id;
        /// <summary>
        /// Количество заведений.
        /// </summary>
        private static int _allCityBuildingsCount;
        /// <summary>
        /// Задает количесво заведений.
        /// </summary>
        public static int AllCityBuildingsCount { set { _allCityBuildingsCount = value; } }
        /// <summary>
        /// Возвращает уникальный идентификатор заведения.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Возвращает и задает название заведения.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (Validator.AssertOnLengthRange(value, 200))
                {
                    _title = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает адрес заведения.
        /// </summary>
        public string Adress
        {
            get { return _adress; }
            set
            {
                if (Validator.AssertOnLengthRange(value, 100))
                {
                    _adress = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает категорию заведения.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Возвращает и задает рейтинг заведения.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (Validator.AssertValueInRange(value, 0.0, 5.0))
                {
                    _rating = value;
                }
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Building"/>
        /// </summary>
        /// <param name="title">Название. Не может быть пустым или иметь длину более 200 символов.</param>
        /// <param name="adress">Адрес. Не может быть пустым или иметь длину более 100 символов.</param>
        /// <param name="category">Категория.</param>
        /// <param name="rating">Рейтинг. Должен быть в интервале от 0 до 5.</param>
        public Building(string title, string adress, string category, double rating)
        {
            Title = title;
            Adress = adress;
            Category = category;
            Rating = rating;
            _allCityBuildingsCount++;
            _id = _allCityBuildingsCount;
        }
        public Building()
        {

        }
    }
}
