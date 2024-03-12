using Programming.Model;
using System.Globalization;
using Rectangle = Programming.Model.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        public MainForm()
        {
            Random random = new Random();
            _rectangles = new Rectangle[5];
            string[] colours = new string[] { "green", "red", "black", "purple", "orange" };
            for (int i = 0; i < 5; i++)
            {
                int length = random.Next(1, 100);
                int width = random.Next(1, 100);
                int selectedColour = random.Next(0, colours.Length);
                _rectangles[i] = new Rectangle(length, width, colours[selectedColour]);
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
        }   

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Length = double.Parse(lengthTextBox.Text);

            try
            {
                double number = double.Parse(lengthTextBox.Text);

            }
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Width = double.Parse(widthTextBox.Text);
        }

        private void colourTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Colour = colourTextBox.Text;
        }
    }
}