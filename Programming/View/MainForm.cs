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
            textBox1.Text = selectedIndex.ToString();
        }

        private void EnumsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Parse_Click(object sender, EventArgs e)
        {
            Weekday week;
            string day = textBox2.Text;
            if (Enum.TryParse<Weekday>(day, out week))
                object value = enum.Parse(typeof(Weekday));

            textBox3.Text = ("Это день недели ({0} = {1})", day, Enum.Parse(typeof(Weekday), day));

        }

        private void Weekday_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultOfWeekday_TextChanged(object sender, EventArgs e)
        {

        }
    }
}