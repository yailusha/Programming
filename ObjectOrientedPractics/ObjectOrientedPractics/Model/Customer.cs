using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private readonly int _id;
        private static int _allCustomersCount;
        private string _fullname;
        private string _address;
        public int Id { get { return _id; } }
        public static int AllCustomersCount { set { _allCustomersCount = value; } }
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
        public string Address
        {
            get { return _address; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 500, nameof(Address)))
                {
                    _address = value;
                }
            }
        }
        public Customer (string fullname, string address)
        {
            _fullname = fullname;
            _address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
