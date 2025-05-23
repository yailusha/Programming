using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Производит поиск фильма с наибольшим рейтингом.
    /// </summary>
    public partial class MoviesControls : UserControl
    {
        private Movie[] _movies;
        private Movie _currentMovie;
        public MoviesControls()
        {
            Random random = new Random();
            //Создание массива из 5 фильмов.
            _movies = new Movie[5];

            string[] titles = new string[] { "The Green Mile", "Intouchables", "Forrest Gump",
                                            "The Shawshank Redemption", "Interstellar"};
            string[] genres = new string[] { "drama", "thriller", "fantastic", "crime", "comedy" };
            //Генерация данных фильма.
            for (int i = 0; i < _movies.Length; i++)
            {
                //Генерация длительности фильма, года выпуска, рейтинга, названия и жанра. 
                int duration = random.Next(1, 240);
                int year = random.Next(1900, 2024);
                double rating = random.NextDouble() * 10;
                int selectedTitle = random.Next(0, titles.Length);
                int selectedGenre = random.Next(0, genres.Length);
                _movies[i] = new Movie(titles[selectedTitle], duration, year, genres[selectedGenre], rating);
            }
            InitializeComponent();
        }
        /// <summary>
        /// Осуществляет поиск фильма с наибольшим рейтингом.
        /// </summary>
        /// <returns>Возвращает индекс фильма, с наибольшим рейтингом.</returns>
        private int FindMovieWithMaxRating()
        {
            double maxRating = _movies[0].Rating;
            int indexOfMaxRating = 0;
            for (int i = 1; i < _movies.Length; i++)
            {
                if (maxRating < _movies[i].Rating)
                {
                    maxRating = _movies[i].Rating;
                    indexOfMaxRating = i;
                }
            }
            return indexOfMaxRating;
        }
        /// <summary>
        /// Отображение данных выбранного фильма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndex];
            titleTextBox.Text = _currentMovie.Title;
            durationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            yearTextBox.Text = _currentMovie.YearOfRelease.ToString();
            genreTextBox.Text = _currentMovie.Genre;
            ratingTextBox.Text = _currentMovie.Rating.ToString();
        }
        /// <summary>
        /// Изменение и сохранение новой длительности фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int duration = int.Parse(durationTextBox.Text);
                if (duration <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _currentMovie.DurationInMinutes = duration;
                durationTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                durationTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                durationTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение нового года выпуска фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(yearTextBox.Text);
                if (year < 1900 || year > 2024)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _currentMovie.YearOfRelease = year;
                yearTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                yearTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                yearTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение нового рейтинга фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rating = double.Parse(ratingTextBox.Text);
                if (rating < 0 || rating > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _currentMovie.Rating = rating;
                ratingTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                ratingTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                ratingTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение нового жанра фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string genre = genreTextBox.Text;

                if (string.IsNullOrEmpty(genre))
                {
                    throw new ArgumentNullException();
                }
                foreach (char c in genre)
                {
                    if (char.IsDigit(c))
                    {
                        throw new FormatException();
                    }
                }
                _currentMovie.Genre = genre;
                genreTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                genreTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentNullException)
            {
                genreTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Сохранение и изменение нового названия фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string title = titleTextBox.Text;
                if (string.IsNullOrEmpty(title))
                {
                    throw new ArgumentNullException();
                }
                _currentMovie.Title = title;
                titleTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (ArgumentNullException)
            {
                titleTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Осуществляет поиск фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating();
        }
    }
}
