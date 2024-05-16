namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Students
        {
            public string surname;
            public string name;
            public string year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string needNumbers = "89";
            string[] delimiterChars = { ",", ".", ":", "\t", " ", ", "};
            bool f = true;
            string textToShow = "";
            Students student = new Students();

            student.surname = textBox3.Text;
            student.name = textBox2.Text;
            student.year = textBox1.Text;

            string[] surnames = student.surname.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] names = student.name.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] years = student.year.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);

            if (surnames.Length != 10 || names.Length != 10
                || years.Length != 10 || surnames.Contains("")
                || years.Contains("") || names.Contains("")) return;

            foreach (string c in years)
            {
                if (!needNumbers.Contains(c))
                {
                    f = false;
                    MessageBox.Show("¬ведЄн " + c + " класс, который не подходит!");
                    break;
                }
            }

            if (f)
            {
                for (int i = 0; i < 10; i++)
                    if (years[i] == "8")
                        textToShow = textToShow + surnames[i] + ' ' + names[i] + ' ' + years[i] + " класс \n";

                if (textToShow != "")
                    MessageBox.Show(textToShow);
                else
                    MessageBox.Show("”чеников 8 класса нет");
            }

        }
    }
}