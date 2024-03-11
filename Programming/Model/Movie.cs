using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Movie
    {
        private string name;
        private int durationInMinutes;
        private int yearOfRelease;
        private string genre;
        private double rating;

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название не может быть пустым");
                }
                name = value;
            }
        }
        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение не может быть меньше нуля");
                }
                durationInMinutes = value;
            }
        }
        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set
            {
                if (value < 1900 || value > 2024)
                {
                    throw new ArgumentException("Год должен быть от 1900 до 2024");
                }
                yearOfRelease = value;
            }
        }
        public string Genre
        {
            get { return genre; }
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
                    throw new ArgumentException("Введено неверное значение");
                }
                genre = value;
            }
        }
        public double Rating
        {
            get { return rating; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Рейтинг должен быть от 0 до 10");
                }
                rating = value;
            }
        }
        public Movie(string name, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            Name = name;
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
