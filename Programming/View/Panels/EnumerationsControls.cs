using Programming.Model.Enums;
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
    public partial class EnumerationsControls : UserControl
    {
        public EnumerationsControls()
        {
            InitializeComponent();
        }
        private readonly Type[] _typeModel = new Type[] { typeof(Colours),
        typeof(FormOfTheStudentEducation), typeof(Genre), typeof (SeasonOfYear),
        typeof(SmartphoneManufacturers), typeof(Weekday)};
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
        private void intValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
