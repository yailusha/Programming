using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Movie
    {
        private string _title;
        private int _durationInMinutes;
        private int _yearOfRelease;
        private string _genre;
        private double _rating;

        public string Title
        {
            get { return _title; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title can not be empty");
                }
                _title = value;
            }
        }
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    _durationInMinutes = value;
                }
            }
        }
        public int YearOfRelease
        {
            get { return _yearOfRelease; }
            set
            {
                if (Validator.AssertValueInRange(value, 1900, 2024))
                {
                    _yearOfRelease = value;
                }
            }
        }
        public string Genre
        {
            get { return _genre; }
            set
            {
                bool flag = false;
                foreach(char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag || string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Incorrect value. It probably contains numbers or empty");
                }
                _genre = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (Validator.AssertValueInRange(value, 0.0, 10.0))
                {
                    _rating = value;
                }
            }
        }
        public Movie(string title, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }
        public Movie ()
        {

        }
    }
}
