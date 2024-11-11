using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    [DataContract]
    [KnownType(typeof(PriorityOrder))]
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
        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
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
        /// Конечная стоимость товаров с учетом скидки.
        /// </summary>
        private double _total;
        /// <summary>
        /// Возвращает конечную стоимость товаов с учетом скидки.
        /// </summary>
        public double Total
        {
            get
            {
                if (Amount - DIscountAmount < 0)
                {
                    throw new ArgumentException("Value must be positive.");
                }
                _total = Amount - DIscountAmount;
                return _total;
            }
        }
        /// <summary>
        /// Возвращает и задает размер примененной скидки.
        /// </summary>
        public double DIscountAmount { get; set; }
        /// <summary>
        /// Задает и возвращает адрес доставки.
        /// </summary>
        [DataMember]
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Задает и возвращает список товаров.
        /// </summary>
        [DataMember]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }
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
        public Order(Address address, List<Item> items, bool isId)
        {
            if (isId)
            {
                Id = _idGenerator.GetNextId();
            }
            Items = items;
            Address = address;
            OrderCreationDate = DateTime.Now;
            Status = 0;
        }
        public Order(bool isId)
        {
            if (isId)
            {
                Id = _idGenerator.GetNextId();
            }
            OrderCreationDate = DateTime.Now;
            Items = new List<Item>();
            Address = new Address();
            Status = 0;
        }
    }
}
