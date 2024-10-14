using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;
        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;
        /// <summary>
        /// Город.
        /// </summary>
        private string _city;
        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;
        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;
        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;
        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (ValueValidator.AssertValueInRange(value, 100000, 999999, nameof(Index)))
                {
                    _index = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает название страны.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, nameof(Country)))
                {
                    _country = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает название города.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, nameof(City)))
                {
                    _city = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает название улицы.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 100, nameof(Street)))
                {
                    _street = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает номер дома.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, nameof(Building)))
                {
                    _building = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает номер квартиры.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment)))
                {
                    _apartment = value;
                }
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс. Число должно быть шестизначное.</param>
        /// <param name="country">Страна. Не может быть пустым или содрежать более 50 символов.</param>
        /// <param name="city">Город. Не может быть пустым или содрежать более 50 символов.</param>
        /// <param name="street">Улица. Не может быть пустым или содрежать более 100 символов.</param>
        /// <param name="building">Номер дома. Не может быть пустым или содрежать более 10 символов.</param>
        /// <param name="apartment">Номер квартиры. Не может быть пустым или содрежать более 10 символов.</param>
        public Address (int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        public Address()
        {
            Index = 100000;
            Country = "Страна";
            City = "Город";
            Street = "Улица";
            Building = "0";
            Apartment = "0";
        }
    }
}
