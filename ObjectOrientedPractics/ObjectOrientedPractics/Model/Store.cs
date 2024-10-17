using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные всех товаров и покупателей.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список товаров класса Item
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список покупателей класса Customer
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Задает и возвращает список объектов класса Item
        /// </summary>
        public List<Item> Items { get; set; }
        /// <summary>
        /// Задает и возвращает список объектов класса Customer
        /// </summary>
        public List<Customer> Customers { get; set; }
        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>
        /// </summary>
        public Store()
        {
            List<Item> Items = new List<Item>();
            List<Customer> Customers = new List<Customer>(); 
        }
    }
}
