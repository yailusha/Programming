using Programming.Model;
using System.Globalization;
using Rectangle = Programming.Model.Rectangle;
using Movie = Programming.Model.Movie;
using Programming.Model.Enums;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using Programming.Model.Geometry;

namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles;
        private List<Panel> _rectanglePanels;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;


        public MainForm()
        {
            Random random = new Random();
            _movies = new Movie[5];
            _rectanglePanels = new List<Panel>();
            _rectangles = new List<Rectangle>();
            _currentRectangle = new Rectangle(0, 0, "white", new Point2D(0, 0));
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

        private int FindRectangleWithMaxWidth()
        {
            if (_rectangles.Count != 0)
            {
                int indexOfMaxWidth = 0;
                double maxWidth = _rectangles[0].Width;
                for (int i = 1; i < _rectangles.Count; i++)
                {
                    if (maxWidth < _rectangles[i].Width)
                    {
                        maxWidth = _rectangles[i].Width;
                        indexOfMaxWidth = i;
                    }
                }
                return indexOfMaxWidth;
            }
            throw new InvalidOperationException("No rectangles there are");
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

        private void ClearRectangleInfo()
        {
            idRecTextBox.Text = "";
            xRecTextBox.Text = "";
            yRecTextBox.Text = "";
            widthRecTextBox.Text = "";
            heightRecTextBox.Text = "";

            lengthTextBox.Text = "";
            widthTextBox.Text = "";
            colourTextBox.Text = "";
            xCenterTextBox.Text = "";
            yCenterTextBox.Text = "";
            idTextBox.Text = "";
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 1; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void DrawRectangle()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].Location = new Point(_rectangles[i].Center.X, _rectangles[i].Center.Y);
                _rectanglePanels[i].Width = _rectangles[i].Width;
                _rectanglePanels[i].Height = _rectangles[i].Length;
                RectanglePanels.Controls.Add(_rectanglePanels[i]);
            }
        }

        private void UpdateRecListBox()
        {
            RecListBox.Items.Clear();
            foreach (Rectangle rectangle in _rectangles)
            {
                RecListBox.Items.Add($"{rectangle.Id - 1}: (X= {rectangle.Center.X}; Y= {rectangle.Center.Y};" +
                    $" W= {rectangle.Width}; H= {rectangle.Length})");
            }
        }

        private void UpdateRectalgeListBox()
        {
            RectanglesListBox.Items.Clear();
            foreach (Rectangle rectangle in _rectangles)
            {
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id - 1}");
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ValuesListBox.SelectedIndex;
            intValueTextBox.Text = selectedIndex.ToString();
        }

        private void EnumsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void RecListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RecListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentRectangle = _rectangles[selectedIndex];
                idRecTextBox.Text = selectedIndex.ToString();
                xRecTextBox.Text = _currentRectangle.Center.X.ToString();
                yRecTextBox.Text = _currentRectangle.Center.Y.ToString();
                widthRecTextBox.Text = _currentRectangle.Width.ToString();
                heightRecTextBox.Text = _currentRectangle.Length.ToString();
                RectanglePanels.Controls.Clear();
                DrawRectangle();
                FindCollisions();
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];
            if (_currentRectangle != null)
            {
                lengthTextBox.Text = _currentRectangle.Length.ToString();
                widthTextBox.Text = _currentRectangle.Width.ToString();
                colourTextBox.Text = _currentRectangle.Colour.ToString();
                xCenterTextBox.Text = _currentRectangle.Center.X.ToString();
                yCenterTextBox.Text = _currentRectangle.Center.Y.ToString();
                idTextBox.Text = _currentRectangle.Id.ToString();
                RectanglePanels.Controls.Clear();
                DrawRectangle();
            }
        }

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

        private void intValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultOfWeekday_TextChanged(object sender, EventArgs e)
        {

        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int length = int.Parse(lengthTextBox.Text);
                    if (length <= 0 || length > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Length = length;
                    lengthTextBox.BackColor = Color.White;
                    UpdateRecListBox();
                }
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
                if (_currentRectangle != null)
                {
                    int width = int.Parse(widthTextBox.Text);
                    if (width <= 0 || width > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Width = width;
                    widthTextBox.BackColor = Color.White;
                    UpdateRecListBox();
                }
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

        private void xRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int xCoord = int.Parse(xRecTextBox.Text);
                    if (xCoord < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Center.X = xCoord;

                    xRecTextBox.BackColor = Color.White;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                xRecTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                xRecTextBox.BackColor = Color.LightPink;
            }
        }

        private void yRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int yCoord = int.Parse(yRecTextBox.Text);
                    if (yCoord < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Center.Y = yCoord;
                    yRecTextBox.BackColor = Color.White;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                yRecTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                yRecTextBox.BackColor = Color.LightPink;
            }
        }

        private void widthRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int width = int.Parse(widthRecTextBox.Text);
                    if (width <= 0 || width > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Width = width;
                    widthRecTextBox.BackColor = Color.White;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                widthRecTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                widthRecTextBox.BackColor = Color.LightPink;
            }
        }

        private void heightRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int heigth = int.Parse(heightRecTextBox.Text);
                    if (heigth <= 0 || heigth > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Length = heigth;
                    heightRecTextBox.BackColor = Color.White;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                heightRecTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                heightRecTextBox.BackColor = Color.LightPink;
            }
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            string day = TextToParse.Text;
            int numbers;
            if (int.TryParse(day, out numbers))
            {
                resultOfWeekday.Text = "Введите день недели, а не число!";
                return;
            }

            if (Enum.TryParse(day, out weekday))
                resultOfWeekday.Text = $"Это день недели ({weekday} = {(int)weekday})";
            else
                resultOfWeekday.Text = "Нет такого дня недели";
        }

        private void chooseSeasonButton_Click(object sender, EventArgs e)
        {
            switch (seasonComboBox.SelectedIndex)
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

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating();
        }

        private void addRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            Panel panel = new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Width = (int)rectangle.Width,
                Height = (int)rectangle.Length,
                BackColor = Color.FromArgb(127, 127, 255, 127)
            };
            RectanglePanels.Controls.Add(panel);
            _rectanglePanels.Add(panel);
            _rectangles.Add(rectangle);
            UpdateRecListBox();
            UpdateRectalgeListBox();
            FindCollisions();
        }

        private void deleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RecListBox.SelectedIndex != -1)
            {
                int selectedIndex = RecListBox.SelectedIndex;
                ClearRectangleInfo();
                _rectangles.RemoveAt(selectedIndex);
                RecListBox.Items.RemoveAt(selectedIndex);
                RectanglesListBox.Items.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
                RectanglePanels.Controls.RemoveAt(selectedIndex);
                FindCollisions();
            }
        }

        private void seasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}