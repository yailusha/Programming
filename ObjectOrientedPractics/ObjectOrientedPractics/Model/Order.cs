using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    internal class Order
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Общее количество заказов.
        /// </summary>
        private static int _allOrdersCount;
        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly string _date;
        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private double _amount;
        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Задает количество заказов.
        /// </summary>
        public int AllOrdersCount { set { _allOrdersCount = value; } }
        /// <summary>
        /// Задает и возвращает дату заказа.
        /// </summary>
        public string Date { get { return _date; } }
        /// <summary>
        /// Задает и возвращает адрес доставки.
        /// </summary>
        public Address Address { get; set; }
        /// <summary>
        /// Задает и возвращает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }
        /// <summary>
        /// Возвращает общую стоиость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0;
                if (_items == null || _items.Count == 0) return 0;
                for (int i = 0; i < _items.Count; i++)
                {
                    _amount += _items[i].Cost;
                }
                return _amount;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>
        /// </summary>
        public Order()
        {
            _items = new List<Item>();
            _allOrdersCount++;
            _id = _allOrdersCount;
        }
    }
}
