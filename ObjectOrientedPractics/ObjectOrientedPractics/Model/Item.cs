using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    [DataContract]
    internal class Item
    {
        private static IdGenerator _idGenerator = new IdGenerator();
        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;
        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;
        /// <summary>
        /// Категория товара.
        /// </summary>
        [DataMember]
        private Category _category;
        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// Возвращает и задает название товара.
        /// </summary>
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, nameof(Name)))
                {
                    _name = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает описание товара.
        /// </summary>
        [DataMember]
        public string Info
        {
            get { return _info; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 1000, nameof(Info)))
                {
                    _info = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// </summary>
        [DataMember]
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost)))
                {
                    _cost = value;
                }
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название. Не может быть пустым или иметь длину более 200 символов.</param>
        /// <param name="info">Описание. Не может быть пустмы или иметь длину более 1000 символов.</param>
        /// <param name="cost">Стоимость. Должна быть в интервале от 0 до 100000.</param>
        /// <param name="category">Категория. Может содержать категорию, указанную в перечислении.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            Id = _idGenerator.GetNextId();
        }
        public Item()
        {

        }
        public static void SetId(int value)
        {
            _idGenerator.SetId(value);
        }
        public override string ToString()
        {
            return $"{Name} - {Cost}руб.";
        }
    }
}