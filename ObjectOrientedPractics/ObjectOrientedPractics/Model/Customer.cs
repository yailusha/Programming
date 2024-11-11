
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
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
    [DataContract]
    internal class Customer
    {
        private static IdGenerator _idGenerator = new IdGenerator();
        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Корзина товаров.
        /// </summary>
        private Cart _cart;
        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders;
        public List<IDiscount> Discounts { get; set; }
        /// <summary>
        /// Возвращает и задает, является ли покупатель приоритетным.
        /// </summary>
        [DataMember]
        public bool IsPriority { get; set; }
        /// <summary>
        /// Возвращает и задает полное имя пользователя.
        /// </summary>
        [DataMember]
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
        /// Возвращает и задает корзину товаров.
        /// </summary>
        [DataMember]
        public Cart Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
            }
        }   
        [DataMember]
        public List<Order> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя. Не может быть пустым или иметь длину более 200 символов.</param>
        /// <param name="address">Адрес. Должен содержать все критерии.</param>
        public Customer (string fullname, Address address, bool isId)
        {
            if (isId)
            {
                Id = _idGenerator.GetNextId();
            }
            Fullname = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>() { new PointsDiscount() }; 
        }
        public Customer (bool isId)
        {
            
        }
        public static void SetId(int value)
        {
            _idGenerator.SetId(value);
        }
        public override string ToString()
        {
            return Fullname;
        }
    }
}
