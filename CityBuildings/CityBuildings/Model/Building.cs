using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildings.Model
{
    internal class Building
    {
        private string _title;
        private string _adress;
        private string _category;
        private double _rating;
        private int _id;
        private static int _allCityBuildingsCount;
        public static int AllCityBuildingsCount { set { _allCityBuildingsCount = value; } }
        public int Id { get { return _id; } }
        public string Title
        {
            get { return _title; }
            set
            {
                if (Validator.AssertOnLengthRange(value, 200))
                {
                    _title = value;
                }
            }
        }
        public string Adress
        {
            get { return _adress; }
            set
            {
                if (Validator.AssertOnLengthRange(value, 100))
                {
                    _adress = value;
                }
            }
        }
        public string Category { get; set; }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (Validator.AssertValueInRange(value, 0.0, 5.0))
                {
                    _rating = value;
                }
            }
        }
        public Building(string title, string adress, string category, double rating)
        {
            Title = title;
            Adress = adress;
            Category = category;
            Rating = rating;
            _allCityBuildingsCount++;
            _id = _allCityBuildingsCount;
        }
        public Building()
        {

        }
    }
}
