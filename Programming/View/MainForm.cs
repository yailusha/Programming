using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
    }
}