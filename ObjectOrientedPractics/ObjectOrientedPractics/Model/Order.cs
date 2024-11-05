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
    /// Хранит данные о заказе.
    /// </summary>
    [DataContract]
    internal class Order
    {
        private static IdGenerator _idGenerator = new IdGenerator();
        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        [DataMember]
        public DateTime OrderCreationDate { get; private set; }
        [DataMember]
        public OrderStatus Status { get; set; }
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
        /// Задает и возвращает адрес доставки.
        /// </summary>
        [DataMember]
        public Address Address { get; set; }
        /// <summary>
        /// Задает и возвращает список товаров.
        /// </summary>
        [DataMember]
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
        public Order(Address address, List<Item> items)
        {
            Items = items;
            Address = address;
            OrderCreationDate = DateTime.Now;
            Id = _idGenerator.GetNextId();
            Status = 0;
        }
        public Order() { }
    }
}
