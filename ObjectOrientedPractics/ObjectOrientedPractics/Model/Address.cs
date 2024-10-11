using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;
        public int Index
        {
            get { return _index; }
            set
            {
                if (ValueValidator.AssertValueInRange(value, 100000, 999999, nameof(Index)))
                {
                    _index = value;
                }
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, nameof(Country)))
                {
                    _country = value;
                }
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, nameof(City)))
                {
                    _city = value;
                }
            }
        }
        public string Street
        {
            get { return _street; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 100, nameof(Street)))
                {
                    _street = value;
                }
            }
        }
        public string Building
        {
            get { return _building; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, nameof(Building)))
                {
                    _building = value;
                }
            }
        }
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment)))
                {
                    _apartment = value;
                }
            }
        }
        public Address (int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        public Address()
        { }
    }
}
