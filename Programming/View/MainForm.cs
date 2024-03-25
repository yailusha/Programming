using Programming.Model;
using System.Globalization;
using Rectangle = Programming.Model.Rectangle;
using Movie = Programming.Model.Movie;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;
        public MainForm()
        {
            Random random = new Random();
            _rectangles = new Rectangle[5];
            string[] colours = new string[] { "green", "red", "black", "purple", "orange" };
            for (int i = 0; i < _rectangles.Length; i++)
            {
                int length = random.Next(1, 100);
                int width = random.Next(1, 100);
                int selectedColour = random.Next(0, colours.Length);
                int centerX = random.Next(1, 100);
                int centerY = random.Next(1, 100);
                _rectangles[i] = new Rectangle(length, width, colours[selectedColour], new Point2D(centerX, centerY));
            }

            _movies = new Movie[5];
            string[] titles = new string[] { "The Green Mile", "Intouchables", "Forrest Gump",
                                            "The Shawshank Redemption", "Interstellar"};
            string[] genres = new string[] { "drama", "thriller", "fantastic", "crime", "comedy" };
            for (int i = 0; i < _movies.Length; i++)
            {
                int duration = random.Next(1, 240);
                int year = random.Next(1900, 2024);
                double rating = random.NextDouble() * 10;
                int selectedTitle = random.Next(0, titles.Length);
                int selectedGenre = random.Next(0, genres.Length);
                _movies[i] = new Movie(titles[selectedTitle], duration, year, genres[selectedGenre], rating);
            }
            InitializeComponent();
        }
        private readonly Type[] _typeModel = new Type[] { typeof(Colours),
        typeof(FormOfTheStudentEducation), typeof(Genre), typeof (SeasonOfYear),
        typeof(SmartphoneManufacturers), typeof(Weekday)};


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Enums_Click(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ValuesListBox.SelectedIndex;
            IntValue.Text = selectedIndex.ToString();
        }

        private void EnumsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void IntValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Parse_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            string day = TextToParse.Text;
            int numbers;
            if (int.TryParse(day, out numbers))
            {
                NumberOfWeekday.Text = "Введите день недели, а не число!";
                return;
            }

            if (Enum.TryParse(day, out weekday))
                NumberOfWeekday.Text = $"Это день недели ({weekday} = {(int)weekday})";
            else
                NumberOfWeekday.Text = "Нет такого дня недели";
        }

        private void Weekday_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultOfWeekday_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseSeason_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("ХОЛОДНО!");
                    break;
                case 1:
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    MessageBox.Show("Ура! Сессия сдана! Лето!");
                    break;
                case 3:
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];
            lengthTextBox.Text = _currentRectangle.Length.ToString();
            widthTextBox.Text = _currentRectangle.Width.ToString();
            colourTextBox.Text = _currentRectangle.Colour.ToString();
            xCenterTextBox.Text = _currentRectangle.Center.X.ToString();
            yCenterTextBox.Text = _currentRectangle.Center.Y.ToString();
        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(lengthTextBox.Text);
                if (length <= 0 || length > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _currentRectangle.Length = length;
                lengthTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                lengthTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                lengthTextBox.BackColor = Color.LightPink;
            }
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(widthTextBox.Text);
                if (width <= 0 || width > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _currentRectangle.Width = width;
                widthTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                widthTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                widthTextBox.BackColor = Color.LightPink;
            }
        }

        private void colourTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string colour = colourTextBox.Text;

                if (string.IsNullOrEmpty(colour))
                {
                    throw new ArgumentNullException();
                }
                foreach (char c in colour)
                {
                    if (char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                }
                _currentRectangle.Colour = colour;
                colourTextBox.BackColor = Color.White;
            }
            catch (ArgumentNullException)
            {
                colourTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                colourTextBox.BackColor = Color.LightPink;
            }
        }

        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = _rectangles[0].Width;
            int indexOfMaxWidth = 0;
            for (int i = 1; i < _rectangles.Length; i++)
            {
                if (maxWidth < _rectangles[i].Width)
                {
                    maxWidth = _rectangles[i].Width;
                    indexOfMaxWidth = i;
                }
            }
            return indexOfMaxWidth;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void moviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = moviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndex];
            titleTextBox.Text = _currentMovie.Title;
            durationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            yearTextBox.Text = _currentMovie.YearOfRelease.ToString();
            genreTextBox.Text = _currentMovie.Genre;
            ratingTextBox.Text = _currentMovie.Rating.ToString();
        }

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
                durationTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                durationTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                durationTextBox.BackColor = Color.LightPink;
            }
        }

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
                yearTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                yearTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                yearTextBox.BackColor = Color.LightPink;
            }
        }

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
                ratingTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                ratingTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                ratingTextBox.BackColor = Color.LightPink;
            }
        }

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
                genreTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                genreTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentNullException)
            {
                genreTextBox.BackColor = Color.LightPink;
            }
        }

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
                titleTextBox.BackColor = Color.White;
            }
            catch (ArgumentNullException)
            {
                titleTextBox.BackColor = Color.LightPink;
            }
        }
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
        private void movieButton_Click(object sender, EventArgs e)
        {
            moviesListBox.SelectedIndex = FindMovieWithMaxRating();
        }


    }
}