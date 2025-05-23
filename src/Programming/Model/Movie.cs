using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    internal class Movie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _title;
        /// <summary>
        /// Длительность фильма (в минутах).
        /// </summary>
        private int _durationInMinutes;
        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _yearOfRelease;
        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;
        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;
        /// <summary>
        /// Возвращает и задает название фильма. Не может быть пустым.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает длительность фильма в минутах. Не может быть отрицательным.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает год выпуска фильма. Должен быть в интервале от 1900 по 2024.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает жанр. Не может быть пустым или содержать цифры.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должно быть в интервале от 0 до 10.
        /// </summary>
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
        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>
        /// </summary>
        /// <param name="title">Название фильма. Не может быть пустым.</param>
        /// <param name="durationInMinutes">Длительность фильма. Не может быть отрицательным.</param>
        /// <param name="yearOfRelease">Год выпуска фильма. Должен быть в интервале от 1900 до 2024.</param>
        /// <param name="genre">Жанр фильма. Не может быть пустым или содержать цифры.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в интервале от 0 до 10.</param>
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
