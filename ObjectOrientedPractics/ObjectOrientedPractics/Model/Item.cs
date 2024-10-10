using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private readonly int _id;
        private static int _allItemsCount;
        private string _name;
        private string _info;
        private double _cost;
        private Category _category;
        public Category Category { get; set; } 
        public int Id { get { return _id; } }
        public static int AllItemsCount { set { _allItemsCount = value; } }
        public string Name
        {
            get { return _name; }
            set
            {
                if(ValueValidator.AssertStringOnLength(value, 200, nameof(Name)))
                {
                    _name = value;
                }
            }
        }
        public string Info
        {
            get { return _info; }
            set
            {
                if(ValueValidator.AssertStringOnLength(value, 1000, nameof(Info)))
                {
                    _info = value;
                }
            }
        }
        public double Cost
        {
            get { return _cost; }
            set
            {
                if(ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost)))
                {
                    _cost = value;
                }
            }
        }
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allItemsCount++;
            _id = _allItemsCount;
        }
        public Item ()
        {

        }
    }
}
