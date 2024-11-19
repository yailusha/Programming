using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    [DataContract]
    [KnownType(typeof(PointsDiscount))]
    [KnownType(typeof(PercentDiscount))]
    internal class Customer
    {
        private static IdGenerator _idGenerator = new IdGenerator();
        /// <summary>
        /// Имя и фамилия покупателя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;
        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Возвращает id покупателя
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Задает и возвращает, является ли покупатель приоритетным
        /// </summary>
        [DataMember]
        public bool IsPriority { get; set; }
        /// <summary>
        /// Задает и возвращает список скидок покупателя.
        /// </summary>
        [DataMember]
        public List<IDiscount> Discounts { get; set; }
        /// <summary>
        /// Задает и возвращает имя и фамилию покупателя. Не больше 200 символов.
        /// </summary>
        [DataMember]
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }
        /// <summary>
        /// Задает и возвращает корзину покупателя
        /// </summary>
        [DataMember]
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }
        /// <summary>   
        /// Задает и возвращает адреса покупателя.
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
        /// Задает и возвращает список заказов покупателя
        /// </summary>
        [DataMember]
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer">
        /// </summary>
        /// <param name="fullname">Имя и фамилия покупателя. Не больше 200 символов. </param>
        /// <param name="address">Адрес покупателя. Не больше 500 символов</param>
        public Customer(string fullname, Address address, bool isId)
        {
            if (isId)
            {
                Id = _idGenerator.GetNextId();
            }
            Id = _idGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
            IsPriority = false;
            Discounts = new List<IDiscount>() { new PointsDiscount() };
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает экзепляр класса <see cref="Customer"/>
        /// </summary>
        public Customer(bool isId)
        {
            if (isId)
            {
                Id = _idGenerator.GetNextId();
            }
            Fullname = "Surname Name";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>() { new PointsDiscount() };
        }
        /// <summary>
        /// Предоставляет экземпляр класса в более удобной форме.
        /// </summary>
        /// <returns>Возвращает преобразование в строку</returns>
        public override string ToString()
        {
            return Fullname;
        }
        public static void SetId(int value)
        {
            _idGenerator.SetId(value);
        }
    }
}