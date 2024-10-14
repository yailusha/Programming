using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Все покупатели.
        /// </summary>
        private static int _allCustomersCount;
        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Задает количество покупателей.
        /// </summary>
        public static int AllCustomersCount { set { _allCustomersCount = value; } }
        /// <summary>
        /// Возвращает и задает полное имя пользователя.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname)))
                {
                    _fullname = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя. Не может быть пустым или иметь длину более 200 символов.</param>
        /// <param name="address">Адрес. Должен содержать все критерии.</param>
        public Customer (string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
        public Customer ()
        {

        }
    }
}
